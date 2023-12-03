
namespace Tyuiu.ZhdanovaAA.Sprint6.Task3.V30
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
            this.groupBoxCondition_ZAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOriginalMatrix_ZAA = new System.Windows.Forms.DataGridView();
            this.labelCondition_ZAA = new System.Windows.Forms.Label();
            this.groupBoxOutputData_ZAA = new System.Windows.Forms.GroupBox();
            this.labelResult_ZAA = new System.Windows.Forms.Label();
            this.dataGridViewResultMatrix_ZAA = new System.Windows.Forms.DataGridView();
            this.buttonDone_ZAA = new System.Windows.Forms.Button();
            this.buttonHelp_ZAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_ZAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginalMatrix_ZAA)).BeginInit();
            this.groupBoxOutputData_ZAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultMatrix_ZAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_ZAA
            // 
            this.groupBoxCondition_ZAA.Controls.Add(this.dataGridViewOriginalMatrix_ZAA);
            this.groupBoxCondition_ZAA.Controls.Add(this.labelCondition_ZAA);
            this.groupBoxCondition_ZAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_ZAA.Name = "groupBoxCondition_ZAA";
            this.groupBoxCondition_ZAA.Size = new System.Drawing.Size(650, 332);
            this.groupBoxCondition_ZAA.TabIndex = 0;
            this.groupBoxCondition_ZAA.TabStop = false;
            this.groupBoxCondition_ZAA.Text = "Условие";
            // 
            // dataGridViewOriginalMatrix_ZAA
            // 
            this.dataGridViewOriginalMatrix_ZAA.AllowUserToAddRows = false;
            this.dataGridViewOriginalMatrix_ZAA.AllowUserToDeleteRows = false;
            this.dataGridViewOriginalMatrix_ZAA.AllowUserToResizeColumns = false;
            this.dataGridViewOriginalMatrix_ZAA.AllowUserToResizeRows = false;
            this.dataGridViewOriginalMatrix_ZAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOriginalMatrix_ZAA.ColumnHeadersVisible = false;
            this.dataGridViewOriginalMatrix_ZAA.Location = new System.Drawing.Point(352, 59);
            this.dataGridViewOriginalMatrix_ZAA.Name = "dataGridViewOriginalMatrix_ZAA";
            this.dataGridViewOriginalMatrix_ZAA.ReadOnly = true;
            this.dataGridViewOriginalMatrix_ZAA.RowHeadersVisible = false;
            this.dataGridViewOriginalMatrix_ZAA.RowHeadersWidth = 51;
            this.dataGridViewOriginalMatrix_ZAA.RowTemplate.Height = 24;
            this.dataGridViewOriginalMatrix_ZAA.Size = new System.Drawing.Size(263, 232);
            this.dataGridViewOriginalMatrix_ZAA.TabIndex = 1;
            // 
            // labelCondition_ZAA
            // 
            this.labelCondition_ZAA.AutoSize = true;
            this.labelCondition_ZAA.Location = new System.Drawing.Point(7, 22);
            this.labelCondition_ZAA.MaximumSize = new System.Drawing.Size(414, 191);
            this.labelCondition_ZAA.Name = "labelCondition_ZAA";
            this.labelCondition_ZAA.Size = new System.Drawing.Size(414, 191);
            this.labelCondition_ZAA.TabIndex = 0;
            this.labelCondition_ZAA.Text = "Дана матрица 5 на 5\r\n\r\n  -9   -4  17  -1 -20\r\n -19  18  -4   2   14\r\n -12  16  -2" +
    "   7   18\r\n -16  15   4 -12 -13\r\n -15  -4 -16   1  -14\r\n\r\nЗаменить четные значен" +
    "ия в пятой строке на 0.\r\n";
            // 
            // groupBoxOutputData_ZAA
            // 
            this.groupBoxOutputData_ZAA.Controls.Add(this.labelResult_ZAA);
            this.groupBoxOutputData_ZAA.Controls.Add(this.dataGridViewResultMatrix_ZAA);
            this.groupBoxOutputData_ZAA.Location = new System.Drawing.Point(668, 12);
            this.groupBoxOutputData_ZAA.Name = "groupBoxOutputData_ZAA";
            this.groupBoxOutputData_ZAA.Size = new System.Drawing.Size(326, 332);
            this.groupBoxOutputData_ZAA.TabIndex = 1;
            this.groupBoxOutputData_ZAA.TabStop = false;
            this.groupBoxOutputData_ZAA.Text = "Вывод данных";
            // 
            // labelResult_ZAA
            // 
            this.labelResult_ZAA.AutoSize = true;
            this.labelResult_ZAA.Location = new System.Drawing.Point(7, 18);
            this.labelResult_ZAA.Name = "labelResult_ZAA";
            this.labelResult_ZAA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_ZAA.TabIndex = 1;
            this.labelResult_ZAA.Text = "Результат:";
            // 
            // dataGridViewResultMatrix_ZAA
            // 
            this.dataGridViewResultMatrix_ZAA.AllowUserToAddRows = false;
            this.dataGridViewResultMatrix_ZAA.AllowUserToOrderColumns = true;
            this.dataGridViewResultMatrix_ZAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultMatrix_ZAA.ColumnHeadersVisible = false;
            this.dataGridViewResultMatrix_ZAA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewResultMatrix_ZAA.Location = new System.Drawing.Point(37, 59);
            this.dataGridViewResultMatrix_ZAA.Name = "dataGridViewResultMatrix_ZAA";
            this.dataGridViewResultMatrix_ZAA.ReadOnly = true;
            this.dataGridViewResultMatrix_ZAA.RowHeadersVisible = false;
            this.dataGridViewResultMatrix_ZAA.RowHeadersWidth = 51;
            this.dataGridViewResultMatrix_ZAA.RowTemplate.Height = 24;
            this.dataGridViewResultMatrix_ZAA.Size = new System.Drawing.Size(261, 234);
            this.dataGridViewResultMatrix_ZAA.TabIndex = 0;
            // 
            // buttonDone_ZAA
            // 
            this.buttonDone_ZAA.Location = new System.Drawing.Point(836, 356);
            this.buttonDone_ZAA.Name = "buttonDone_ZAA";
            this.buttonDone_ZAA.Size = new System.Drawing.Size(158, 38);
            this.buttonDone_ZAA.TabIndex = 2;
            this.buttonDone_ZAA.Text = "Выполнить";
            this.buttonDone_ZAA.UseVisualStyleBackColor = true;
            this.buttonDone_ZAA.Click += new System.EventHandler(this.buttonDone_ZAA_Click);
            // 
            // buttonHelp_ZAA
            // 
            this.buttonHelp_ZAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_ZAA.Location = new System.Drawing.Point(785, 356);
            this.buttonHelp_ZAA.Name = "buttonHelp_ZAA";
            this.buttonHelp_ZAA.Size = new System.Drawing.Size(45, 38);
            this.buttonHelp_ZAA.TabIndex = 3;
            this.buttonHelp_ZAA.Text = "?";
            this.buttonHelp_ZAA.UseVisualStyleBackColor = true;
            this.buttonHelp_ZAA.Click += new System.EventHandler(this.buttonHelp_ZAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 409);
            this.Controls.Add(this.buttonHelp_ZAA);
            this.Controls.Add(this.buttonDone_ZAA);
            this.Controls.Add(this.groupBoxOutputData_ZAA);
            this.Controls.Add(this.groupBoxCondition_ZAA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1027, 456);
            this.MinimumSize = new System.Drawing.Size(1027, 456);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 30 | Жданова А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_ZAA.ResumeLayout(false);
            this.groupBoxCondition_ZAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOriginalMatrix_ZAA)).EndInit();
            this.groupBoxOutputData_ZAA.ResumeLayout(false);
            this.groupBoxOutputData_ZAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultMatrix_ZAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_ZAA;
        private System.Windows.Forms.Label labelCondition_ZAA;
        private System.Windows.Forms.DataGridView dataGridViewOriginalMatrix_ZAA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZAA;
        private System.Windows.Forms.Label labelResult_ZAA;
        private System.Windows.Forms.DataGridView dataGridViewResultMatrix_ZAA;
        private System.Windows.Forms.Button buttonDone_ZAA;
        private System.Windows.Forms.Button buttonHelp_ZAA;
    }
}

