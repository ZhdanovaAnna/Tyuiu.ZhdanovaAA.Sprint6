using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZhdanovaAA.Sprint6.Task1.V18.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint6.Task1.V18
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
                int startStep = Convert.ToInt32(textBoxStartStep_ZAA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_ZAA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_ZAA.Text = "";
                textBoxResult_ZAA.AppendText("+-------------+---------------+" + Environment.NewLine);
                textBoxResult_ZAA.AppendText("|      X      |      f(x)     |" + Environment.NewLine);
                textBoxResult_ZAA.AppendText("+-------------+---------------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("| {0,6:d}      |   {1,7:f2}     |", startStep, valueArray[i]);
                    textBoxResult_ZAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_ZAA.AppendText("+--------------+--------------+" + Environment.NewLine);
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        
        private void textBoxStartStep_ZAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void textBoxStopStep_ZAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_ZAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-23-1 Жданова Анна Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
