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
using Tyuiu.ZhdanovaAA.Sprint6.Task7.V22.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint6.Task7.V22
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_ZAA.Filter = "CSV|*.csv";

        }

        private void buttonOpen_ZAA_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog_ZAA.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(openFileDialog_ZAA.FileName))
                    {
                        dataGridViewIn_ZAA.Rows.Clear();
                        dataGridViewIn_ZAA.Columns.Clear();
                        string line;
                        while ((line = reader.ReadLine()) != null && line != "")
                        {
                            if (dataGridViewIn_ZAA.Columns.Count == 0)
                            {
                                dataGridViewIn_ZAA.ColumnCount = line.Split(';').Length;
                            }
                            dataGridViewIn_ZAA.Rows.Add(line.Split(';'));
                        }
                    }
                    buttonDone_ZAA.Enabled = true;
                }
            }
            catch
            {
                dataGridViewIn_ZAA.Columns.Clear();
                buttonDone_ZAA.Enabled = buttonSave_ZAA.Enabled = false;
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonDone_ZAA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOut_ZAA.Rows.Clear();
                int[,] mtrx = ds.GetMatrix(openFileDialog_ZAA.FileName);
                int rows = mtrx.GetUpperBound(0) + 1;
                int columns = mtrx.Length / rows;

                dataGridViewOut_ZAA.ColumnCount = columns;
                dataGridViewOut_ZAA.RowCount = rows;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOut_ZAA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                    }
                }

                buttonSave_ZAA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewOut_ZAA.Rows.Clear();
                buttonSave_ZAA.Enabled = false;

            }

        }

        private void buttonSave_ZAA_Click(object sender, EventArgs e)
        {
            saveFileDialog_ZAA.FileName = "OutPutFileTask7.csv";
            saveFileDialog_ZAA.Filter = "CSV|*.csv";
            if (saveFileDialog_ZAA.ShowDialog() == DialogResult.OK)
            {
                int rows = dataGridViewOut_ZAA.RowCount;
                int columns = dataGridViewOut_ZAA.ColumnCount;

                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewOut_ZAA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewOut_ZAA.Rows[i].Cells[j].Value;
                        }
                    }
                    str += Environment.NewLine;
                }
                File.WriteAllText(saveFileDialog_ZAA.FileName, str);
                MessageBox.Show("Файл успешно сохранен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonHelp_ZAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
