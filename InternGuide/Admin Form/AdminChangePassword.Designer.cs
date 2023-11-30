namespace InternGuide.Admin_Form
{
    partial class AdminChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorlabel = new System.Windows.Forms.Label();
            this.confirmbtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.verifynewpassTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newpassTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.oldpassTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 78);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 60);
            this.label1.TabIndex = 34;
            this.label1.Text = "CHANGE PASS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.errorlabel);
            this.panel2.Controls.Add(this.confirmbtn);
            this.panel2.Controls.Add(this.cancelbtn);
            this.panel2.Controls.Add(this.verifynewpassTextBox);
            this.panel2.Controls.Add(this.newpassTextBox);
            this.panel2.Controls.Add(this.oldpassTextBox);
            this.panel2.Controls.Add(this.namelabel);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 392);
            this.panel2.TabIndex = 6;
            // 
            // errorlabel
            // 
            this.errorlabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.errorlabel.BackColor = System.Drawing.Color.Transparent;
            this.errorlabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.errorlabel.Location = new System.Drawing.Point(0, 164);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(408, 20);
            this.errorlabel.TabIndex = 59;
            this.errorlabel.Text = "Error";
            this.errorlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmbtn
            // 
            this.confirmbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmbtn.BorderRadius = 10;
            this.confirmbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.ForeColor = System.Drawing.Color.White;
            this.confirmbtn.Location = new System.Drawing.Point(223, 333);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(156, 47);
            this.confirmbtn.TabIndex = 58;
            this.confirmbtn.Text = "CONFIRM";
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BorderRadius = 10;
            this.cancelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(37, 333);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(156, 47);
            this.cancelbtn.TabIndex = 57;
            this.cancelbtn.Text = "CANCEL";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // namelabel
            // 
            this.namelabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.namelabel.Location = new System.Drawing.Point(0, 3);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(408, 23);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "NAME";
            this.namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // verifynewpassTextBox
            // 
            this.verifynewpassTextBox.BorderRadius = 10;
            this.verifynewpassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.verifynewpassTextBox.DefaultText = "";
            this.verifynewpassTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verifynewpassTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verifynewpassTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verifynewpassTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verifynewpassTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verifynewpassTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.verifynewpassTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verifynewpassTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("verifynewpassTextBox.IconLeft")));
            this.verifynewpassTextBox.Location = new System.Drawing.Point(37, 289);
            this.verifynewpassTextBox.Name = "verifynewpassTextBox";
            this.verifynewpassTextBox.PasswordChar = '*';
            this.verifynewpassTextBox.PlaceholderText = "VERIFY NEW PASSWORD";
            this.verifynewpassTextBox.SelectedText = "";
            this.verifynewpassTextBox.Size = new System.Drawing.Size(342, 36);
            this.verifynewpassTextBox.TabIndex = 4;
            // 
            // newpassTextBox
            // 
            this.newpassTextBox.BorderRadius = 10;
            this.newpassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newpassTextBox.DefaultText = "";
            this.newpassTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newpassTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newpassTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newpassTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newpassTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newpassTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newpassTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newpassTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("newpassTextBox.IconLeft")));
            this.newpassTextBox.Location = new System.Drawing.Point(37, 238);
            this.newpassTextBox.Name = "newpassTextBox";
            this.newpassTextBox.PasswordChar = '*';
            this.newpassTextBox.PlaceholderText = "NEW PASSWORD";
            this.newpassTextBox.SelectedText = "";
            this.newpassTextBox.Size = new System.Drawing.Size(342, 36);
            this.newpassTextBox.TabIndex = 3;
            // 
            // oldpassTextBox
            // 
            this.oldpassTextBox.BorderRadius = 10;
            this.oldpassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldpassTextBox.DefaultText = "";
            this.oldpassTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.oldpassTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.oldpassTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldpassTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldpassTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oldpassTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.oldpassTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oldpassTextBox.IconLeft = global::InternGuide.Properties.Resources.key_chain;
            this.oldpassTextBox.Location = new System.Drawing.Point(37, 185);
            this.oldpassTextBox.Name = "oldpassTextBox";
            this.oldpassTextBox.PasswordChar = '*';
            this.oldpassTextBox.PlaceholderText = "OLD PASSWORD";
            this.oldpassTextBox.SelectedText = "";
            this.oldpassTextBox.Size = new System.Drawing.Size(342, 36);
            this.oldpassTextBox.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox.Location = new System.Drawing.Point(124, 26);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(163, 135);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // AdminChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminChangePassword";
            this.Load += new System.EventHandler(this.AdminChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label errorlabel;
        private Guna.UI2.WinForms.Guna2Button confirmbtn;
        private Guna.UI2.WinForms.Guna2Button cancelbtn;
        private Guna.UI2.WinForms.Guna2TextBox verifynewpassTextBox;
        private Guna.UI2.WinForms.Guna2TextBox newpassTextBox;
        private Guna.UI2.WinForms.Guna2TextBox oldpassTextBox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}