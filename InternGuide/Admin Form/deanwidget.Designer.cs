namespace InternGuide.Admin_Form
{
    partial class deanwidget
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
            this.departmentlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deptadminpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptadminpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentlabel
            // 
            this.departmentlabel.AutoSize = true;
            this.departmentlabel.Font = new System.Drawing.Font("Leelawadee", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentlabel.ForeColor = System.Drawing.Color.Black;
            this.departmentlabel.Location = new System.Drawing.Point(7, 106);
            this.departmentlabel.Name = "departmentlabel";
            this.departmentlabel.Size = new System.Drawing.Size(58, 11);
            this.departmentlabel.TabIndex = 4;
            this.departmentlabel.Text = "Department";
            // 
            // namelabel
            // 
            this.namelabel.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.Color.Black;
            this.namelabel.Location = new System.Drawing.Point(6, 2);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(147, 18);
            this.namelabel.TabIndex = 5;
            this.namelabel.Text = "Name";
            this.namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Leelawadee", 6.75F, System.Drawing.FontStyle.Bold);
            this.idlabel.ForeColor = System.Drawing.Color.Black;
            this.idlabel.Location = new System.Drawing.Point(7, 117);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(14, 11);
            this.idlabel.TabIndex = 6;
            this.idlabel.Text = "Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InternGuide.Properties.Resources.edit;
            this.pictureBox1.Location = new System.Drawing.Point(136, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // deptadminpictureBox
            // 
            this.deptadminpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.deptadminpictureBox.Location = new System.Drawing.Point(6, 20);
            this.deptadminpictureBox.Name = "deptadminpictureBox";
            this.deptadminpictureBox.Size = new System.Drawing.Size(150, 85);
            this.deptadminpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deptadminpictureBox.TabIndex = 0;
            this.deptadminpictureBox.TabStop = false;
            // 
            // deanwidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.departmentlabel);
            this.Controls.Add(this.deptadminpictureBox);
            this.Name = "deanwidget";
            this.Size = new System.Drawing.Size(164, 132);
            this.Load += new System.EventHandler(this.adminwidget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptadminpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox deptadminpictureBox;
        private System.Windows.Forms.Label departmentlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
