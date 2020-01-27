using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// Operations on Packages table of TravelExperts DB
    /// </summary>
    /// @author Harry 
    public static class PackageDB
    {
        /// <summary>
        /// Get all packages from table Packages in TravelExperts DB
        /// </summary>
        /// <returns>List of packages</returns>
        public static List<Package> GetPackages()
        {
            List<Package> packages = new List<Package>(); // to return 
            Package curr; // to process row in table

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // query to select all from packages table
                string query = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                               "FROM Packages " +
                               "ORDER BY PackageId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // run query
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) // while there are results from query
                        {
                            // process each package and add to list
                            curr = new Package();
                            curr.PackageId = (int)reader["PackageId"];
                            curr.PkgName = (string)reader["PkgName"];

                            // process nullable columns in DB
                            ProcessNullablesFromDB(reader, curr);

                            packages.Add(curr);
                        }
                    }
                    catch (Exception ex) // unanticipated errors
                    {
                        throw ex;
                    }
                } // close and recycle cmd
            } // close and recycle connection

            return packages;
        }

        /// <summary>
        /// Update a package in DB
        /// </summary>
        /// <param name="newPkg">The new package</param>
        /// <returns>true on success, false otherwise</returns>
        public static bool UpdatePackage(Package oldPkg, Package newPkg)
        {
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                SqlTransaction updatePkgTran;
                int rowsAffected;

                // query to update package
                string update = "UPDATE Packages " +                    // able to edit everything but id
                                "SET PkgName = @NewPkgName, " +
                                    "PkgStartDate = @NewPkgStartDate, " +
                                    "PkgEndDate = @NewPkgEndDate, " +
                                    "PkgDesc = @NewPkgDesc, " +
                                    "PkgBasePrice = @NewPkgBasePrice, " +
                                    "PkgAgencyCommission = @NewPkgAgencyCommission " +
                                "WHERE PackageId = @OldId"; // optimistic concurrency

                // start transaction
                updatePkgTran = connection.BeginTransaction();

                // set up cmd properties
                cmd.Connection = connection;
                cmd.Transaction = updatePkgTran;
                cmd.CommandText = update;

                // add non-nullable parameters
                cmd.Parameters.AddWithValue("@NewPkgName", newPkg.PkgName);
                cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPkg.PkgBasePrice);
                cmd.Parameters.AddWithValue("@OldId", oldPkg.PackageId);

                // for nullable properties, have to check for null 
                ProcessNewPkgNullables(cmd, newPkg);
                
                try
                {
                    // run query
                    rowsAffected = cmd.ExecuteNonQuery();

                    // update failed
                    if (rowsAffected != 1)
                    {
                        updatePkgTran.Rollback();
                        return false;
                    }

                    // commit transaction and close
                    updatePkgTran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            } // close and recycle connection
        }

        /// <summary>
        /// Add a new package to DB
        /// </summary>
        /// <param name="newPkg">package to add</param>
        /// <returns>true if successful, false otherwise</returns>
        public static bool AddPackage(Package newPkg)
        {
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                SqlTransaction addNewPkgTran;
                int rowsAffected;

                string insert = "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, " +
                                                      "PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                                "VALUES (@PkgName, @NewPkgStartDate, @NewPkgEndDate, " +
                                        "@NewPkgDesc, @PkgBasePrice, @NewPkgAgencyCommission)";

                // start transaction
                addNewPkgTran = connection.BeginTransaction();

                // set up cmd properties
                cmd.Connection = connection;
                cmd.Transaction = addNewPkgTran;
                cmd.CommandText = insert;

                // add non-nullable parameters
                cmd.Parameters.AddWithValue("@PkgName", newPkg.PkgName);
                cmd.Parameters.AddWithValue("@PkgBasePrice", newPkg.PkgBasePrice);

                // for nullable properties, have to check for null
                ProcessNewPkgNullables(cmd, newPkg);

                try
                {
                    // run query
                    rowsAffected = cmd.ExecuteNonQuery();

                    // insert failed
                    if (rowsAffected != 1)
                    {
                        addNewPkgTran.Rollback();
                        return false;
                    }

                    // commit transaction
                    addNewPkgTran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            } // close and recycle connection
        }
        /// <summary>
        /// Find products and their suppliers associated with a package
        /// </summary>
        /// <param name="pkgId">ID of package to find products and suppliers for</param>
        /// <param name="productNames">Names of products associated with package</param>
        /// <param name="supplierNames">Names of products supplier associated with package</param>
        public static void GetPackageProducts(int pkgId, out List<string> productNames, out List<string> supplierNames)
        {
            productNames = new List<string>();
            supplierNames = new List<string>();

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT ProdName, SupName " +
                               "FROM Packages " +
                                    "join Packages_Products_Suppliers " +
                                        "on Packages_Products_Suppliers.PackageId = Packages.PackageId " +
                                    "join Products_Suppliers " +
                                        "on Products_Suppliers.ProductSupplierId = Packages_Products_Suppliers.ProductSupplierId " +
                                    "join Suppliers " +
                                        "on Products_Suppliers.SupplierId = Suppliers.SupplierId " +
                                    "join Products " +
                                        "on Products.ProductId = Products_Suppliers.ProductId " +
                               "WHERE Packages.PackageId = @PackageId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // add parameter to query
                        cmd.Parameters.AddWithValue("@PackageId", pkgId);

                        // run query
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) // while there are results
                        {
                            // process each result and add to appropiate list
                            productNames.Add((string)reader["ProdName"]);
                            supplierNames.Add((string)reader["SupName"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                } // recycle cmd
            } // close and recycle connection
        }

        /// <summary>
        /// Process properties of a package that represent nullable columns in DB
        /// </summary>
        /// <param name="cmd">SqlCommand object that is going to run a query</param>
        /// <param name="pkg">Package of properties to test</param>
        private static void ProcessNewPkgNullables(SqlCommand cmd, Package pkg)
        {
            if (pkg.PkgStartDate == null)
                cmd.Parameters.AddWithValue("@NewPkgStartDate", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewPkgStartDate", pkg.PkgStartDate);

            if (pkg.PkgEndDate == null)
                cmd.Parameters.AddWithValue("@NewPkgEndDate", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewPkgEndDate", pkg.PkgEndDate);

            if (pkg.PkgDesc == null)
                cmd.Parameters.AddWithValue("@NewPkgDesc", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewPkgDesc", pkg.PkgDesc);

            if (pkg.PkgAgencyCommission == null)
                cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", pkg.PkgAgencyCommission);
        }

        /// <summary>
        /// Process nullable columns from DB and transfer data to Package object
        /// </summary>
        /// <param name="reader">data reader with data from database</param>
        /// <param name="curr">package to transfer data to</param>
        private static void ProcessNullablesFromDB(SqlDataReader reader, Package curr)
        {
            // check for null on nullable columns
            int col = reader.GetOrdinal("PkgStartDate");
            if (reader.IsDBNull(col))
                curr.PkgStartDate = null;
            else
                curr.PkgStartDate = (DateTime?)reader["PkgStartDate"];

            col = reader.GetOrdinal("PkgEndDate");
            if (reader.IsDBNull(col))
                curr.PkgEndDate = null;
            else
                curr.PkgEndDate = (DateTime?)reader["PkgEndDate"]; col = reader.GetOrdinal("PkgEndDate");

            col = reader.GetOrdinal("PkgAgencyCommission");
            if (reader.IsDBNull(col))
                curr.PkgAgencyCommission = null;
            else
                curr.PkgAgencyCommission = (decimal?)reader["PkgAgencyCommission"];

            curr.PkgDesc = (string)reader["PkgDesc"];
            curr.PkgBasePrice = (decimal)reader["PkgBasePrice"];
        }
    }
}
