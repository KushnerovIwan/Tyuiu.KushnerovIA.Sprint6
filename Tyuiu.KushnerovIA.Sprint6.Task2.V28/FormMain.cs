using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KushnerovIA.Sprint6.Task2.V28.Lib;

namespace Tyuiu.KushnerovIA.Sprint6.Task2.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KIA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KIA.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KIA.Titles.Add("График функции");

                this.chartFunction_KIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KIA.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_KIA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_KIA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KIA_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Таск 2 выполнил студент группы ПКТб-23-2 Кушнеров Иван Антонович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void buttonDone_KIA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KIA.BackColor = Color.Red;
        }

        private void buttonDone_KIA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KIA.BackColor = Color.Green;
        }

        private void buttonDone_KIA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KIA.BackColor = Color.Blue;
        }
    }
}
        

       