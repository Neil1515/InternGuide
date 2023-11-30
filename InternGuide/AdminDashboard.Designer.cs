namespace InternGuide
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminnamelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.homebtn = new Guna.UI2.WinForms.Guna2Button();
            this.departmentadminbtn = new Guna.UI2.WinForms.Guna2Button();
            this.adminmanageaccountbtn = new Guna.UI2.WinForms.Guna2Button();
            this.departmentadmindetailsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardadminpicture1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.myprofilebtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardadminpicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.myprofilebtn);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 70);
            this.panel1.TabIndex = 0;
            // 
            // adminnamelabel
            // 
            this.adminnamelabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminnamelabel.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminnamelabel.ForeColor = System.Drawing.Color.Black;
            this.adminnamelabel.Location = new System.Drawing.Point(0, 165);
            this.adminnamelabel.Name = "adminnamelabel";
            this.adminnamelabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.adminnamelabel.Size = new System.Drawing.Size(253, 43);
            this.adminnamelabel.TabIndex = 3;
            this.adminnamelabel.Text = "adminname";
            this.adminnamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(96, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(706, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "UNIVERSITY OF CEBU LAPU-LAPU AND MANDAUE INTERN GUIDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "InternGuide";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "IG";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 516);
            this.panel2.TabIndex = 1;
            // 
            // dashpanel
            // 
            this.dashpanel.BackColor = System.Drawing.Color.White;
            this.dashpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashpanel.Location = new System.Drawing.Point(253, 70);
            this.dashpanel.Name = "dashpanel";
            this.dashpanel.Size = new System.Drawing.Size(931, 516);
            this.dashpanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminnamelabel);
            this.panel3.Controls.Add(this.dashboardadminpicture1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 208);
            this.panel3.TabIndex = 44;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.homebtn);
            this.flowLayoutPanel1.Controls.Add(this.departmentadminbtn);
            this.flowLayoutPanel1.Controls.Add(this.adminmanageaccountbtn);
            this.flowLayoutPanel1.Controls.Add(this.departmentadmindetailsbtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 208);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 308);
            this.flowLayoutPanel1.TabIndex = 45;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.White;
            this.homebtn.BorderRadius = 1;
            this.homebtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homebtn.Checked = true;
            this.homebtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.homebtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.homebtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.homebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homebtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.homebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebtn.FillColor = System.Drawing.Color.White;
            this.homebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homebtn.HoverState.CustomBorderColor = System.Drawing.Color.Tan;
            this.homebtn.Image = global::InternGuide.Properties.Resources.home;
            this.homebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homebtn.ImageSize = new System.Drawing.Size(30, 30);
            this.homebtn.Location = new System.Drawing.Point(3, 3);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(253, 51);
            this.homebtn.TabIndex = 36;
            this.homebtn.Text = "HOME";
            this.homebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // departmentadminbtn
            // 
            this.departmentadminbtn.BackColor = System.Drawing.Color.White;
            this.departmentadminbtn.BorderRadius = 1;
            this.departmentadminbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.departmentadminbtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.departmentadminbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.departmentadminbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.departmentadminbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.departmentadminbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.departmentadminbtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.departmentadminbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.departmentadminbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.departmentadminbtn.FillColor = System.Drawing.Color.White;
            this.departmentadminbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentadminbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.departmentadminbtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.departmentadminbtn.Image = global::InternGuide.Properties.Resources.teacher;
            this.departmentadminbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.departmentadminbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.departmentadminbtn.Location = new System.Drawing.Point(3, 60);
            this.departmentadminbtn.Name = "departmentadminbtn";
            this.departmentadminbtn.Size = new System.Drawing.Size(253, 51);
            this.departmentadminbtn.TabIndex = 40;
            this.departmentadminbtn.Text = "MANAGE DEANS";
            this.departmentadminbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.departmentadminbtn.Click += new System.EventHandler(this.departmentadminbtn_Click);
            // 
            // adminmanageaccountbtn
            // 
            this.adminmanageaccountbtn.BackColor = System.Drawing.Color.White;
            this.adminmanageaccountbtn.BorderRadius = 1;
            this.adminmanageaccountbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.adminmanageaccountbtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.adminmanageaccountbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.adminmanageaccountbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.adminmanageaccountbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adminmanageaccountbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adminmanageaccountbtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.adminmanageaccountbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adminmanageaccountbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminmanageaccountbtn.FillColor = System.Drawing.Color.White;
            this.adminmanageaccountbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminmanageaccountbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminmanageaccountbtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.adminmanageaccountbtn.Image = global::InternGuide.Properties.Resources.manageaccount;
            this.adminmanageaccountbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminmanageaccountbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.adminmanageaccountbtn.Location = new System.Drawing.Point(3, 117);
            this.adminmanageaccountbtn.Name = "adminmanageaccountbtn";
            this.adminmanageaccountbtn.Size = new System.Drawing.Size(253, 51);
            this.adminmanageaccountbtn.TabIndex = 42;
            this.adminmanageaccountbtn.Text = "MANAGE ACCOUNT";
            this.adminmanageaccountbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminmanageaccountbtn.Click += new System.EventHandler(this.adminmanageaccountbtn_Click);
            // 
            // departmentadmindetailsbtn
            // 
            this.departmentadmindetailsbtn.BackColor = System.Drawing.Color.White;
            this.departmentadmindetailsbtn.BorderRadius = 1;
            this.departmentadmindetailsbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.departmentadmindetailsbtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.departmentadmindetailsbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.departmentadmindetailsbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.departmentadmindetailsbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.departmentadmindetailsbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.departmentadmindetailsbtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.departmentadmindetailsbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.departmentadmindetailsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.departmentadmindetailsbtn.FillColor = System.Drawing.Color.White;
            this.departmentadmindetailsbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentadmindetailsbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.departmentadmindetailsbtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.departmentadmindetailsbtn.Image = global::InternGuide.Properties.Resources.view;
            this.departmentadmindetailsbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.departmentadmindetailsbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.departmentadmindetailsbtn.Location = new System.Drawing.Point(3, 174);
            this.departmentadmindetailsbtn.Name = "departmentadmindetailsbtn";
            this.departmentadmindetailsbtn.Size = new System.Drawing.Size(253, 51);
            this.departmentadmindetailsbtn.TabIndex = 41;
            this.departmentadmindetailsbtn.Text = "SHOW ALL DEANS";
            this.departmentadmindetailsbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.departmentadmindetailsbtn.Click += new System.EventHandler(this.departmentadmindetailsbtn_Click);
            // 
            // dashboardadminpicture1
            // 
            this.dashboardadminpicture1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardadminpicture1.Image = global::InternGuide.Properties.Resources.username;
            this.dashboardadminpicture1.ImageRotate = 0F;
            this.dashboardadminpicture1.Location = new System.Drawing.Point(44, 12);
            this.dashboardadminpicture1.Name = "dashboardadminpicture1";
            this.dashboardadminpicture1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dashboardadminpicture1.Size = new System.Drawing.Size(165, 156);
            this.dashboardadminpicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dashboardadminpicture1.TabIndex = 2;
            this.dashboardadminpicture1.TabStop = false;
            // 
            // myprofilebtn
            // 
            this.myprofilebtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myprofilebtn.BorderRadius = 5;
            this.myprofilebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.myprofilebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.myprofilebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.myprofilebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.myprofilebtn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myprofilebtn.ForeColor = System.Drawing.Color.White;
            this.myprofilebtn.Image = global::InternGuide.Properties.Resources.profile_user;
            this.myprofilebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.myprofilebtn.ImageSize = new System.Drawing.Size(25, 25);
            this.myprofilebtn.Location = new System.Drawing.Point(911, 20);
            this.myprofilebtn.Name = "myprofilebtn";
            this.myprofilebtn.Size = new System.Drawing.Size(125, 35);
            this.myprofilebtn.TabIndex = 50;
            this.myprofilebtn.Text = "My Profile";
            this.myprofilebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.myprofilebtn.Click += new System.EventHandler(this.myprofilebtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutbtn.BorderRadius = 5;
            this.logoutbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutbtn.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.logoutbtn.ForeColor = System.Drawing.Color.White;
            this.logoutbtn.Image = global::InternGuide.Properties.Resources.on_off_button;
            this.logoutbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutbtn.Location = new System.Drawing.Point(1066, 20);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(97, 35);
            this.logoutbtn.TabIndex = 49;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click_1);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 586);
            this.Controls.Add(this.dashpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardadminpicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel dashpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox dashboardadminpicture1;
        private System.Windows.Forms.Label adminnamelabel;
        private Guna.UI2.WinForms.Guna2Button homebtn;
        private Guna.UI2.WinForms.Guna2Button departmentadmindetailsbtn;
        private Guna.UI2.WinForms.Guna2Button departmentadminbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button myprofilebtn;
        private Guna.UI2.WinForms.Guna2Button logoutbtn;
        private Guna.UI2.WinForms.Guna2Button adminmanageaccountbtn;
    }
}