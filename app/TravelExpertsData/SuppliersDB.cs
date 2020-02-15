using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class SuppliersDB
    {
        ///Written by Raymond Edeamrere
        public static bool EditSupplier(Supplier newSupplier)
        {
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                SqlTransaction addNewPkgTran;

                int rowsAffected;

                string insert = "Update Suppliers set SupName = @SupName" +
                                " where SupplierId = @SupplierId";

                // start transaction
                addNewPkgTran = connection.BeginTransaction();

                // set up cmd properties
                cmd.Connection = connection;
                cmd.Transaction = addNewPkgTran;
                cmd.CommandText = insert;

                // add non-nullable parameters
                cmd.Parameters.AddWithValue("@SupplierId", newSupplier.SupplierId);
                cmd.Parameters.AddWithValue("@SupName", newSupplier.SupName);


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
            }
        }

        ///Written by Raymond Edeamrere
        public static bool AddSupplier(Supplier newSupplier)
        {
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                SqlTransaction addNewPkgTran;

                int rowsAffected;

                string insert = "INSERT INTO Suppliers (SupplierId, SupName )" +
                                "VALUES (@SupplierId, @SupName)";

                // start transaction
                addNewPkgTran = connection.BeginTransaction();

                // set up cmd properties
                cmd.Connection = connection;
                cmd.Transaction = addNewPkgTran;
                cmd.CommandText = insert;

                // add non-nullable parameters
                cmd.Parameters.AddWithValue("@SupplierId", newSupplier.SupplierId);

                // nullable parameters
                if (string.IsNullOrEmpty(newSupplier.SupName))
                    cmd.Parameters.AddWithValue("@SupName", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@SupName", newSupplier.SupName);

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
            }
        }

        ///Written by Raymond Edeamrere
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            Supplier curr;

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // query to select all from suppliers table
                string query = "SELECT SupplierId, SupName " +
                               "FROM Suppliers ";
                //"ORDER BY SupplierId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // run query
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            // process each supplier and add to list
                            curr = new Supplier();
                            curr.SupplierId = (int)reader["SupplierId"];

                            // check for null on nullable columns
                            int col = reader.GetOrdinal("SupName");
                            if (reader.IsDBNull(col))
                                curr.SupName = null;
                            else
                                curr.SupName = (string)reader["SupName"];

                            suppliers.Add(curr);
                        }
                    }
                    catch (Exception ex) // unanticipated errors
                    {
                        throw ex;
                    }
                }
            }

            return suppliers;
        }

        /// <summary>
        /// find suppliers of certain product
        /// </summary>
        /// <param name="prodId">certain product</param>
        /// <returns>list of suppliers of certain product</returns>
        /// @author Harry
        public static List<Supplier> FindSuppliersOfProduct(int prodId)
        {
            List<Supplier> suppliers = new List<Supplier>(); // empty list
            Supplier curr;

            using (SqlConnection conn = TravelExpertsDB.GetConnection())
            {
                // query to find suppliers of product selected from combo box
                string query =
                    "SELECT Suppliers.SupplierId, SupName " +
                    "FROM Suppliers " +
                        "join Products_Suppliers " +
                            "on Products_Suppliers.SupplierId = Suppliers.SupplierId " +
                        "join Products " +
                            "on Products.ProductId = Products_Suppliers.ProductId " +
                    "WHERE Products.ProductId = @ProductId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", prodId); // add parameter to query

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) // while there's still results
                        {
                            curr = new Supplier();
                            curr.SupplierId = (int)reader["SupplierId"];
                            // check for null on nullable columns
                            int col = reader.GetOrdinal("SupName");
                            if (reader.IsDBNull(col))
                                curr.SupName = null;
                            else
                                curr.SupName = (string)reader["SupName"];
                            suppliers.Add(curr);
                        }
                    } // recycle reader
                } // recycle cmd
            } // close and recycle conn
            return suppliers;
        }

        /// <summary>
        /// Get all available suppliers from supplier table in DB.
        /// </summary>
        /// <returns>List of supplier objects</returns>
        public static List<Supplier> GetAllSuppliers()
        {
            List<Supplier> Suppliers = new List<Supplier>();
            Supplier sup;

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // query to get product supplier id
                string query = "SELECT SupplierID, SupName " +
                               "FROM [Suppliers] " +
                               "ORDER BY SupName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // run query
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) // found result
                            {
                                sup = new Supplier();
                                
                                sup.SupplierId = Convert.ToInt32(reader["SupplierID"]);
                                // check for null on nullable columns
                                int col = reader.GetOrdinal("SupName");
                                if (reader.IsDBNull(col))
                                    sup.SupName = null;
                                else
                                    sup.SupName = (string)reader["SupName"];
                                Suppliers.Add(sup);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return Suppliers;
        }
    }
}
