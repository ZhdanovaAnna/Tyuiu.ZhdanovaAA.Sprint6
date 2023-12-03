
namespace Tyuiu.ZhdanovaAA.Sprint6.Task0.V29
{
    partial class FormMain
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
            this.groupBoxСondition_ZAA = new System.Windows.Forms.GroupBox();
            this.labelCondition_ZAA = new System.Windows.Forms.Label();
            this.pictureBoxContidion_ZAA = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxInputData_ZAA = new System.Windows.Forms.GroupBox();
            this.textBoxInputVarX_ZAA = new System.Windows.Forms.TextBox();
            this.labelVarX_ZAA = new System.Windows.Forms.Label();
            this.groupBoxOutputData_ZAA = new System.Windows.Forms.GroupBox();
            this.textBoxOutputResult_ZAA = new System.Windows.Forms.TextBox();
            this.lableResult_ZAA = new System.Windows.Forms.Label();
            this.buttonDone_ZAA = new System.Windows.Forms.Button();
            this.buttonHelp_ZAA = new System.Windows.Forms.Button();
            this.groupBoxСondition_ZAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContidion_ZAA)).BeginInit();
            this.groupBoxInputData_ZAA.SuspendLayout();
            this.groupBoxOutputData_ZAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxСondition_ZAA
            // 
            this.groupBoxСondition_ZAA.Controls.Add(this.labelCondition_ZAA);
            this.groupBoxСondition_ZAA.Controls.Add(this.pictureBoxContidion_ZAA);
            this.groupBoxСondition_ZAA.Location = new System.Drawing.Point(24, 41);
            this.groupBoxСondition_ZAA.Name = "groupBoxСondition_ZAA";
            this.groupBoxСondition_ZAA.Size = new System.Drawing.Size(750, 199);
            this.groupBoxСondition_ZAA.TabIndex = 0;
            this.groupBoxСondition_ZAA.TabStop = false;
            this.groupBoxСondition_ZAA.Text = "Условие";
            // 
            // labelCondition_ZAA
            // 
            this.labelCondition_ZAA.AutoSize = true;
            this.labelCondition_ZAA.Location = new System.Drawing.Point(6, 21);
            this.labelCondition_ZAA.Name = "labelCondition_ZAA";
            this.labelCondition_ZAA.Size = new System.Drawing.Size(241, 16);
            this.labelCondition_ZAA.TabIndex = 1;
            this.labelCondition_ZAA.Text = "Вычислить выражение по формуле:";
            // 
            // pictureBoxContidion_ZAA
            // 
            this.pictureBoxContidion_ZAA.Image = global::Tyuiu.ZhdanovaAA.Sprint6.Task0.V29.Properties.Resources.Untitled;
            this.pictureBoxContidion_ZAA.Location = new System.Drawing.Point(12, 54);
            this.pictureBoxContidion_ZAA.Name = "pictureBoxContidion_ZAA";
            this.pictureBoxContidion_ZAA.Size = new System.Drawing.Size(112, 59);
            this.pictureBoxContidion_ZAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxContidion_ZAA.TabIndex = 0;
            this.pictureBoxContidion_ZAA.TabStop = false;
            // 
            // groupBoxInputData_ZAA
            // 
            this.groupBoxInputData_ZAA.Controls.Add(this.textBoxInputVarX_ZAA);
            this.groupBoxInputData_ZAA.Controls.Add(this.labelVarX_ZAA);
            this.groupBoxInputData_ZAA.Location = new System.Drawing.Point(24, 246);
            this.groupBoxInputData_ZAA.Name = "groupBoxInputData_ZAA";
            this.groupBoxInputData_ZAA.Size = new System.Drawing.Size(469, 143);
            this.groupBoxInputData_ZAA.TabIndex = 1;
            this.groupBoxInputData_ZAA.TabStop = false;
            this.groupBoxInputData_ZAA.Text = "Ввод данных";
            // 
            // textBoxInputVarX_ZAA
            // 
            this.textBoxInputVarX_ZAA.Location = new System.Drawing.Point(12, 63);
            this.textBoxInputVarX_ZAA.Name = "textBoxInputVarX_ZAA";
            this.textBoxInputVarX_ZAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputVarX_ZAA.TabIndex = 1;
            this.textBoxInputVarX_ZAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // labelVarX_ZAA
            // 
            this.labelVarX_ZAA.AutoSize = true;
            this.labelVarX_ZAA.Location = new System.Drawing.Point(9, 31);
            this.labelVarX_ZAA.Name = "labelVarX_ZAA";
            this.labelVarX_ZAA.Size = new System.Drawing.Size(104, 16);
            this.labelVarX_ZAA.TabIndex = 0;
            this.labelVarX_ZAA.Text = "Переменная X:";
            // 
            // groupBoxOutputData_ZAA
            // 
            this.groupBoxOutputData_ZAA.Controls.Add(this.textBoxOutputResult_ZAA);
            this.groupBoxOutputData_ZAA.Controls.Add(this.lableResult_ZAA);
            this.groupBoxOutputData_ZAA.Location = new System.Drawing.Point(499, 246);
            this.groupBoxOutputData_ZAA.Name = "groupBoxOutputData_ZAA";
            this.groupBoxOutputData_ZAA.Size = new System.Drawing.Size(275, 143);
            this.groupBoxOutputData_ZAA.TabIndex = 2;
            this.groupBoxOutputData_ZAA.TabStop = false;
            this.groupBoxOutputData_ZAA.Text = "Вывод данных";
            // 
            // textBoxOutputResult_ZAA
            // 
            this.textBoxOutputResult_ZAA.Location = new System.Drawing.Point(20, 63);
            this.textBoxOutputResult_ZAA.Name = "textBoxOutputResult_ZAA";
            this.textBoxOutputResult_ZAA.ReadOnly = true;
            this.textBoxOutputResult_ZAA.Size = new System.Drawing.Size(100, 22);
            this.textBoxOutputResult_ZAA.TabIndex = 1;
            // 
            // lableResult_ZAA
            // 
            this.lableResult_ZAA.AutoSize = true;
            this.lableResult_ZAA.Location = new System.Drawing.Point(17, 31);
            this.lableResult_ZAA.Name = "lableResult_ZAA";
            this.lableResult_ZAA.Size = new System.Drawing.Size(81, 16);
            this.lableResult_ZAA.TabIndex = 0;
            this.lableResult_ZAA.Text = "Результат:";
            // 
            // buttonDone_ZAA
            // 
            this.buttonDone_ZAA.Location = new System.Drawing.Point(560, 395);
            this.buttonDone_ZAA.Name = "buttonDone_ZAA";
            this.buttonDone_ZAA.Size = new System.Drawing.Size(214, 43);
            this.buttonDone_ZAA.TabIndex = 3;
            this.buttonDone_ZAA.Text = "Выполнить";
            this.buttonDone_ZAA.UseVisualStyleBackColor = true;
            this.buttonDone_ZAA.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonHelp_ZAA
            // 
            this.buttonHelp_ZAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_ZAA.Location = new System.Drawing.Point(499, 395);
            this.buttonHelp_ZAA.Name = "buttonHelp_ZAA";
            this.buttonHelp_ZAA.Size = new System.Drawing.Size(55, 42);
            this.buttonHelp_ZAA.TabIndex = 4;
            this.buttonHelp_ZAA.Text = "?";
            this.buttonHelp_ZAA.UseVisualStyleBackColor = true;
            this.buttonHelp_ZAA.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_ZAA);
            this.Controls.Add(this.buttonDone_ZAA);
            this.Controls.Add(this.groupBoxOutputData_ZAA);
            this.Controls.Add(this.groupBoxInputData_ZAA);
            this.Controls.Add(this.groupBoxСondition_ZAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 29 | Жданова А. А.";
            this.groupBoxСondition_ZAA.ResumeLayout(false);
            this.groupBoxСondition_ZAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContidion_ZAA)).EndInit();
            this.groupBoxInputData_ZAA.ResumeLayout(false);
            this.groupBoxInputData_ZAA.PerformLayout();
            this.groupBoxOutputData_ZAA.ResumeLayout(false);
            this.groupBoxOutputData_ZAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxСondition_ZAA;
        private System.Windows.Forms.PictureBox pictureBoxContidion_ZAA;
        private System.Windows.Forms.Label labelCondition_ZAA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxInputData_ZAA;
        private System.Windows.Forms.TextBox textBoxInputVarX_ZAA;
        private System.Windows.Forms.Label labelVarX_ZAA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZAA;
        private System.Windows.Forms.TextBox textBoxOutputResult_ZAA;
        private System.Windows.Forms.Label lableResult_ZAA;
        private System.Windows.Forms.Button buttonDone_ZAA;
        private System.Windows.Forms.Button buttonHelp_ZAA;
    }
}

