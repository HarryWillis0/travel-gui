namespace travel_gui
{
    partial class frmAddSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label supNameLabel;
            this.supplierName = new System.Windows.Forms.TextBox();
            this.supplierId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            supplierIdLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // supplierName
            // 
            this.supplierName.Location = new System.Drawing.Point(101, 80);
            this.supplierName.Margin = new System.Windows.Forms.Padding(2);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(224, 20);
            this.supplierName.TabIndex = 23;
            // 
            // supplierId
            // 
            this.supplierId.Location = new System.Drawing.Point(101, 57);
            this.supplierId.Margin = new System.Windows.Forms.Padding(2);
            this.supplierId.Name = "supplierId";
            this.supplierId.Size = new System.Drawing.Size(92, 20);
            this.supplierId.TabIndex = 22;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(189, 127);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 25);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Add";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(101, 127);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(74, 25);
            this.Cancelbtn.TabIndex = 20;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(38, 60);
            supplierIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(60, 13);
            supplierIdLabel.TabIndex = 18;
            supplierIdLabel.Text = "Supplier Id:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.Location = new System.Drawing.Point(38, 82);
            supNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(60, 13);
            supNameLabel.TabIndex = 19;
            supNameLabel.Text = "Sup Name:";
            // 
            // frmAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 213);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.supplierId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(supNameLabel);
            this.Name = "frmAddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox supplierName;
        private System.Windows.Forms.TextBox supplierId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button Cancelbtn;
    }
}