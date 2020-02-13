using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// object to represent packages product supplier table of TravelExperts DB
    /// </summary>
    /// @author Harry
    public class PackageProductSupplier
    {
        // auto- implemented properties
        public int PackageId { get; set; }
        public int ProductSupplierId { get; set; }
    }
}
