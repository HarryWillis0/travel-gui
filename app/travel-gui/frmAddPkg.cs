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
    public partial class frmAddPkg : Form
    {
        public frmAddPkg()
        {
            InitializeComponent();
        }

        private void frmEditPkg_Load(object sender, EventArgs e)
        {
            pkgNameTextBox.Focus();
        }

        /// <summary>
        /// Cancel adding new package
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Adding new package accepted
        /// </summary>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Package newPkg = new Package();
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
                    bool success = PackageDB.AddPackage(newPkg);
                    if (success)
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Cancel;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding package.\n" + ex.Message,
                        ex.GetType().ToString());
                }
            }
        }
    }
}
