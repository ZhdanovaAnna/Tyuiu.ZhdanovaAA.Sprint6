
namespace Tyuiu.ZhdanovaAA.Sprint6.Task6.V11
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
            this.panel2.Location = new System.Drawing.Point(341, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 221);
            this.panel2.TabIndex = 1;
            // 
            // labelAbout_ZAA
            // 
            this.labelAbout_ZAA.AutoSize = true;
            this.labelAbout_ZAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAbout_ZAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAbout_ZAA.Location = new System.Drawing.Point(0, 0);
            this.labelAbout_ZAA.Name = "labelAbout_ZAA";
            this.labelAbout_ZAA.Size = new System.Drawing.Size(427, 120);
            this.labelAbout_ZAA.TabIndex = 0;
            this.labelAbout_ZAA.Text = "Студент Жданова Анна Александровна.\r\nГруппа ПКТб-23-1.\r\n\r\n\r\nТюменский индустриаль" +
    "ный университет (с) 2023\r\nВысшая школа цифровых технологий (с) 2023";
            // 
            // image_ZAA
            // 
            this.image_ZAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.image_ZAA.BackgroundImage = global::Tyuiu.ZhdanovaAA.Sprint6.Task6.V11.Properties.Resources.fish;
            this.image_ZAA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image_ZAA.Location = new System.Drawing.Point(13, 13);
            this.image_ZAA.Name = "image_ZAA";
            this.image_ZAA.Size = new System.Drawing.Size(321, 221);
            this.image_ZAA.TabIndex = 0;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 249);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.image_ZAA);
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