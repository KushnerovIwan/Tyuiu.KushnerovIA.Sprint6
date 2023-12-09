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
using Tyuiu.KushnerovIA.Sprint6.Task5.V9.Lib;

namespace Tyuiu.KushnerovIA.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\kia45\source\repos\Tyuiu.KushnerovIA.Sprint6\Tyuiu.KushnerovIA.Sprint6.Task5.V9\bin\Debug\InPutFileTask5V9.txt";
        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_KIA.ColumnCount = 2;
            dataGridViewOutPut_KIA.Columns[0].Width = 20;
            dataGridViewOutPut_KIA.Columns[1].Width = 50;

            this.chartDiag_KIA.ChartAreas[0].AxisX.Title = " Ось X";
            this.chartDiag_KIA.ChartAreas[0].AxisY.Title = " Ось Y";

            chartDiag_KIA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPut_KIA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_KIA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_KIA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_KIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-2 Кушнеров Иван Антонович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonInfo_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonInfo_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonDone_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDone_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonOpenFile_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonOpenFile_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
