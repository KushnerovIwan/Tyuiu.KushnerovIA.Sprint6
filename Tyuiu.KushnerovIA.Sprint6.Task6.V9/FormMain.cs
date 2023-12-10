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
using Tyuiu.KushnerovIA.Sprint6.Task6.V9.Lib;

namespace Tyuiu.KushnerovIA.Sprint6.Task6.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path;
        private void buttonOpenFile_KIA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KIA.ShowDialog();
            path = openFileDialogTask_KIA.FileName;
            textBoxInPut_KIA.Text = File.ReadAllText(path);
            groupBoxInPut_KIA.Text = groupBoxInPut_KIA.Text + " " + openFileDialogTask_KIA.FileName;
            buttonDone_KIA.Enabled = true;
        }

        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            textBoxOutPut_KIA.Text = ds.CollectTextFromFile(path);
        }

        private void buttonInfo_KIA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonOpenFile_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonDone_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDone_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonInfo_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonInfo_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
