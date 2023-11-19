namespace InternGuide.Student_Form
{
    partial class StudentHomepage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.departmentemaillabel = new System.Windows.Forms.Label();
            this.deansnamelabel = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dashdeanpicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashdeanpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2CustomGradientPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 426);
            this.panel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.BorderThickness = 1;
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.departmentemaillabel);
            this.guna2CustomGradientPanel1.Controls.Add(this.deansnamelabel);
            this.guna2CustomGradientPanel1.Controls.Add(this.dashdeanpicture);
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(8, 370);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(976, 53);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // departmentemaillabel
            // 
            this.departmentemaillabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentemaillabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentemaillabel.Location = new System.Drawing.Point(67, 26);
            this.departmentemaillabel.Name = "departmentemaillabel";
            this.departmentemaillabel.Size = new System.Drawing.Size(898, 27);
            this.departmentemaillabel.TabIndex = 52;
            this.departmentemaillabel.Text = "Message";
            this.departmentemaillabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deansnamelabel
            // 
            this.deansnamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deansnamelabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deansnamelabel.Location = new System.Drawing.Point(51, -5);
            this.deansnamelabel.Name = "deansnamelabel";
            this.deansnamelabel.Size = new System.Drawing.Size(925, 41);
            this.deansnamelabel.TabIndex = 50;
            this.deansnamelabel.Text = "dean name";
            this.deansnamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::InternGuide.Properties.Resources.paper_plane;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(50, 34);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(19, 12);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 51;
            this.guna2PictureBox1.TabStop = false;
            // 
            // dashdeanpicture
            // 
            this.dashdeanpicture.Image = global::InternGuide.Properties.Resources.profile_user;
            this.dashdeanpicture.ImageRotate = 0F;
            this.dashdeanpicture.Location = new System.Drawing.Point(6, 5);
            this.dashdeanpicture.Name = "dashdeanpicture";
            this.dashdeanpicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dashdeanpicture.Size = new System.Drawing.Size(48, 41);
            this.dashdeanpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dashdeanpicture.TabIndex = 1;
            this.dashdeanpicture.TabStop = false;
            // 
            // StudentHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StudentHomepage";
            this.Size = new System.Drawing.Size(994, 426);
            this.panel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashdeanpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox dashdeanpicture;
        private System.Windows.Forms.Label deansnamelabel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label departmentemaillabel;
    }
}
