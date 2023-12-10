using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZhdanovaAA.Sprint6.Task4.V30.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint6.Task4.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_ZAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStartStep_ZAA.Text);
                int stoptStep = Convert.ToInt32(textBoxInputStopStep_ZAA.Text);

                int len = ds.GetMassFunction(startStep, stoptStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stoptStep);

                this.chartFunction_ZAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ZAA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_ZAA.Text = "";

                chartFunction_ZAA.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_ZAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_ZAA.AppendText(valueArray[i] + Environment.NewLine);
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
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-23-1 Жданова Анна Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_ZAA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V30.txt";
                File.WriteAllText(path, textBoxResult_ZAA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "OutPutFileTask4V30.txt";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
