using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TravelExpertsData
{
    /// <summary>
    /// Provides static methods for accessing and modifying Product Supplier table in Travel Expert DB.
    /// </summary>
    class ProductSupplierDB
    {
        /// <summary>
        /// Retrieves a specific Product Supplier based on supplier's ID.
        /// </summary>
        /// <param name="supplierID">The supplier's ID to be returned.</param>
        /// <returns>ProductSupplier object from database.</returns>
        public static ProductSuppliers GetProductSuppliers(int ProductSupplierId)
        {
            ProductSuppliers supplier = new ProductSuppliers(); // Supplier that will be retrieved.

            // Connection with DB to retrieve data
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT ProductSupplierId, ProductId, SupplierId " +
                               "FROM Products_Suppliers " +
                               "WHERE ProductSupplierId = @ProductSupplierId";

                // Command to retrieve data with query and db connection.
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ProductSupplierID", ProductSupplierId); // Set parameter's value.
                    connection.Open();

                    // Read data from db and assign to object's properties.
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if(reader.Read()) // If there is data
                        {
                            supplier.ProductSupplierID = (int)reader["ProductSupplierId"];
                            supplier.ProductID = (int)reader["ProductId"];
                            supplier.SupplierID = (int)reader["SupplierId"];
                        }
                    }
                }
            }

            return supplier;
        } // End GetProductSuppliers method

        /// <summary>
        /// Update Product Supplier in DB using two objects for comparison. This prevents concurrency errors
        /// when multiple users are updating the DB at the same time.
        /// </summary>
        /// <param name="oldProductSupplier">The old ProductSupplier object that was initially retrieved.</param>
        /// <param name="newProductSupplier">The new ProductSupplier object that is currently on the form.</param>
        /// <returns>Number of rows affected in variable 'count'. It will be either 1 row or 0 row. Can be use as true/false</returns>
        public static bool UpdateProductSupplier(ProductSuppliers oldProductSupplier, ProductSuppliers newProductSupplier)
        {
            int count; // How many rows updated

            // SQL Update statement to update only the shipped date
            string updateStatement =
                "UPDATE Products_Suppliers SET " +
                "ShippedDate = @newShippedDate " +
                "WHERE OrderID = @oldOrderID " + // to identify record
                " AND CustomerID = @oldCustomerID " + // remainig conditions - optimistic concurrency
                " AND OrderDate = @oldOrderDate " +
                " AND RequiredDate = @oldRequiredDate " +
                " AND (ShippedDate = @oldShippedDate OR (ShippedDate IS NULL AND  @oldShippedDate IS NULL))";


        }
    }
}
