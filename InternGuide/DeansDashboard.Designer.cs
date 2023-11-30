namespace InternGuide
{
    partial class DeansDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeansDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout1brn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dashpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.awdawd = new Guna.UI2.WinForms.Guna2Button();
            this.DepartmentPartnersCompbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Managemeetingsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.deanmanageaccountbtn = new Guna.UI2.WinForms.Guna2Button();
            this.studentrequirementbtn = new Guna.UI2.WinForms.Guna2Button();
            this.showstudentdetailsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.insertstudentbtn = new Guna.UI2.WinForms.Guna2Button();
            this.homebtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deanfnamelabel = new System.Windows.Forms.Label();
            this.dashboarddeanpicture1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout1brn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboarddeanpicture1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Logout1brn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 70);
            this.panel1.TabIndex = 1;
            // 
            // Logout1brn
            // 
            this.Logout1brn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout1brn.BackColor = System.Drawing.Color.Transparent;
            this.Logout1brn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logout1brn.Image = global::InternGuide.Properties.Resources._8723070_logout_icon;
            this.Logout1brn.Location = new System.Drawing.Point(1132, 14);
            this.Logout1brn.Name = "Logout1brn";
            this.Logout1brn.Size = new System.Drawing.Size(44, 44);
            this.Logout1brn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logout1brn.TabIndex = 42;
            this.Logout1brn.TabStop = false;
            this.Logout1brn.Click += new System.EventHandler(this.Logout1brn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(96, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(706, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "UNIVERSITY OF CEBU LAPU-LAPU AND MANDAUE INTERN GUIDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "InternGuide";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 40);
            this.label1.TabIndex = 44;
            this.label1.Text = "IG";
            // 
            // dashpanel
            // 
            this.dashpanel.BackColor = System.Drawing.Color.White;
            this.dashpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashpanel.Location = new System.Drawing.Point(253, 70);
            this.dashpanel.Name = "dashpanel";
            this.dashpanel.Size = new System.Drawing.Size(931, 679);
            this.dashpanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 679);
            this.panel2.TabIndex = 2;
            // 
            // awdawd
            // 
            this.awdawd.BackColor = System.Drawing.Color.White;
            this.awdawd.BorderRadius = 1;
            this.awdawd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.awdawd.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.awdawd.CheckedState.FillColor = System.Drawing.Color.White;
            this.awdawd.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.awdawd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.awdawd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.awdawd.DisabledState.FillColor = System.Drawing.Color.White;
            this.awdawd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.awdawd.Dock = System.Windows.Forms.DockStyle.Top;
            this.awdawd.FillColor = System.Drawing.Color.White;
            this.awdawd.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.awdawd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.awdawd.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.awdawd.Image = global::InternGuide.Properties.Resources.report;
            this.awdawd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.awdawd.ImageSize = new System.Drawing.Size(30, 30);
            this.awdawd.Location = new System.Drawing.Point(3, 402);
            this.awdawd.Name = "awdawd";
            this.awdawd.Size = new System.Drawing.Size(253, 51);
            this.awdawd.TabIndex = 50;
            this.awdawd.Text = "REPORTS";
            this.awdawd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DepartmentPartnersCompbtn
            // 
            this.DepartmentPartnersCompbtn.BackColor = System.Drawing.Color.White;
            this.DepartmentPartnersCompbtn.BorderRadius = 1;
            this.DepartmentPartnersCompbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DepartmentPartnersCompbtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.DepartmentPartnersCompbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.DepartmentPartnersCompbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.DepartmentPartnersCompbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DepartmentPartnersCompbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DepartmentPartnersCompbtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.DepartmentPartnersCompbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DepartmentPartnersCompbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DepartmentPartnersCompbtn.FillColor = System.Drawing.Color.White;
            this.DepartmentPartnersCompbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentPartnersCompbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DepartmentPartnersCompbtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.DepartmentPartnersCompbtn.Image = global::InternGuide.Properties.Resources.enterprise;
            this.DepartmentPartnersCompbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DepartmentPartnersCompbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.DepartmentPartnersCompbtn.Location = new System.Drawing.Point(3, 288);
            this.DepartmentPartnersCompbtn.Name = "DepartmentPartnersCompbtn";
            this.DepartmentPartnersCompbtn.Size = new System.Drawing.Size(253, 51);
            this.DepartmentPartnersCompbtn.TabIndex = 51;
            this.DepartmentPartnersCompbtn.Text = "MANAGE DEPARTMENT PARTNERS";
            this.DepartmentPartnersCompbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DepartmentPartnersCompbtn.Click += new System.EventHandler(this.DepartmentPartnersCompbtn_Click);
            // 
            // Managemeetingsbtn
            // 
            this.Managemeetingsbtn.BackColor = System.Drawing.Color.White;
            this.Managemeetingsbtn.BorderRadius = 1;
            this.Managemeetingsbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Managemeetingsbtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.Managemeetingsbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Managemeetingsbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Managemeetingsbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Managemeetingsbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Managemeetingsbtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.Managemeetingsbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Managemeetingsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Managemeetingsbtn.FillColor = System.Drawing.Color.White;
            this.Managemeetingsbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Managemeetingsbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Managemeetingsbtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.Managemeetingsbtn.Image = global::InternGuide.Properties.Resources.document;
            this.Managemeetingsbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Managemeetingsbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.Managemeetingsbtn.Location = new System.Drawing.Point(3, 174);
            this.Managemeetingsbtn.Name = "Managemeetingsbtn";
            this.Managemeetingsbtn.Size = new System.Drawing.Size(253, 51);
            this.Managemeetingsbtn.TabIndex = 50;
            this.Managemeetingsbtn.Text = "MANAGE  MEETINGS";
            this.Managemeetingsbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Managemeetingsbtn.Click += new System.EventHandler(this.Managemeetingsbtn_Click);
            // 
            // deanmanageaccountbtn
            // 
            this.deanmanageaccountbtn.BackColor = System.Drawing.Color.White;
            this.deanmanageaccountbtn.BorderRadius = 1;
            this.deanmanageaccountbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.deanmanageaccountbtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.deanmanageaccountbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.deanmanageaccountbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.deanmanageaccountbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deanmanageaccountbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deanmanageaccountbtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.deanmanageaccountbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deanmanageaccountbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deanmanageaccountbtn.FillColor = System.Drawing.Color.White;
            this.deanmanageaccountbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deanmanageaccountbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deanmanageaccountbtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.deanmanageaccountbtn.Image = global::InternGuide.Properties.Resources.manageaccount;
            this.deanmanageaccountbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deanmanageaccountbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.deanmanageaccountbtn.Location = new System.Drawing.Point(3, 60);
            this.deanmanageaccountbtn.Name = "deanmanageaccountbtn";
            this.deanmanageaccountbtn.Size = new System.Drawing.Size(253, 51);
            this.deanmanageaccountbtn.TabIndex = 47;
            this.deanmanageaccountbtn.Text = "MANAGE ACCOUNT";
            this.deanmanageaccountbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deanmanageaccountbtn.Click += new System.EventHandler(this.deanmanageaccountbtn_Click);
            // 
            // studentrequirementbtn
            // 
            this.studentrequirementbtn.BackColor = System.Drawing.Color.White;
            this.studentrequirementbtn.BorderRadius = 1;
            this.studentrequirementbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.studentrequirementbtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.studentrequirementbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.studentrequirementbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.studentrequirementbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.studentrequirementbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.studentrequirementbtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.studentrequirementbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.studentrequirementbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentrequirementbtn.FillColor = System.Drawing.Color.White;
            this.studentrequirementbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentrequirementbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.studentrequirementbtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.studentrequirementbtn.Image = global::InternGuide.Properties.Resources.document;
            this.studentrequirementbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.studentrequirementbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.studentrequirementbtn.Location = new System.Drawing.Point(3, 117);
            this.studentrequirementbtn.Name = "studentrequirementbtn";
            this.studentrequirementbtn.Size = new System.Drawing.Size(253, 51);
            this.studentrequirementbtn.TabIndex = 49;
            this.studentrequirementbtn.Text = "MANAGE STUDENT REQUIREMENT";
            this.studentrequirementbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.studentrequirementbtn.Click += new System.EventHandler(this.studentrequirementbtn_Click);
            // 
            // showstudentdetailsbtn
            // 
            this.showstudentdetailsbtn.BackColor = System.Drawing.Color.White;
            this.showstudentdetailsbtn.BorderRadius = 1;
            this.showstudentdetailsbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.showstudentdetailsbtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.showstudentdetailsbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.showstudentdetailsbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.showstudentdetailsbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showstudentdetailsbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showstudentdetailsbtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.showstudentdetailsbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showstudentdetailsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.showstudentdetailsbtn.FillColor = System.Drawing.Color.White;
            this.showstudentdetailsbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showstudentdetailsbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showstudentdetailsbtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.showstudentdetailsbtn.Image = global::InternGuide.Properties.Resources.view;
            this.showstudentdetailsbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.showstudentdetailsbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.showstudentdetailsbtn.Location = new System.Drawing.Point(3, 345);
            this.showstudentdetailsbtn.Name = "showstudentdetailsbtn";
            this.showstudentdetailsbtn.Size = new System.Drawing.Size(253, 51);
            this.showstudentdetailsbtn.TabIndex = 46;
            this.showstudentdetailsbtn.Text = "VIEW STUDENT";
            this.showstudentdetailsbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.showstudentdetailsbtn.Click += new System.EventHandler(this.showstudentdetailsbtn_Click);
            // 
            // insertstudentbtn
            // 
            this.insertstudentbtn.BackColor = System.Drawing.Color.White;
            this.insertstudentbtn.BorderRadius = 1;
            this.insertstudentbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.insertstudentbtn.CheckedState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.insertstudentbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.insertstudentbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.insertstudentbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.insertstudentbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.insertstudentbtn.DisabledState.FillColor = System.Drawing.Color.White;
            this.insertstudentbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.insertstudentbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.insertstudentbtn.FillColor = System.Drawing.Color.White;
            this.insertstudentbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertstudentbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insertstudentbtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.insertstudentbtn.Image = global::InternGuide.Properties.Resources.teacher;
            this.insertstudentbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.insertstudentbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.insertstudentbtn.Location = new System.Drawing.Point(3, 231);
            this.insertstudentbtn.Name = "insertstudentbtn";
            this.insertstudentbtn.Size = new System.Drawing.Size(253, 51);
            this.insertstudentbtn.TabIndex = 45;
            this.insertstudentbtn.Text = "MANAGE STUDENT";
            this.insertstudentbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.insertstudentbtn.Click += new System.EventHandler(this.insertstudentbtn_Click);
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
            this.homebtn.TabIndex = 44;
            this.homebtn.Text = "HOME";
            this.homebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deanfnamelabel);
            this.panel3.Controls.Add(this.dashboarddeanpicture1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 152);
            this.panel3.TabIndex = 45;
            // 
            // deanfnamelabel
            // 
            this.deanfnamelabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deanfnamelabel.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deanfnamelabel.ForeColor = System.Drawing.Color.Black;
            this.deanfnamelabel.Location = new System.Drawing.Point(0, 126);
            this.deanfnamelabel.Name = "deanfnamelabel";
            this.deanfnamelabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deanfnamelabel.Size = new System.Drawing.Size(253, 26);
            this.deanfnamelabel.TabIndex = 3;
            this.deanfnamelabel.Text = "adminname";
            this.deanfnamelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deanfnamelabel.Click += new System.EventHandler(this.deanfnamelabel_Click);
            // 
            // dashboarddeanpicture1
            // 
            this.dashboarddeanpicture1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboarddeanpicture1.Image = global::InternGuide.Properties.Resources.username;
            this.dashboarddeanpicture1.ImageRotate = 0F;
            this.dashboarddeanpicture1.Location = new System.Drawing.Point(53, 12);
            this.dashboarddeanpicture1.Name = "dashboarddeanpicture1";
            this.dashboarddeanpicture1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.dashboarddeanpicture1.Size = new System.Drawing.Size(147, 115);
            this.dashboarddeanpicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dashboarddeanpicture1.TabIndex = 2;
            this.dashboarddeanpicture1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.homebtn);
            this.flowLayoutPanel1.Controls.Add(this.deanmanageaccountbtn);
            this.flowLayoutPanel1.Controls.Add(this.studentrequirementbtn);
            this.flowLayoutPanel1.Controls.Add(this.Managemeetingsbtn);
            this.flowLayoutPanel1.Controls.Add(this.insertstudentbtn);
            this.flowLayoutPanel1.Controls.Add(this.DepartmentPartnersCompbtn);
            this.flowLayoutPanel1.Controls.Add(this.showstudentdetailsbtn);
            this.flowLayoutPanel1.Controls.Add(this.awdawd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 152);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(253, 527);
            this.flowLayoutPanel1.TabIndex = 46;
            // 
            // DeansDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.dashpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeansDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeansDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeansDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout1brn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dashboarddeanpicture1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logout1brn;
        private System.Windows.Forms.Panel dashpanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button deanmanageaccountbtn;
        private Guna.UI2.WinForms.Guna2Button showstudentdetailsbtn;
        private Guna.UI2.WinForms.Guna2Button insertstudentbtn;
        private Guna.UI2.WinForms.Guna2Button homebtn;
        private Guna.UI2.WinForms.Guna2Button studentrequirementbtn;
        private Guna.UI2.WinForms.Guna2Button awdawd;
        private Guna.UI2.WinForms.Guna2Button Managemeetingsbtn;
        private Guna.UI2.WinForms.Guna2Button DepartmentPartnersCompbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label deanfnamelabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox dashboarddeanpicture1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}