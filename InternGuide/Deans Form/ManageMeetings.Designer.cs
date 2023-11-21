namespace InternGuide.Deans_Form
{
    partial class ManageMeetings
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
            this.label1 = new System.Windows.Forms.Label();
            this.addadmindetails = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.internGuideDBDataSetMain = new InternGuide.InternGuideDBDataSetMain();
            this.meetingscheduletableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingscheduletableTableAdapter = new InternGuide.InternGuideDBDataSetMainTableAdapters.meetingscheduletableTableAdapter();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationvenueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addadmindetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internGuideDBDataSetMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingscheduletableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.AllowDrop = true;
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 5;
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.addadmindetails);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(931, 67);
            this.guna2CustomGradientPanel1.TabIndex = 42;
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
            this.label1.Size = new System.Drawing.Size(244, 33);
            this.label1.TabIndex = 39;
            this.label1.Text = "Meeting Schedule";
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datetimeDataGridViewTextBoxColumn,
            this.meetingtitleDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.agendaDataGridViewTextBoxColumn,
            this.organizationDataGridViewTextBoxColumn,
            this.locationvenueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.meetingscheduletableBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(931, 418);
            this.dataGridView1.TabIndex = 43;
            // 
            // internGuideDBDataSetMain
            // 
            this.internGuideDBDataSetMain.DataSetName = "InternGuideDBDataSetMain";
            this.internGuideDBDataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meetingscheduletableBindingSource
            // 
            this.meetingscheduletableBindingSource.DataMember = "meetingscheduletable";
            this.meetingscheduletableBindingSource.DataSource = this.internGuideDBDataSetMain;
            // 
            // meetingscheduletableTableAdapter
            // 
            this.meetingscheduletableTableAdapter.ClearBeforeFill = true;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "datetime";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "WHEN";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meetingtitleDataGridViewTextBoxColumn
            // 
            this.meetingtitleDataGridViewTextBoxColumn.DataPropertyName = "meetingtitle";
            this.meetingtitleDataGridViewTextBoxColumn.HeaderText = "MEETING TITLE";
            this.meetingtitleDataGridViewTextBoxColumn.Name = "meetingtitleDataGridViewTextBoxColumn";
            this.meetingtitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "DURATION";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agendaDataGridViewTextBoxColumn
            // 
            this.agendaDataGridViewTextBoxColumn.DataPropertyName = "agenda";
            this.agendaDataGridViewTextBoxColumn.HeaderText = "AGENDA";
            this.agendaDataGridViewTextBoxColumn.Name = "agendaDataGridViewTextBoxColumn";
            this.agendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // organizationDataGridViewTextBoxColumn
            // 
            this.organizationDataGridViewTextBoxColumn.DataPropertyName = "organization";
            this.organizationDataGridViewTextBoxColumn.HeaderText = "ORGANIZATION";
            this.organizationDataGridViewTextBoxColumn.Name = "organizationDataGridViewTextBoxColumn";
            this.organizationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationvenueDataGridViewTextBoxColumn
            // 
            this.locationvenueDataGridViewTextBoxColumn.DataPropertyName = "locationvenue";
            this.locationvenueDataGridViewTextBoxColumn.HeaderText = "WHERE";
            this.locationvenueDataGridViewTextBoxColumn.Name = "locationvenueDataGridViewTextBoxColumn";
            this.locationvenueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManageMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "ManageMeetings";
            this.Size = new System.Drawing.Size(931, 491);
            this.Load += new System.EventHandler(this.ManageMeetings_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addadmindetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internGuideDBDataSetMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingscheduletableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox addadmindetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationvenueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource meetingscheduletableBindingSource;
        private InternGuideDBDataSetMain internGuideDBDataSetMain;
        private InternGuideDBDataSetMainTableAdapters.meetingscheduletableTableAdapter meetingscheduletableTableAdapter;
    }
}
