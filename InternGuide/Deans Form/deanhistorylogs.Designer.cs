﻿namespace InternGuide.Deans_Form
{
    partial class Deanhistorylogs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datetimeinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historylogstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internGuideDBDataSetMain = new InternGuide.InternGuideDBDataSetMain();
            this.historylogstblTableAdapter = new InternGuide.InternGuideDBDataSetMainTableAdapters.historylogstblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historylogstblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internGuideDBDataSetMain)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datetimeinDataGridViewTextBoxColumn,
            this.datetimeoutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historylogstblBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(158, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(614, 459);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // datetimeinDataGridViewTextBoxColumn
            // 
            this.datetimeinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datetimeinDataGridViewTextBoxColumn.DataPropertyName = "datetimein";
            this.datetimeinDataGridViewTextBoxColumn.HeaderText = "DATE TIME IN";
            this.datetimeinDataGridViewTextBoxColumn.Name = "datetimeinDataGridViewTextBoxColumn";
            this.datetimeinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimeoutDataGridViewTextBoxColumn
            // 
            this.datetimeoutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datetimeoutDataGridViewTextBoxColumn.DataPropertyName = "datetimeout";
            this.datetimeoutDataGridViewTextBoxColumn.HeaderText = "DATE TIME OUT";
            this.datetimeoutDataGridViewTextBoxColumn.Name = "datetimeoutDataGridViewTextBoxColumn";
            this.datetimeoutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historylogstblBindingSource
            // 
            this.historylogstblBindingSource.DataMember = "historylogstbl";
            this.historylogstblBindingSource.DataSource = this.internGuideDBDataSetMain;
            // 
            // internGuideDBDataSetMain
            // 
            this.internGuideDBDataSetMain.DataSetName = "InternGuideDBDataSetMain";
            this.internGuideDBDataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historylogstblTableAdapter
            // 
            this.historylogstblTableAdapter.ClearBeforeFill = true;
            // 
            // deanhistorylogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "deanhistorylogs";
            this.Size = new System.Drawing.Size(931, 491);
            this.Load += new System.EventHandler(this.deanhistorylogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historylogstblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internGuideDBDataSetMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historylogstblBindingSource;
        private InternGuideDBDataSetMain internGuideDBDataSetMain;
        private InternGuideDBDataSetMainTableAdapters.historylogstblTableAdapter historylogstblTableAdapter;
    }
}
