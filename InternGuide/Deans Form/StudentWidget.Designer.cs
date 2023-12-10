namespace InternGuide.Deans_Form
{
    partial class StudentWidget
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
            this.studidlabel = new System.Windows.Forms.Label();
            this.studnamelabel = new System.Windows.Forms.Label();
            this.studyrcourselabel = new System.Windows.Forms.Label();
            this.studemaillabel = new System.Windows.Forms.Label();
            this.studentwidgetPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentwidgetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // studidlabel
            // 
            this.studidlabel.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studidlabel.ForeColor = System.Drawing.Color.Black;
            this.studidlabel.Location = new System.Drawing.Point(93, 3);
            this.studidlabel.Name = "studidlabel";
            this.studidlabel.Size = new System.Drawing.Size(159, 18);
            this.studidlabel.TabIndex = 8;
            this.studidlabel.Text = "ID";
            this.studidlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studnamelabel
            // 
            this.studnamelabel.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studnamelabel.ForeColor = System.Drawing.Color.Black;
            this.studnamelabel.Location = new System.Drawing.Point(93, 21);
            this.studnamelabel.Name = "studnamelabel";
            this.studnamelabel.Size = new System.Drawing.Size(160, 18);
            this.studnamelabel.TabIndex = 9;
            this.studnamelabel.Text = "name";
            this.studnamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studyrcourselabel
            // 
            this.studyrcourselabel.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyrcourselabel.ForeColor = System.Drawing.Color.Black;
            this.studyrcourselabel.Location = new System.Drawing.Point(93, 39);
            this.studyrcourselabel.Name = "studyrcourselabel";
            this.studyrcourselabel.Size = new System.Drawing.Size(160, 18);
            this.studyrcourselabel.TabIndex = 10;
            this.studyrcourselabel.Text = "yr/course";
            this.studyrcourselabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studemaillabel
            // 
            this.studemaillabel.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studemaillabel.ForeColor = System.Drawing.Color.Black;
            this.studemaillabel.Location = new System.Drawing.Point(93, 60);
            this.studemaillabel.Name = "studemaillabel";
            this.studemaillabel.Size = new System.Drawing.Size(160, 18);
            this.studemaillabel.TabIndex = 11;
            this.studemaillabel.Text = "email";
            this.studemaillabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentwidgetPictureBox
            // 
            this.studentwidgetPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.studentwidgetPictureBox.Location = new System.Drawing.Point(0, -1);
            this.studentwidgetPictureBox.Name = "studentwidgetPictureBox";
            this.studentwidgetPictureBox.Size = new System.Drawing.Size(92, 85);
            this.studentwidgetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentwidgetPictureBox.TabIndex = 13;
            this.studentwidgetPictureBox.TabStop = false;
            // 
            // StudentWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.studentwidgetPictureBox);
            this.Controls.Add(this.studemaillabel);
            this.Controls.Add(this.studyrcourselabel);
            this.Controls.Add(this.studnamelabel);
            this.Controls.Add(this.studidlabel);
            this.Name = "StudentWidget";
            this.Size = new System.Drawing.Size(256, 84);
            this.Load += new System.EventHandler(this.StudentWidget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentwidgetPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label studidlabel;
        private System.Windows.Forms.Label studnamelabel;
        private System.Windows.Forms.Label studyrcourselabel;
        private System.Windows.Forms.Label studemaillabel;
        private System.Windows.Forms.PictureBox studentwidgetPictureBox;
    }
}
