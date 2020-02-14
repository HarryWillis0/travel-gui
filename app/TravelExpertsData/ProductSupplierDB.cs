using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class ProductSupplierDB
    {
        /// <summary>
        /// Get all available suppliers from supplier table in DB.
        /// </summary>
        /// <returns>List of supplier objects</returns>
        public static List<Supplier> GetProductSuppliersByProductID(int prodID)
        {
            List<Supplier> Suppliers = new List<Supplier>();
            Supplier sup;

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // query to get product supplier id
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
                        cmd.Parameters.AddWithValue("@prodID", prodID);

                        // run query
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) // found result
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
        /// Get product supplier id for certain product and supplier
        /// </summary>
        /// <param name="prodId">The product id</param>
        /// <param name="supId">The product's supplier id/param>
        /// <returns>The product supplier id, or -1 if query fails</returns>
        public static int GetId(int prodId, int supId)
        {
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                // query to get product supplier id
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
