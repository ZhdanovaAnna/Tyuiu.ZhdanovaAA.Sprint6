using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.ZhdanovaAA.Sprint6.Task5.V11.Lib;


namespace Tyuiu.ZhdanovaAA.Sprint6.Task5.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V11.txt";

        private void buttonDone_ZAA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewData_ZAA.ColumnCount = 2;
                dataGridViewData_ZAA.Columns[0].Width = 20;
                dataGridViewData_ZAA.Columns[1].Width = 90;

                this.chartDiagram_ZAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartDiagram_ZAA.ChartAreas[0].AxisY.Title = "Ось Y";

                chartDiagram_ZAA.Series[0].Points.Clear();

                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    this.chartDiagram_ZAA.Series[0].Points.AddXY(i, numsMass[i]);
                }
                this.dataGridViewData_ZAA.Rows.Clear();
                int k = 1;
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        this.dataGridViewData_ZAA.Rows.Add(k.ToString(), line);
                        k++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_ZAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = @"C:\DataSprint6\InPutFileTask5V11.txt";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_ZAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-1 Жданова Анна Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
