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
using Tyuiu.KushnerovIA.Sprint6.Task4.V29.Lib;

namespace Tyuiu.KushnerovIA.Sprint6.Task4.V29
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
                int startValue = Convert.ToInt32(textBoxStartStep_KIA.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_KIA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_KIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KIA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPut_KIA.Text = "";
                chartFunction_KIA.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_KIA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxOutPut_KIA.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonInfo_KIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-23-2 Кушнеров Иван Антонович", "Сообщение");
        }

        private void buttonSave_KIA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V29.txt";
                File.WriteAllText(path, textBoxOutPut_KIA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonDone_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDone_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonSave_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonSave_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonInfo_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonInfo_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonDone_KIA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KIA.BackColor = Color.Blue;
        }

        private void buttonDone_KIA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KIA.BackColor = Color.Red;

        }

        private void buttonDone_KIA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KIA.BackColor = Color.Green;

        }
    }
}
