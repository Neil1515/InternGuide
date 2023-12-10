namespace InternGuide.Deans_Form.Requirements
{
    partial class widgetprelim
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
            this.titletextbox = new System.Windows.Forms.Label();
            this.descriptiontextbox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewsamplefilebtn = new System.Windows.Forms.Button();
            this.sampletitletextbox = new System.Windows.Forms.Label();
            this.edittextbox = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // titletextbox
            // 
            this.titletextbox.AutoSize = true;
            this.titletextbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.titletextbox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletextbox.Location = new System.Drawing.Point(15, 14);
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.Size = new System.Drawing.Size(33, 17);
            this.titletextbox.TabIndex = 71;
            this.titletextbox.Text = "Title";
            // 
            // descriptiontextbox
            // 
            this.descriptiontextbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.descriptiontextbox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiontextbox.Location = new System.Drawing.Point(15, 42);
            this.descriptiontextbox.Name = "descriptiontextbox";
            this.descriptiontextbox.Size = new System.Drawing.Size(303, 80);
            this.descriptiontextbox.TabIndex = 72;
            this.descriptiontextbox.Text = "Description ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Total Student Upload";
            // 
            // viewsamplefilebtn
            // 
            this.viewsamplefilebtn.Location = new System.Drawing.Point(16, 141);
            this.viewsamplefilebtn.Name = "viewsamplefilebtn";
            this.viewsamplefilebtn.Size = new System.Drawing.Size(44, 23);
            this.viewsamplefilebtn.TabIndex = 74;
            this.viewsamplefilebtn.Text = "View";
            this.viewsamplefilebtn.UseVisualStyleBackColor = true;
            // 
            // sampletitletextbox
            // 
            this.sampletitletextbox.AutoSize = true;
            this.sampletitletextbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sampletitletextbox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampletitletextbox.Location = new System.Drawing.Point(65, 145);
            this.sampletitletextbox.Name = "sampletitletextbox";
            this.sampletitletextbox.Size = new System.Drawing.Size(76, 17);
            this.sampletitletextbox.TabIndex = 75;
            this.sampletitletextbox.Text = "Sample title";
            // 
            // edittextbox
            // 
            this.edittextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edittextbox.BackColor = System.Drawing.Color.White;
            this.edittextbox.BorderRadius = 5;
            this.edittextbox.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edittextbox.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edittextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edittextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edittextbox.FillColor = System.Drawing.Color.White;
            this.edittextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.edittextbox.ForeColor = System.Drawing.Color.Black;
            this.edittextbox.Image = global::InternGuide.Properties.Resources.edit__1_;
            this.edittextbox.Location = new System.Drawing.Point(300, 3);
            this.edittextbox.Name = "edittextbox";
            this.edittextbox.Size = new System.Drawing.Size(30, 33);
            this.edittextbox.TabIndex = 76;
            this.edittextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // widgetprelim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.edittextbox);
            this.Controls.Add(this.sampletitletextbox);
            this.Controls.Add(this.viewsamplefilebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptiontextbox);
            this.Controls.Add(this.titletextbox);
            this.Name = "widgetprelim";
            this.Size = new System.Drawing.Size(333, 165);
            this.Load += new System.EventHandler(this.widgetprelim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titletextbox;
        private System.Windows.Forms.Label descriptiontextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sampletitletextbox;
        private Guna.UI2.WinForms.Guna2Button edittextbox;
        private System.Windows.Forms.Button viewsamplefilebtn;
    }
}
