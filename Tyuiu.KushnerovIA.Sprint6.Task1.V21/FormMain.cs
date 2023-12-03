using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KushnerovIA.Sprint6.Task1.V21.Lib;
namespace Tyuiu.KushnerovIA.Sprint6.Task1.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_KIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-23-2 Кушнеров Иван Антонович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataService ds = new DataService();
        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KIA.Text);
                int stopStep = Convert.ToInt32(textBoxEndStep_KIA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KIA.Text = "";
                textBoxResult_KIA.AppendText("+----------+--------------+" + Environment.NewLine);
                textBoxResult_KIA.AppendText("|    X     |     f(x)     |" + Environment.NewLine);
                textBoxResult_KIA.AppendText("+----------+--------------+" + Environment.NewLine);

                for (int i = 0; i <= len -1 ; i++)
                {
                    strLine = String.Format("|{0,7:d}   |   {1,6:f2}     |", startStep, valueArray[i]);
                    textBoxResult_KIA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_KIA.AppendText("+----------+--------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
