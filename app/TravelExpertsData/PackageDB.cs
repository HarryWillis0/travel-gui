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

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) // while there are results from query
                        {
                            // process each package and add to list
                            curr = new Package();
                            curr.PackageId = (int)reader["PackageId"];
                            curr.PkgName = (string)reader["PkgName"];

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

                            packages.Add(curr);
                        }
                    }
                    catch (SqlException ex) // error from SQL Server
                    {
                        throw ex;
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

                // add paramaters to cmd
                // non-nullable properties - just set old package property to newPkg property
                cmd.Parameters.AddWithValue("@NewPkgName", newPkg.PkgName);
                cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPkg.PkgBasePrice);
                cmd.Parameters.AddWithValue("@OldId", oldPkg.PackageId);
                // for nullable properties, have to check for null 
                if (newPkg.PkgStartDate == null)
                    cmd.Parameters.AddWithValue("@NewPkgStartDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@NewPkgStartDate", newPkg.PkgStartDate);

                if (newPkg.PkgEndDate == null)
                    cmd.Parameters.AddWithValue("@NewPkgEndDate", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@NewPkgEndDate", newPkg.PkgEndDate);

                if (newPkg.PkgDesc == null)
                    cmd.Parameters.AddWithValue("@NewPkgDesc", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@NewPkgDesc", newPkg.PkgDesc);

                if (newPkg.PkgAgencyCommission == null)
                    cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPkg.PkgAgencyCommission);
                
                try
                {
                    rowsAffected = cmd.ExecuteNonQuery();

                    // update failed
                    if (rowsAffected != 1)
                    {
                        updatePkgTran.Rollback();
                        return false;
                    }

                    // attempt to commit transaction
                    updatePkgTran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            } // close and recycle connection
        }
    }
}
