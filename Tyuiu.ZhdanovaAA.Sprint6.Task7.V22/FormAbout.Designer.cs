﻿
namespace Tyuiu.ZhdanovaAA.Sprint6.Task7.V22
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAbout_ZAA = new System.Windows.Forms.Label();
            this.image_ZAA = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelAbout_ZAA);
            this.panel2.Location = new System.Drawing.Point(298, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 207);
            this.panel2.TabIndex = 1;
            // 
            // labelAbout_ZAA
            // 
            this.labelAbout_ZAA.AutoSize = true;
            this.labelAbout_ZAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAbout_ZAA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout_ZAA.Location = new System.Drawing.Point(0, 0);
            this.labelAbout_ZAA.Name = "labelAbout_ZAA";
            this.labelAbout_ZAA.Size = new System.Drawing.Size(450, 200);
            this.labelAbout_ZAA.TabIndex = 0;
            this.labelAbout_ZAA.Text = resources.GetString("labelAbout_ZAA.Text");
            // 
            // image_ZAA
            // 
            this.image_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.image_ZAA.BackgroundImage = global::Tyuiu.ZhdanovaAA.Sprint6.Task7.V22.Properties.Resources.fish;
            this.image_ZAA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_ZAA.Location = new System.Drawing.Point(11, 12);
            this.image_ZAA.Name = "image_ZAA";
            this.image_ZAA.Size = new System.Drawing.Size(281, 207);
            this.image_ZAA.TabIndex = 0;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 233);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.image_ZAA);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(834, 296);
            this.MinimumSize = new System.Drawing.Size(732, 280);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel image_ZAA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAbout_ZAA;
    }
}