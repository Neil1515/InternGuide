namespace InternGuide.Admin_Form
{
    partial class AdminHistorylogs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updatecompltelabel = new System.Windows.Forms.Label();
            this.datetimeinoutdataGridView = new System.Windows.Forms.DataGridView();
            this.internGuideDBDataSetMain = new InternGuide.InternGuideDBDataSetMain();
            this.historylogstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historylogstblTableAdapter = new InternGuide.InternGuideDBDataSetMainTableAdapters.historylogstblTableAdapter();
            this.datetimeinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datetimeinoutdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internGuideDBDataSetMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historylogstblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.updatecompltelabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 47);
            this.panel1.TabIndex = 2;
            // 
            // updatecompltelabel
            // 
            this.updatecompltelabel.BackColor = System.Drawing.Color.Transparent;
            this.updatecompltelabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.updatecompltelabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatecompltelabel.ForeColor = System.Drawing.Color.White;
            this.updatecompltelabel.Location = new System.Drawing.Point(0, 0);
            this.updatecompltelabel.Name = "updatecompltelabel";
            this.updatecompltelabel.Size = new System.Drawing.Size(378, 30);
            this.updatecompltelabel.TabIndex = 49;
            this.updatecompltelabel.Text = "ADMIN HISTORY LOGS";
            this.updatecompltelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datetimeinoutdataGridView
            // 
            this.datetimeinoutdataGridView.AllowUserToAddRows = false;
            this.datetimeinoutdataGridView.AllowUserToDeleteRows = false;
            this.datetimeinoutdataGridView.AutoGenerateColumns = false;
            this.datetimeinoutdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datetimeinoutdataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datetimeinoutdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.datetimeinoutdataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datetimeinoutdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datetimeinoutdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datetimeinoutdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datetimeinoutdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datetimeinDataGridViewTextBoxColumn,
            this.datetimeoutDataGridViewTextBoxColumn});
            this.datetimeinoutdataGridView.DataSource = this.historylogstblBindingSource;
            this.datetimeinoutdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datetimeinoutdataGridView.GridColor = System.Drawing.Color.White;
            this.datetimeinoutdataGridView.Location = new System.Drawing.Point(0, 47);
            this.datetimeinoutdataGridView.Name = "datetimeinoutdataGridView";
            this.datetimeinoutdataGridView.ReadOnly = true;
            this.datetimeinoutdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datetimeinoutdataGridView.Size = new System.Drawing.Size(378, 403);
            this.datetimeinoutdataGridView.TabIndex = 3;
            // 
            // internGuideDBDataSetMain
            // 
            this.internGuideDBDataSetMain.DataSetName = "InternGuideDBDataSetMain";
            this.internGuideDBDataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historylogstblBindingSource
            // 
            this.historylogstblBindingSource.DataMember = "historylogstbl";
            this.historylogstblBindingSource.DataSource = this.internGuideDBDataSetMain;
            // 
            // historylogstblTableAdapter
            // 
            this.historylogstblTableAdapter.ClearBeforeFill = true;
            // 
            // datetimeinDataGridViewTextBoxColumn
            // 
            this.datetimeinDataGridViewTextBoxColumn.DataPropertyName = "datetimein";
            this.datetimeinDataGridViewTextBoxColumn.HeaderText = "DATE TIME IN";
            this.datetimeinDataGridViewTextBoxColumn.Name = "datetimeinDataGridViewTextBoxColumn";
            this.datetimeinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimeoutDataGridViewTextBoxColumn
            // 
            this.datetimeoutDataGridViewTextBoxColumn.DataPropertyName = "datetimeout";
            this.datetimeoutDataGridViewTextBoxColumn.HeaderText = "DATE TIME OUT";
            this.datetimeoutDataGridViewTextBoxColumn.Name = "datetimeoutDataGridViewTextBoxColumn";
            this.datetimeoutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AdminHistorylogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.datetimeinoutdataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminHistorylogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHistorylogs";
            this.Load += new System.EventHandler(this.AdminHistorylogs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datetimeinoutdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internGuideDBDataSetMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historylogstblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label updatecompltelabel;
        private System.Windows.Forms.DataGridView datetimeinoutdataGridView;
        private InternGuideDBDataSetMain internGuideDBDataSetMain;
        private System.Windows.Forms.BindingSource historylogstblBindingSource;
        private InternGuideDBDataSetMainTableAdapters.historylogstblTableAdapter historylogstblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeoutDataGridViewTextBoxColumn;
    }
}