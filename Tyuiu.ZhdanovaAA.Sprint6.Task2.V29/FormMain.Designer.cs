
namespace Tyuiu.ZhdanovaAA.Sprint6.Task2.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_ZAA = new System.Windows.Forms.GroupBox();
            this.labelCondition_ZAA = new System.Windows.Forms.Label();
            this.groupBoxOutputData_ZAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_ZAA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_ZAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_ZAA = new System.Windows.Forms.Label();
            this.groupBoxInputData_ZAA = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_ZAA = new System.Windows.Forms.TextBox();
            this.labelStopStep_ZAA = new System.Windows.Forms.Label();
            this.textBoxStartStep_ZAA = new System.Windows.Forms.TextBox();
            this.labelStartStep_ZAA = new System.Windows.Forms.Label();
            this.buttonHelp_ZAA = new System.Windows.Forms.Button();
            this.buttonDone_ZAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_ZAA.SuspendLayout();
            this.groupBoxOutputData_ZAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ZAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZAA)).BeginInit();
            this.groupBoxInputData_ZAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_ZAA
            // 
            this.groupBoxCondition_ZAA.Controls.Add(this.labelCondition_ZAA);
            this.groupBoxCondition_ZAA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_ZAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_ZAA.Name = "groupBoxCondition_ZAA";
            this.groupBoxCondition_ZAA.Size = new System.Drawing.Size(634, 376);
            this.groupBoxCondition_ZAA.TabIndex = 0;
            this.groupBoxCondition_ZAA.TabStop = false;
            this.groupBoxCondition_ZAA.Text = "Условие";
            // 
            // labelCondition_ZAA
            // 
            this.labelCondition_ZAA.AutoSize = true;
            this.labelCondition_ZAA.Location = new System.Drawing.Point(7, 22);
            this.labelCondition_ZAA.Name = "labelCondition_ZAA";
            this.labelCondition_ZAA.Size = new System.Drawing.Size(486, 60);
            this.labelCondition_ZAA.TabIndex = 0;
            this.labelCondition_ZAA.Text = "Протабулировать f(x) = (2cos(x)+2)/(2x-1)+cos(x)-5x+3\r\nна заданном диапозоне.\r\nРе" +
    "зультат вывести в DataGridView и построить график.";
            // 
            // groupBoxOutputData_ZAA
            // 
            this.groupBoxOutputData_ZAA.Controls.Add(this.dataGridViewFunction_ZAA);
            this.groupBoxOutputData_ZAA.Controls.Add(this.chartFunction_ZAA);
            this.groupBoxOutputData_ZAA.Controls.Add(this.labelResult_ZAA);
            this.groupBoxOutputData_ZAA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_ZAA.Location = new System.Drawing.Point(652, 12);
            this.groupBoxOutputData_ZAA.Name = "groupBoxOutputData_ZAA";
            this.groupBoxOutputData_ZAA.Size = new System.Drawing.Size(660, 494);
            this.groupBoxOutputData_ZAA.TabIndex = 1;
            this.groupBoxOutputData_ZAA.TabStop = false;
            this.groupBoxOutputData_ZAA.Text = "Вывод данных";
            // 
            // dataGridViewFunction_ZAA
            // 
            this.dataGridViewFunction_ZAA.AllowUserToAddRows = false;
            this.dataGridViewFunction_ZAA.AllowUserToDeleteRows = false;
            this.dataGridViewFunction_ZAA.AllowUserToResizeColumns = false;
            this.dataGridViewFunction_ZAA.AllowUserToResizeRows = false;
            this.dataGridViewFunction_ZAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_ZAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_ZAA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFunction_ZAA.Location = new System.Drawing.Point(11, 46);
            this.dataGridViewFunction_ZAA.Name = "dataGridViewFunction_ZAA";
            this.dataGridViewFunction_ZAA.ReadOnly = true;
            this.dataGridViewFunction_ZAA.RowHeadersVisible = false;
            this.dataGridViewFunction_ZAA.RowHeadersWidth = 51;
            this.dataGridViewFunction_ZAA.RowTemplate.Height = 24;
            this.dataGridViewFunction_ZAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFunction_ZAA.Size = new System.Drawing.Size(164, 442);
            this.dataGridViewFunction_ZAA.TabIndex = 2;
            // 
            // X
            // 
            this.X.FillWeight = 50F;
            this.X.Frozen = true;
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.FillWeight = 50F;
            this.Y.Frozen = true;
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Y.Width = 90;
            // 
            // chartFunction_ZAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_ZAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_ZAA.Legends.Add(legend1);
            this.chartFunction_ZAA.Location = new System.Drawing.Point(181, 46);
            this.chartFunction_ZAA.Name = "chartFunction_ZAA";
            this.chartFunction_ZAA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_ZAA.Series.Add(series1);
            this.chartFunction_ZAA.Size = new System.Drawing.Size(468, 442);
            this.chartFunction_ZAA.TabIndex = 1;
            // 
            // labelResult_ZAA
            // 
            this.labelResult_ZAA.AutoSize = true;
            this.labelResult_ZAA.Location = new System.Drawing.Point(7, 22);
            this.labelResult_ZAA.Name = "labelResult_ZAA";
            this.labelResult_ZAA.Size = new System.Drawing.Size(99, 20);
            this.labelResult_ZAA.TabIndex = 0;
            this.labelResult_ZAA.Text = "Результат:";
            // 
            // groupBoxInputData_ZAA
            // 
            this.groupBoxInputData_ZAA.Controls.Add(this.textBoxStopStep_ZAA);
            this.groupBoxInputData_ZAA.Controls.Add(this.labelStopStep_ZAA);
            this.groupBoxInputData_ZAA.Controls.Add(this.textBoxStartStep_ZAA);
            this.groupBoxInputData_ZAA.Controls.Add(this.labelStartStep_ZAA);
            this.groupBoxInputData_ZAA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_ZAA.Location = new System.Drawing.Point(13, 394);
            this.groupBoxInputData_ZAA.Name = "groupBoxInputData_ZAA";
            this.groupBoxInputData_ZAA.Size = new System.Drawing.Size(306, 112);
            this.groupBoxInputData_ZAA.TabIndex = 2;
            this.groupBoxInputData_ZAA.TabStop = false;
            this.groupBoxInputData_ZAA.Text = "Ввод данных";
            // 
            // textBoxStopStep_ZAA
            // 
            this.textBoxStopStep_ZAA.Location = new System.Drawing.Point(163, 46);
            this.textBoxStopStep_ZAA.Name = "textBoxStopStep_ZAA";
            this.textBoxStopStep_ZAA.Size = new System.Drawing.Size(132, 27);
            this.textBoxStopStep_ZAA.TabIndex = 3;
            this.textBoxStopStep_ZAA.Text = "5";
            // 
            // labelStopStep_ZAA
            // 
            this.labelStopStep_ZAA.AutoSize = true;
            this.labelStopStep_ZAA.Location = new System.Drawing.Point(160, 22);
            this.labelStopStep_ZAA.Name = "labelStopStep_ZAA";
            this.labelStopStep_ZAA.Size = new System.Drawing.Size(108, 20);
            this.labelStopStep_ZAA.TabIndex = 2;
            this.labelStopStep_ZAA.Text = "Конец шага:";
            // 
            // textBoxStartStep_ZAA
            // 
            this.textBoxStartStep_ZAA.Location = new System.Drawing.Point(12, 47);
            this.textBoxStartStep_ZAA.Name = "textBoxStartStep_ZAA";
            this.textBoxStartStep_ZAA.Size = new System.Drawing.Size(131, 27);
            this.textBoxStartStep_ZAA.TabIndex = 1;
            this.textBoxStartStep_ZAA.Text = "-5";
            // 
            // labelStartStep_ZAA
            // 
            this.labelStartStep_ZAA.AutoSize = true;
            this.labelStartStep_ZAA.Location = new System.Drawing.Point(9, 22);
            this.labelStartStep_ZAA.Name = "labelStartStep_ZAA";
            this.labelStartStep_ZAA.Size = new System.Drawing.Size(108, 20);
            this.labelStartStep_ZAA.TabIndex = 0;
            this.labelStartStep_ZAA.Text = "Старт шага:";
            // 
            // buttonHelp_ZAA
            // 
            this.buttonHelp_ZAA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_ZAA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_ZAA.Location = new System.Drawing.Point(325, 394);
            this.buttonHelp_ZAA.Name = "buttonHelp_ZAA";
            this.buttonHelp_ZAA.Size = new System.Drawing.Size(111, 112);
            this.buttonHelp_ZAA.TabIndex = 3;
            this.buttonHelp_ZAA.Text = "Справка";
            this.buttonHelp_ZAA.UseVisualStyleBackColor = false;
            this.buttonHelp_ZAA.Click += new System.EventHandler(this.buttonHelp_ZAA_Click);
            // 
            // buttonDone_ZAA
            // 
            this.buttonDone_ZAA.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_ZAA.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_ZAA.Location = new System.Drawing.Point(433, 394);
            this.buttonDone_ZAA.Name = "buttonDone_ZAA";
            this.buttonDone_ZAA.Size = new System.Drawing.Size(213, 112);
            this.buttonDone_ZAA.TabIndex = 4;
            this.buttonDone_ZAA.Text = "Выполнить";
            this.buttonDone_ZAA.UseVisualStyleBackColor = false;
            this.buttonDone_ZAA.Click += new System.EventHandler(this.buttonDone_ZAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 518);
            this.Controls.Add(this.buttonDone_ZAA);
            this.Controls.Add(this.buttonHelp_ZAA);
            this.Controls.Add(this.groupBoxInputData_ZAA);
            this.Controls.Add(this.groupBoxOutputData_ZAA);
            this.Controls.Add(this.groupBoxCondition_ZAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 29 | Жданова А. А.";
            this.groupBoxCondition_ZAA.ResumeLayout(false);
            this.groupBoxCondition_ZAA.PerformLayout();
            this.groupBoxOutputData_ZAA.ResumeLayout(false);
            this.groupBoxOutputData_ZAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ZAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZAA)).EndInit();
            this.groupBoxInputData_ZAA.ResumeLayout(false);
            this.groupBoxInputData_ZAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_ZAA;
        private System.Windows.Forms.Label labelCondition_ZAA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZAA;
        private System.Windows.Forms.Label labelResult_ZAA;
        private System.Windows.Forms.GroupBox groupBoxInputData_ZAA;
        private System.Windows.Forms.TextBox textBoxStopStep_ZAA;
        private System.Windows.Forms.Label labelStopStep_ZAA;
        private System.Windows.Forms.TextBox textBoxStartStep_ZAA;
        private System.Windows.Forms.Label labelStartStep_ZAA;
        private System.Windows.Forms.Button buttonHelp_ZAA;
        private System.Windows.Forms.Button buttonDone_ZAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZAA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_ZAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

