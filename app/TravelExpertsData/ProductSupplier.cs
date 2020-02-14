using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// Represents the Products_Suppliers table in the Travel Experts DB 
    /// </summary>
    /// @author Chi
    public class ProductSupplier
    {
        // auto-implemented properties
        public int ProductSupplierId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
    }
}
