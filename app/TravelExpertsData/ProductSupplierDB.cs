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
    }
}
