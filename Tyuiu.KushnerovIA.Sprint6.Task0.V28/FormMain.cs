using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KushnerovIA.Sprint6.Task0.V28.Lib;
using System.Windows.Forms;

namespace Tyuiu.KushnerovIA.Sprint6.Task0.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBoxFormula_KIA_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KIA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KIA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТб-23-2 Кушнеров Иван Антонович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxVarX_KIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
