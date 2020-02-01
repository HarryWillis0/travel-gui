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

            pkgBasePriceTextBox.Text = oldPkg.PkgBasePrice.ToString();

            if (oldPkg.PkgAgencyCommission == null)
                pkgAgencyCommissionTextBox.Text = "";
            else
            {
                decimal temp = Convert.ToDecimal(oldPkg.PkgAgencyCommission);
                pkgAgencyCommissionTextBox.Text = temp.ToString();
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
            MessageBox.Show("OLD PACKAGE:\n\t" + oldPkg.PkgName + "\n\t" + oldPkg.PkgDesc + "\n\t" + oldPkg.PkgStartDate + "\n\t" + oldPkg.PkgEndDate + "\n"
                + "NEWPKG\n\t" + newPkg.PkgName + "\n\t" + newPkg.PkgDesc + "\n\t" + newPkg.PkgStartDate + "\n\t" + newPkg.PkgEndDate);

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
                    bool success = PackageDB.UpdatePackage(oldPkg, newPkg);
                    if (success)
                        this.DialogResult = DialogResult.OK;
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
