using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? PkgStartDate { get; set; } // nullable DateTime
        [DisplayFormat(DataFormatString = "{0:d}")]
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
