﻿namespace InternGuide.Admin_Form
{
    partial class DepartmentDeans
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmentdeanstableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internGuideDBDataSetMain = new InternGuide.InternGuideDBDataSetMain();
            this.departmentdeanstableTableAdapter = new InternGuide.InternGuideDBDataSetMainTableAdapters.departmentdeanstableTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deansfnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deanslnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.editimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.inactiveusersbtn = new Guna.UI2.WinForms.Guna2Button();
            this.refreshbtn = new Guna.UI2.WinForms.Guna2Button();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.addadmindetails = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentdeanstableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internGuideDBDataSetMain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addadmindetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 39;
            this.label1.Text = "DEANS DETAILS";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.AllowDrop = true;
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 5;
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.addadmindetails);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(931, 67);
            this.guna2CustomGradientPanel1.TabIndex = 41;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.deansfnameDataGridViewTextBoxColumn,
            this.deanslnameDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.image,
            this.editimage});
            this.dataGridView1.DataSource = this.departmentdeanstableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(931, 384);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // departmentdeanstableBindingSource
            // 
            this.departmentdeanstableBindingSource.DataMember = "departmentdeanstable";
            this.departmentdeanstableBindingSource.DataSource = this.internGuideDBDataSetMain;
            // 
            // internGuideDBDataSetMain
            // 
            this.internGuideDBDataSetMain.DataSetName = "InternGuideDBDataSetMain";
            this.internGuideDBDataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentdeanstableTableAdapter
            // 
            this.departmentdeanstableTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inactiveusersbtn);
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 40);
            this.panel1.TabIndex = 43;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deansfnameDataGridViewTextBoxColumn
            // 
            this.deansfnameDataGridViewTextBoxColumn.DataPropertyName = "deansfname";
            this.deansfnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.deansfnameDataGridViewTextBoxColumn.Name = "deansfnameDataGridViewTextBoxColumn";
            this.deansfnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deanslnameDataGridViewTextBoxColumn
            // 
            this.deanslnameDataGridViewTextBoxColumn.DataPropertyName = "deanslname";
            this.deanslnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.deanslnameDataGridViewTextBoxColumn.Name = "deanslnameDataGridViewTextBoxColumn";
            this.deanslnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.FillWeight = 50F;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::InternGuide.Properties.Resources.edit__1_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // editimage
            // 
            this.editimage.FillWeight = 30F;
            this.editimage.HeaderText = "";
            this.editimage.Image = global::InternGuide.Properties.Resources.edit__1_;
            this.editimage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editimage.Name = "editimage";
            this.editimage.ReadOnly = true;
            // 
            // inactiveusersbtn
            // 
            this.inactiveusersbtn.BorderRadius = 5;
            this.inactiveusersbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.inactiveusersbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.inactiveusersbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.inactiveusersbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.inactiveusersbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.inactiveusersbtn.FillColor = System.Drawing.Color.White;
            this.inactiveusersbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inactiveusersbtn.ForeColor = System.Drawing.Color.Black;
            this.inactiveusersbtn.Image = global::InternGuide.Properties.Resources.passive_candidate;
            this.inactiveusersbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.inactiveusersbtn.Location = new System.Drawing.Point(890, 0);
            this.inactiveusersbtn.Name = "inactiveusersbtn";
            this.inactiveusersbtn.Size = new System.Drawing.Size(41, 40);
            this.inactiveusersbtn.TabIndex = 57;
            this.inactiveusersbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inactiveusersbtn.Click += new System.EventHandler(this.inactiveusersbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BorderRadius = 5;
            this.refreshbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refreshbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refreshbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refreshbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refreshbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshbtn.FillColor = System.Drawing.Color.White;
            this.refreshbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshbtn.ForeColor = System.Drawing.Color.Black;
            this.refreshbtn.Image = global::InternGuide.Properties.Resources.refresh;
            this.refreshbtn.ImageSize = new System.Drawing.Size(35, 35);
            this.refreshbtn.Location = new System.Drawing.Point(273, 0);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(41, 40);
            this.refreshbtn.TabIndex = 56;
            this.refreshbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.Transparent;
            this.txtsearch.BorderColor = System.Drawing.Color.LightGray;
            this.txtsearch.BorderRadius = 5;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.IconLeft = global::InternGuide.Properties.Resources.people;
            this.txtsearch.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.txtsearch.Location = new System.Drawing.Point(0, 0);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderText = "Search...";
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(273, 40);
            this.txtsearch.TabIndex = 11;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // addadmindetails
            // 
            this.addadmindetails.BackColor = System.Drawing.Color.Transparent;
            this.addadmindetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addadmindetails.Image = global::InternGuide.Properties.Resources.adduser;
            this.addadmindetails.Location = new System.Drawing.Point(12, 13);
            this.addadmindetails.Name = "addadmindetails";
            this.addadmindetails.Size = new System.Drawing.Size(43, 43);
            this.addadmindetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addadmindetails.TabIndex = 38;
            this.addadmindetails.TabStop = false;
            this.addadmindetails.Click += new System.EventHandler(this.addadmindetails_Click);
            // 
            // DepartmentDeans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "DepartmentDeans";
            this.Size = new System.Drawing.Size(931, 491);
            this.Load += new System.EventHandler(this.DepartmentAdmin_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentdeanstableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internGuideDBDataSetMain)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addadmindetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox addadmindetails;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource departmentdeanstableBindingSource;
        private InternGuideDBDataSetMain internGuideDBDataSetMain;
        private InternGuideDBDataSetMainTableAdapters.departmentdeanstableTableAdapter departmentdeanstableTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deansfnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deanslnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewImageColumn editimage;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button refreshbtn;
        private Guna.UI2.WinForms.Guna2Button inactiveusersbtn;
    }
}
