﻿namespace InternGuide.Deans_Form.Requirements
{
    partial class FinalRequirements
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.addfinalreqs = new System.Windows.Forms.PictureBox();
            this.prelimflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addfinalreqs)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.AllowDrop = true;
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 5;
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.addfinalreqs);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(931, 67);
            this.guna2CustomGradientPanel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 39;
            this.label1.Text = "Final Requirement";
            // 
            // addfinalreqs
            // 
            this.addfinalreqs.BackColor = System.Drawing.Color.Transparent;
            this.addfinalreqs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addfinalreqs.Image = global::InternGuide.Properties.Resources.adduser;
            this.addfinalreqs.Location = new System.Drawing.Point(12, 13);
            this.addfinalreqs.Name = "addfinalreqs";
            this.addfinalreqs.Size = new System.Drawing.Size(43, 43);
            this.addfinalreqs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addfinalreqs.TabIndex = 38;
            this.addfinalreqs.TabStop = false;
            this.addfinalreqs.Click += new System.EventHandler(this.addfinalreqs_Click);
            // 
            // prelimflowLayoutPanel
            // 
            this.prelimflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prelimflowLayoutPanel.Location = new System.Drawing.Point(0, 67);
            this.prelimflowLayoutPanel.Name = "prelimflowLayoutPanel";
            this.prelimflowLayoutPanel.Size = new System.Drawing.Size(931, 363);
            this.prelimflowLayoutPanel.TabIndex = 45;
            // 
            // FinalRequirements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prelimflowLayoutPanel);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "FinalRequirements";
            this.Size = new System.Drawing.Size(931, 430);
            this.Load += new System.EventHandler(this.FinalRequirements_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addfinalreqs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox addfinalreqs;
        private System.Windows.Forms.FlowLayoutPanel prelimflowLayoutPanel;
    }
}
