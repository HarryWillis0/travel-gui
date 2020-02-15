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
    public partial class frmAddSupplier : Form
    {
        public frmAddSupplier()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // need to validate!
            if (supplierId.Text == "")
                MessageBox.Show("Supplier ID is required.", "Missing field.");
            else
            {
                Supplier supplier = new Supplier()
                {
                    SupplierId = Int32.Parse(supplierId.Text),
                    SupName = supplierName.Text
                };
                SuppliersDB.AddSupplier(supplier);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
