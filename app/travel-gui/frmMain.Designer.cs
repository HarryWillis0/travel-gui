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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgEndDateLabel1;
            System.Windows.Forms.Label pkgStartDateLabel1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPkgs = new System.Windows.Forms.TabPage();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.btnEditPkg = new System.Windows.Forms.Button();
            this.pkgStartDateTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateTextBox = new System.Windows.Forms.TextBox();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSkipToFirst = new System.Windows.Forms.Button();
            this.btnSkpToEnd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.packageIdTextBox = new System.Windows.Forms.TextBox();
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.tbProds = new System.Windows.Forms.TabPage();
            this.tbSuppliers = new System.Windows.Forms.TabPage();
            this.tbProdSupp = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel1 = new System.Windows.Forms.Label();
            pkgStartDateLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbPkgs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(18, 33);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(19, 13);
            packageIdLabel.TabIndex = 0;
            packageIdLabel.Text = "Id:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(18, 189);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(104, 13);
            pkgAgencyCommissionLabel.TabIndex = 2;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(18, 163);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(34, 13);
            pkgBasePriceLabel.TabIndex = 4;
            pkgBasePriceLabel.Text = "Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(18, 137);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(63, 13);
            pkgDescLabel.TabIndex = 6;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(18, 59);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(38, 13);
            pkgNameLabel.TabIndex = 10;
            pkgNameLabel.Text = "Name:";
            // 
            // pkgEndDateLabel1
            // 
            pkgEndDateLabel1.AutoSize = true;
            pkgEndDateLabel1.Location = new System.Drawing.Point(18, 108);
            pkgEndDateLabel1.Name = "pkgEndDateLabel1";
            pkgEndDateLabel1.Size = new System.Drawing.Size(55, 13);
            pkgEndDateLabel1.TabIndex = 17;
            pkgEndDateLabel1.Text = "End Date:";
            // 
            // pkgStartDateLabel1
            // 
            pkgStartDateLabel1.AutoSize = true;
            pkgStartDateLabel1.Location = new System.Drawing.Point(18, 82);
            pkgStartDateLabel1.Name = "pkgStartDateLabel1";
            pkgStartDateLabel1.Size = new System.Drawing.Size(58, 13);
            pkgStartDateLabel1.TabIndex = 18;
            pkgStartDateLabel1.Text = "Start Date:";
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
            this.tbPkgs.Controls.Add(this.btnAddPkg);
            this.tbPkgs.Controls.Add(this.btnEditPkg);
            this.tbPkgs.Controls.Add(pkgStartDateLabel1);
            this.tbPkgs.Controls.Add(this.pkgStartDateTextBox);
            this.tbPkgs.Controls.Add(pkgEndDateLabel1);
            this.tbPkgs.Controls.Add(this.pkgEndDateTextBox);
            this.tbPkgs.Controls.Add(this.btnSkipToFirst);
            this.tbPkgs.Controls.Add(this.btnSkpToEnd);
            this.tbPkgs.Controls.Add(this.btnNext);
            this.tbPkgs.Controls.Add(this.btnPrev);
            this.tbPkgs.Controls.Add(packageIdLabel);
            this.tbPkgs.Controls.Add(this.packageIdTextBox);
            this.tbPkgs.Controls.Add(pkgAgencyCommissionLabel);
            this.tbPkgs.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.tbPkgs.Controls.Add(pkgBasePriceLabel);
            this.tbPkgs.Controls.Add(this.pkgBasePriceTextBox);
            this.tbPkgs.Controls.Add(pkgDescLabel);
            this.tbPkgs.Controls.Add(this.pkgDescTextBox);
            this.tbPkgs.Controls.Add(pkgNameLabel);
            this.tbPkgs.Controls.Add(this.pkgNameTextBox);
            this.tbPkgs.Location = new System.Drawing.Point(4, 22);
            this.tbPkgs.Name = "tbPkgs";
            this.tbPkgs.Padding = new System.Windows.Forms.Padding(3);
            this.tbPkgs.Size = new System.Drawing.Size(716, 329);
            this.tbPkgs.TabIndex = 0;
            this.tbPkgs.Text = "Packages";
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.Location = new System.Drawing.Point(250, 241);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(75, 23);
            this.btnAddPkg.TabIndex = 21;
            this.btnAddPkg.Text = "Add";
            this.btnAddPkg.UseVisualStyleBackColor = true;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // btnEditPkg
            // 
            this.btnEditPkg.Location = new System.Drawing.Point(169, 241);
            this.btnEditPkg.Name = "btnEditPkg";
            this.btnEditPkg.Size = new System.Drawing.Size(75, 23);
            this.btnEditPkg.TabIndex = 20;
            this.btnEditPkg.Text = "Edit";
            this.btnEditPkg.UseVisualStyleBackColor = true;
            this.btnEditPkg.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pkgStartDateTextBox
            // 
            this.pkgStartDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateTextBox.Location = new System.Drawing.Point(150, 82);
            this.pkgStartDateTextBox.Name = "pkgStartDateTextBox";
            this.pkgStartDateTextBox.ReadOnly = true;
            this.pkgStartDateTextBox.Size = new System.Drawing.Size(256, 20);
            this.pkgStartDateTextBox.TabIndex = 19;
            // 
            // pkgEndDateTextBox
            // 
            this.pkgEndDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateTextBox.Location = new System.Drawing.Point(150, 108);
            this.pkgEndDateTextBox.Name = "pkgEndDateTextBox";
            this.pkgEndDateTextBox.ReadOnly = true;
            this.pkgEndDateTextBox.Size = new System.Drawing.Size(256, 20);
            this.pkgEndDateTextBox.TabIndex = 18;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(TravelExpertsData.Package);
            // 
            // btnSkipToFirst
            // 
            this.btnSkipToFirst.Location = new System.Drawing.Point(150, 212);
            this.btnSkipToFirst.Name = "btnSkipToFirst";
            this.btnSkipToFirst.Size = new System.Drawing.Size(31, 23);
            this.btnSkipToFirst.TabIndex = 17;
            this.btnSkipToFirst.Text = "|<";
            this.btnSkipToFirst.UseVisualStyleBackColor = true;
            this.btnSkipToFirst.Click += new System.EventHandler(this.btnSkipToFirst_Click);
            // 
            // btnSkpToEnd
            // 
            this.btnSkpToEnd.Location = new System.Drawing.Point(313, 212);
            this.btnSkpToEnd.Name = "btnSkpToEnd";
            this.btnSkpToEnd.Size = new System.Drawing.Size(31, 23);
            this.btnSkpToEnd.TabIndex = 16;
            this.btnSkpToEnd.Text = ">|";
            this.btnSkpToEnd.UseVisualStyleBackColor = true;
            this.btnSkpToEnd.Click += new System.EventHandler(this.btnSkpToEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(250, 212);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(187, 212);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(57, 23);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // packageIdTextBox
            // 
            this.packageIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.packageIdTextBox.Location = new System.Drawing.Point(150, 30);
            this.packageIdTextBox.Name = "packageIdTextBox";
            this.packageIdTextBox.ReadOnly = true;
            this.packageIdTextBox.Size = new System.Drawing.Size(31, 20);
            this.packageIdTextBox.TabIndex = 1;
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(150, 186);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.ReadOnly = true;
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(82, 20);
            this.pkgAgencyCommissionTextBox.TabIndex = 3;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(150, 160);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.ReadOnly = true;
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(82, 20);
            this.pkgBasePriceTextBox.TabIndex = 5;
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Location = new System.Drawing.Point(150, 134);
            this.pkgDescTextBox.Multiline = true;
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.ReadOnly = true;
            this.pkgDescTextBox.Size = new System.Drawing.Size(256, 20);
            this.pkgDescTextBox.TabIndex = 7;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameTextBox.Location = new System.Drawing.Point(150, 56);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.ReadOnly = true;
            this.pkgNameTextBox.Size = new System.Drawing.Size(256, 20);
            this.pkgNameTextBox.TabIndex = 11;
            // 
            // tbProds
            // 
            this.tbProds.Location = new System.Drawing.Point(4, 22);
            this.tbProds.Name = "tbProds";
            this.tbProds.Padding = new System.Windows.Forms.Padding(3);
            this.tbProds.Size = new System.Drawing.Size(716, 329);
            this.tbProds.TabIndex = 1;
            this.tbProds.Text = "Products";
            this.tbProds.UseVisualStyleBackColor = true;
            // 
            // tbSuppliers
            // 
            this.tbSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tbSuppliers.Name = "tbSuppliers";
            this.tbSuppliers.Size = new System.Drawing.Size(716, 329);
            this.tbSuppliers.TabIndex = 3;
            this.tbSuppliers.Text = "Suppliers";
            this.tbSuppliers.UseVisualStyleBackColor = true;
            // 
            // tbProdSupp
            // 
            this.tbProdSupp.Location = new System.Drawing.Point(4, 22);
            this.tbProdSupp.Name = "tbProdSupp";
            this.tbProdSupp.Padding = new System.Windows.Forms.Padding(3);
            this.tbProdSupp.Size = new System.Drawing.Size(716, 329);
            this.tbProdSupp.TabIndex = 2;
            this.tbProdSupp.Text = "Product Suppliers";
            this.tbProdSupp.UseVisualStyleBackColor = true;
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
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(738, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbPkgs.ResumeLayout(false);
            this.tbPkgs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox packageIdTextBox;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.Button btnSkipToFirst;
        private System.Windows.Forms.Button btnSkpToEnd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.TextBox pkgEndDateTextBox;
        private System.Windows.Forms.TextBox pkgStartDateTextBox;
        private System.Windows.Forms.Button btnEditPkg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddPkg;
    }
}

