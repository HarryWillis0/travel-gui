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
    public partial class frmMain : Form
    {
        // packages info
        List<Package> packages; // list of packages
        int pkgPos; // current position in packages

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {

                packages = PackageDB.GetPackages();
                pkgPos = 0;
                ShowPackages();

                // TODO SHOW OTHER DATA IN TABS
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading data.\n" + ex.Message,
                    ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Fill packages data view with packages
        /// </summary>
        /// @author Harry
        private void ShowPackages()
        {
            packageBindingSource.Clear();
            packageBindingSource.Add(packages[pkgPos]);

            // some formatting
            pkgBasePriceTextBox.Text = FormatPrices(pkgBasePriceTextBox.Text);
            pkgAgencyCommissionTextBox.Text = FormatPrices(pkgAgencyCommissionTextBox.Text);
        }

        private string FormatPrices(string price)
        {
            decimal temp = Convert.ToDecimal(price);
            
            return temp.ToString("c2") ;
        }

        /// <summary>
        /// Fill packages detail view with the first package (by package id).
        /// </summary>
        /// @author Harry
        private void btnSkipToFirst_Click(object sender, EventArgs e)
        {
            pkgPos = 0;
            ShowPackages();
        }

        /// <summary>
        /// Fill package detail view with the previous package
        ///     or wrap to last if current package is the first.
        /// </summary>
        /// @author Harry
        private void btnPrev_Click(object sender, EventArgs e)
        {
            // wrap around if current package is the last.
            if (pkgPos == 0)
                pkgPos = packages.Count - 1;
            else
                pkgPos--;

            ShowPackages();
        }

        /// <summary>
        /// Fill packages detail view with next package (by package id)
        ///     wrap to first package if current package is the last.
        /// </summary>
        /// @author Harry
        private void btnNext_Click(object sender, EventArgs e)
        {
            // wrap around if current package is the first.
            if (pkgPos == packages.Count - 1)
                pkgPos = 0;
            else
                pkgPos++;

            ShowPackages();
        }

        /// <summary>
        /// Fill packages detail view with the last package (by package id).
        /// </summary>
        /// @author Harry
        private void btnSkpToEnd_Click(object sender, EventArgs e)
        {
            pkgPos = packages.Count - 1;
            ShowPackages();
        }

        /// <summary>
        /// Exit app
        /// </summary>
        /// @author Harry
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
