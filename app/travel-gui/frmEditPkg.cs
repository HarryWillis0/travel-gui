using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace travel_gui
{
    /// <summary>
    /// A form to update a package
    /// </summary>
    /// @author Harry
    public partial class frmEditPkg : Form
    {
        // store old and new package
        public Package oldPkg;
        public Package newPkg;

        public frmEditPkg()
        {
            InitializeComponent();
        }

        private void frmEditPkg_Load(object sender, EventArgs e)
        {
            pkgNameTextBox.Focus();
            ShowPackage();
        }

        /// <summary>
        /// Fill packages data view with packages
        /// </summary>
        private void ShowPackage()
        {
            packageIdTextBox.Text = oldPkg.PackageId.ToString();
            pkgNameTextBox.Text = oldPkg.PkgName;
            pkgDescTextBox.Text = oldPkg.PkgDesc;

            // format to get rid of time stamp - first got to check if null
            if (oldPkg.PkgStartDate == null)
                pkgStartDateTextBox.Text = "";
            else
            {
                DateTime temp = Convert.ToDateTime(oldPkg.PkgStartDate);
                pkgStartDateTextBox.Text = temp.ToShortDateString();
            }

            if (oldPkg.PkgEndDate == null)
                pkgEndDateTextBox.Text = "";
            else
            {
                DateTime temp = Convert.ToDateTime(oldPkg.PkgEndDate);
                pkgEndDateTextBox.Text = temp.ToShortDateString();
            }

            decimal tempMon = Convert.ToDecimal(oldPkg.PkgBasePrice);
            pkgBasePriceTextBox.Text = tempMon.ToString("F");

            if (oldPkg.PkgAgencyCommission == null)
                pkgAgencyCommissionTextBox.Text = "";
            else
            {
                tempMon = Convert.ToDecimal(oldPkg.PkgAgencyCommission);
                pkgAgencyCommissionTextBox.Text = tempMon.ToString("F");
            }
        }

        /// <summary>
        /// Cancel edit of package
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Update accepted 
        /// </summary>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // VALIDATE
            if (Processor.ProcessName(newPkg, pkgNameTextBox) &&
                Processor.ProcessStartDate(newPkg, pkgStartDateTextBox) &&
                Processor.ProcessEndDate(newPkg, pkgEndDateTextBox) &&
                Processor.ProcessDesc(newPkg, pkgDescTextBox) &&
                Processor.ProcessPkgPrice(newPkg, pkgBasePriceTextBox) &&
                Processor.ProcessPkgAgencyCommission(newPkg, pkgAgencyCommissionTextBox))
            { // input good
               try
                {
                    int success = PackageDB.UpdatePackage(oldPkg, newPkg);

                    if (success == 1)
                        this.DialogResult = DialogResult.OK;
                    else if (success == 0) // there was a concurrency issue
                    {
                        this.DialogResult = DialogResult.Abort;
                    }
                    else
                        this.DialogResult = DialogResult.Cancel;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while editing package.\n" + ex.Message,
                        ex.GetType().ToString());
                }
            }
        }
    }
}
