namespace InternGuide.Deans_Form
{
    partial class DepartmentPartnersComp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ImportStudentExcelfilesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.internGuideDBDataSetMain = new InternGuide.InternGuideDBDataSetMain();
            this.departmentpartnershipcompanytableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentpartnershipcompanytableTableAdapter = new InternGuide.InternGuideDBDataSetMainTableAdapters.departmentpartnershipcompanytableTableAdapter();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearstartedaspartnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internGuideDBDataSetMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentpartnershipcompanytableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.AllowDrop = true;
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 5;
            this.guna2CustomGradientPanel1.Controls.Add(this.ImportStudentExcelfilesbtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(931, 67);
            this.guna2CustomGradientPanel1.TabIndex = 45;
            // 
            // ImportStudentExcelfilesbtn
            // 
            this.ImportStudentExcelfilesbtn.BorderRadius = 10;
            this.ImportStudentExcelfilesbtn.BorderThickness = 1;
            this.ImportStudentExcelfilesbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ImportStudentExcelfilesbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ImportStudentExcelfilesbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ImportStudentExcelfilesbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ImportStudentExcelfilesbtn.FillColor = System.Drawing.Color.White;
            this.ImportStudentExcelfilesbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ImportStudentExcelfilesbtn.ForeColor = System.Drawing.Color.Black;
            this.ImportStudentExcelfilesbtn.Image = global::InternGuide.Properties.Resources.xls_file;
            this.ImportStudentExcelfilesbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.ImportStudentExcelfilesbtn.Location = new System.Drawing.Point(17, 15);
            this.ImportStudentExcelfilesbtn.Name = "ImportStudentExcelfilesbtn";
            this.ImportStudentExcelfilesbtn.Size = new System.Drawing.Size(141, 37);
            this.ImportStudentExcelfilesbtn.TabIndex = 40;
            this.ImportStudentExcelfilesbtn.Text = "Import Companies";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(925, 33);
            this.label1.TabIndex = 39;
            this.label1.Text = "Directory of Industry Partners";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewTextBoxColumn,
            this.companynameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactpersonDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.contactnumberDataGridViewTextBoxColumn,
            this.emailaddressDataGridViewTextBoxColumn,
            this.yearstartedaspartnerDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentpartnershipcompanytableBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(931, 424);
            this.dataGridView1.TabIndex = 46;
            // 
            // internGuideDBDataSetMain
            // 
            this.internGuideDBDataSetMain.DataSetName = "InternGuideDBDataSetMain";
            this.internGuideDBDataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentpartnershipcompanytableBindingSource
            // 
            this.departmentpartnershipcompanytableBindingSource.DataMember = "departmentpartnershipcompanytable";
            this.departmentpartnershipcompanytableBindingSource.DataSource = this.internGuideDBDataSetMain;
            // 
            // departmentpartnershipcompanytableTableAdapter
            // 
            this.departmentpartnershipcompanytableTableAdapter.ClearBeforeFill = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "companyname";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "COMPANY NAME";
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            this.companynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactpersonDataGridViewTextBoxColumn
            // 
            this.contactpersonDataGridViewTextBoxColumn.DataPropertyName = "contactperson";
            this.contactpersonDataGridViewTextBoxColumn.HeaderText = "CONTACT PERSON";
            this.contactpersonDataGridViewTextBoxColumn.Name = "contactpersonDataGridViewTextBoxColumn";
            this.contactpersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "DESIGNATION";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactnumberDataGridViewTextBoxColumn
            // 
            this.contactnumberDataGridViewTextBoxColumn.DataPropertyName = "contactnumber";
            this.contactnumberDataGridViewTextBoxColumn.HeaderText = "CONTACT NUMBER";
            this.contactnumberDataGridViewTextBoxColumn.Name = "contactnumberDataGridViewTextBoxColumn";
            this.contactnumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailaddressDataGridViewTextBoxColumn
            // 
            this.emailaddressDataGridViewTextBoxColumn.DataPropertyName = "emailaddress";
            this.emailaddressDataGridViewTextBoxColumn.HeaderText = "EMAIL ADDRESS";
            this.emailaddressDataGridViewTextBoxColumn.Name = "emailaddressDataGridViewTextBoxColumn";
            this.emailaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearstartedaspartnerDataGridViewTextBoxColumn
            // 
            this.yearstartedaspartnerDataGridViewTextBoxColumn.DataPropertyName = "yearstartedaspartner";
            this.yearstartedaspartnerDataGridViewTextBoxColumn.HeaderText = "YEARS STARTED AS PARTNER";
            this.yearstartedaspartnerDataGridViewTextBoxColumn.Name = "yearstartedaspartnerDataGridViewTextBoxColumn";
            this.yearstartedaspartnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "REMARK";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DepartmentPartnersComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "DepartmentPartnersComp";
            this.Size = new System.Drawing.Size(931, 491);
            this.Load += new System.EventHandler(this.DepartmentPartnersComp_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internGuideDBDataSetMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentpartnershipcompanytableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button ImportStudentExcelfilesbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource departmentpartnershipcompanytableBindingSource;
        private InternGuideDBDataSetMain internGuideDBDataSetMain;
        private InternGuideDBDataSetMainTableAdapters.departmentpartnershipcompanytableTableAdapter departmentpartnershipcompanytableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearstartedaspartnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}
