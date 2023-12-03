using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KushnerovIA.Sprint6.Task3.V18.Lib;


namespace Tyuiu.KushnerovIA.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        DataService ds = new DataService();
        int[,] matrx = new int[5, 5] { {-19, -19, 1,  18,  7},
                                     { 5,   3,  -4,  -6, -12},
                                     {-15,   6,   2,   2, -14},
                                     {-9, -10,  15,  -5,  -6},
                                     { -13, -15,  -9,   7,   1}};

        private void buttonInfo_KIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-23-2 Кушнеров Иван Антонович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] matrx = new int[5, 5]{ {-19, -19, 1,  18,  7},
                                     { 5,   3,  -4,  -6, -12},
                                     {-15,   6,   2,   2, -14},
                                     {-9, -10,  15,  -5,  -6},
                                     { -13, -15,  -9,   7,   1}};
            int[,] mtrx = ds.Calculate(matrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_KIA.ColumnCount = columns;
            dataGridViewResult_KIA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_KIA.Columns[i].Width = 25;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_KIA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrx.GetUpperBound(0) + 1;
            int columns = matrx.Length / rows;

            dataGridViewInPut_KIA.ColumnCount = columns;
            dataGridViewInPut_KIA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_KIA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPut_KIA.Rows[i].Cells[j].Value = Convert.ToString(matrx[i, j]);
                }
            }

        }
    }
}
