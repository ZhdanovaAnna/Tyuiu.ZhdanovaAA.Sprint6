using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZhdanovaAA.Sprint6.Task3.V30.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint6.Task3.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx =  new int[5, 5] { { -9, -4, 17, -1, -20},
                                                    { -19, 18, -4, 2, 14},
                                                    { -12, 16, -2, 7, 18},
                                                    { -16, 15, 4, -12, -13},
                                                    { -15, -4, -16, 1, -14} };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewOriginalMatrix_ZAA.ColumnCount = columns;
            dataGridViewOriginalMatrix_ZAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOriginalMatrix_ZAA.Columns[i].Width = 40;
                dataGridViewOriginalMatrix_ZAA.Rows[i].Height = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOriginalMatrix_ZAA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_ZAA_Click(object sender, EventArgs e)
        {
            int[,] resultmtrx = ds.Calculate(mtrx);
            int rows = resultmtrx.GetUpperBound(0) + 1;
            int columns = resultmtrx.Length / rows;

            dataGridViewResultMatrix_ZAA.ColumnCount = columns;
            dataGridViewResultMatrix_ZAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResultMatrix_ZAA.Columns[i].Width = 40;
                dataGridViewResultMatrix_ZAA.Rows[i].Height = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResultMatrix_ZAA.Rows[i].Cells[j].Value = Convert.ToString(resultmtrx[i, j]);
                }
            }
        }

        private void buttonHelp_ZAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-23-1 Жданова Анна Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
