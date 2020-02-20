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
    // Form to edit supplier - Raymond
    public partial class frmEditSuppliers : Form
    {
        public frmEditSuppliers(Supplier suppliers)
        {
            InitializeComponent();
            supplierId.Text = suppliers.SupplierId.ToString();
            supplierName.Text = suppliers.SupName;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        // Update supplier 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // valid supplier id
            if (!Validator.IsValidSupplierId(supplierId.Text, out string result))
            {
                MessageBox.Show(result, "Supplier Error");
                return;
            }
            // supplier name required as per Jolanta
            if (string.IsNullOrEmpty(supplierName.Text))
            {
                MessageBox.Show("Supplier Name is required.", "Supplier Error");
                return;
            }

            Supplier supplier = new Supplier()
            {
                SupplierId = Convert.ToInt32(supplierId.Text),
                SupName = supplierName.Text
            };
            SuppliersDB.EditSupplier(supplier);
            this.DialogResult = DialogResult.OK;
        }
    }
}
