namespace travel_gui
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPkgs = new System.Windows.Forms.TabPage();
            this.tbProds = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbProdSupp = new System.Windows.Forms.TabPage();
            this.tbSuppliers = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPkgs);
            this.tabControl1.Controls.Add(this.tbProds);
            this.tabControl1.Controls.Add(this.tbSuppliers);
            this.tabControl1.Controls.Add(this.tbProdSupp);
            this.tabControl1.Location = new System.Drawing.Point(12, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 355);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPkgs
            // 
            this.tbPkgs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPkgs.Location = new System.Drawing.Point(4, 22);
            this.tbPkgs.Name = "tbPkgs";
            this.tbPkgs.Padding = new System.Windows.Forms.Padding(3);
            this.tbPkgs.Size = new System.Drawing.Size(716, 329);
            this.tbPkgs.TabIndex = 0;
            this.tbPkgs.Text = "Packages";
            // 
            // tbProds
            // 
            this.tbProds.Location = new System.Drawing.Point(4, 22);
            this.tbProds.Name = "tbProds";
            this.tbProds.Padding = new System.Windows.Forms.Padding(3);
            this.tbProds.Size = new System.Drawing.Size(192, 74);
            this.tbProds.TabIndex = 1;
            this.tbProds.Text = "Products";
            this.tbProds.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(256, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Travel Experts";
            // 
            // tbProdSupp
            // 
            this.tbProdSupp.Location = new System.Drawing.Point(4, 22);
            this.tbProdSupp.Name = "tbProdSupp";
            this.tbProdSupp.Padding = new System.Windows.Forms.Padding(3);
            this.tbProdSupp.Size = new System.Drawing.Size(192, 74);
            this.tbProdSupp.TabIndex = 2;
            this.tbProdSupp.Text = "Product Suppliers";
            this.tbProdSupp.UseVisualStyleBackColor = true;
            // 
            // tbSuppliers
            // 
            this.tbSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tbSuppliers.Name = "tbSuppliers";
            this.tbSuppliers.Size = new System.Drawing.Size(192, 74);
            this.tbSuppliers.TabIndex = 3;
            this.tbSuppliers.Text = "Suppliers";
            this.tbSuppliers.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPkgs;
        private System.Windows.Forms.TabPage tbProds;
        private System.Windows.Forms.TabPage tbSuppliers;
        private System.Windows.Forms.TabPage tbProdSupp;
        private System.Windows.Forms.Label lblTitle;
    }
}

