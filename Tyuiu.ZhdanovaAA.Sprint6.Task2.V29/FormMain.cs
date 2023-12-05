using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZhdanovaAA.Sprint6.Task2.V29.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint6.Task2.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.chartFunction_ZAA.Titles.Add("График функции f(x)");
        }

        DataService ds = new DataService();
        private void buttonDone_ZAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_ZAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_ZAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_ZAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ZAA.ChartAreas[0].AxisY.Title = "Ось Y";

                this.dataGridViewFunction_ZAA.Rows.Clear();
                this.chartFunction_ZAA.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_ZAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.dataGridViewFunction_ZAA.Rows[i].Height = 30;
                    this.chartFunction_ZAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-23-1 Жданова Анна Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
