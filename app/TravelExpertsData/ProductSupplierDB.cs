using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// Actions and methods for Products Suppliers table of TravelExperts DB
    /// </summary>
    /// @author Chi 
    public static class ProductSupplierDB
    {
        /// <summary>
        /// Get a list of all suppliers for a specific product from Products_Suppliers table in DB.
        /// </summary>
        /// <param name="prodID">The product's supplier id</param>
        /// <returns>List of Suppliers</returns>
        public static List<Supplier> GetProductSuppliersByProductID(int prodID)
        {
            List<Supplier> Suppliers = new List<Supplier>();
            Supplier sup;

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // query to get product suppliers list
                string query = "SELECT SupName, Products_Suppliers.SupplierID " +
                               "FROM [Products_Suppliers] " +
                                    "JOIN Suppliers " +
                                        "ON Products_Suppliers.SupplierId = Suppliers.SupplierId " +
                               "WHERE ProductID = @prodID " +
                               "ORDER BY SupName";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Add parameter to query
                        cmd.Parameters.AddWithValue("@prodID", prodID);

                        // Run query
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) // While there is data
                            {
                                sup = new Supplier();
                                sup.SupName = reader["SupName"].ToString();
                                sup.SupplierId = Convert.ToInt32(reader["SupplierID"]);
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

        /// <summary>
        /// Get a specific product supplier id for a certain product and supplier
        /// </summary>
        /// <param name="prodId">The product id</param>
        /// <param name="supId">The product's supplier id/param>
        /// <returns>The product supplier id, or -1 if query fails</returns>
        public static int GetId(int prodId, int supId)
        {
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // Query to get product supplier id
                string query = "SELECT ProductSupplierId " +
                               "FROM Products_Suppliers " +
                               "WHERE ProductId = @ProductId " +
                               "AND SupplierId = @SupplierId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // add parameter to query
                        cmd.Parameters.AddWithValue("@ProductId", prodId);
                        cmd.Parameters.AddWithValue("@SupplierId", supId);

                        // run query
                        SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                        
                        if (reader.Read()) // found result
                        {
                            return (int)reader["ProductSupplierId"];
                        }

                        // search failed
                        return -1;
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// Add a product supplier for a specific product and supplier to the Products_Suppliers table.
        /// </summary>
        /// <param name="prodId">The product id</param>
        /// <param name="supId">The product's supplier id/param>
        /// <returns>Rows affected by query, 1 for success and 0 for failure</returns>
        public static int AddProductSupplier(int prodID, int supID)
        {
            int result = 0;

            string query = "INSERT INTO Products_Suppliers (ProductID, SupplierID) " +
                                "VALUES (@prodID, @supID)";

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@prodID", prodID);
                    cmd.Parameters.AddWithValue("@supID", supID);

                    result = cmd.ExecuteNonQuery();
                }
            } // close and recycle connection

            return result;
        }

        /// <summary>
        /// Delete a product supplier for a specific product and supplier from the Products_Suppliers table.
        /// </summary>
        /// <param name="prodId">The product id</param>
        /// <param name="supId">The product's supplier id/param>
        /// <returns>Rows affected by query, 1 for success and 0 for failure</returns>
        public static int RemoveProductSupplier(int prodID, int supID)
        {
            int result = 0;

            string query = "DELETE FROM Products_Suppliers " +
                                "WHERE ProductID = @prodID " +
                                    "AND SupplierID = @supID";

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@prodID", prodID);
                    cmd.Parameters.AddWithValue("@supID", supID);

                    result = cmd.ExecuteNonQuery();
                }
            } // close and recycle connection

            return result;
        }
    }
}
