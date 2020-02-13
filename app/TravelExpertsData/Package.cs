using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// object to represent packages table of TravelExperts DB
    /// </summary>
    /// @author Harry
    public class Package
    {
        // auto-implemented properties
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; } // nullable DateTime
        public DateTime? PkgEndDate { get; set; } // nullable DateTime
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommission { get; set; }

        /// <summary>
        /// Create a copy of itself
        /// </summary>
        /// <returns>Copy of itself</returns>
        public Package Clone()
        {
            Package clone = new Package();
            clone.PackageId = this.PackageId;
            clone.PkgName = this.PkgName;
            clone.PkgStartDate = this.PkgStartDate;
            clone.PkgEndDate = this.PkgEndDate;
            clone.PkgDesc = this.PkgDesc;
            clone.PkgBasePrice = this.PkgBasePrice;
            clone.PkgAgencyCommission = this.PkgAgencyCommission;
            return clone;
        }
    }
}
