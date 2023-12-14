namespace InternGuide.Student_Form.studRequirements
{
    partial class widgetprelimstudent
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.descriptiontextbox = new System.Windows.Forms.Label();
            this.titletextbox = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.descriptiontextbox);
            this.guna2ShadowPanel1.Controls.Add(this.titletextbox);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(15, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1066, 165);
            this.guna2ShadowPanel1.TabIndex = 78;
            // 
            // descriptiontextbox
            // 
            this.descriptiontextbox.BackColor = System.Drawing.Color.White;
            this.descriptiontextbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.descriptiontextbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiontextbox.Location = new System.Drawing.Point(24, 54);
            this.descriptiontextbox.Name = "descriptiontextbox";
            this.descriptiontextbox.Size = new System.Drawing.Size(1010, 68);
            this.descriptiontextbox.TabIndex = 77;
            this.descriptiontextbox.Text = "Description";
            // 
            // titletextbox
            // 
            this.titletextbox.BackColor = System.Drawing.Color.White;
            this.titletextbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.titletextbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletextbox.Location = new System.Drawing.Point(24, 30);
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.Size = new System.Drawing.Size(962, 24);
            this.titletextbox.TabIndex = 71;
            this.titletextbox.Text = "Title";
            // 
            // widgetprelimstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "widgetprelimstudent";
            this.Size = new System.Drawing.Size(1084, 176);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label descriptiontextbox;
        private System.Windows.Forms.Label titletextbox;
    }
}
