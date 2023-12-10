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
using Tyuiu.KushnerovIA.Sprint6.Task7.V25.Lib;

namespace Tyuiu.KushnerovIA.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KIA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogTask_KIA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }
        private void buttonOpenFile_KIA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KIA.ShowDialog();
            openFile = openFileDialogTask_KIA.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewIn_KIA.RowCount = rows;
            dataGridViewIn_KIA.ColumnCount = columns;
            dataGridViewOut_KIA.RowCount = rows;
            dataGridViewOut_KIA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KIA.Columns[i].Width = 50;
                dataGridViewOut_KIA.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_KIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_KIA.Enabled = true;

        }

        private void buttonSaveFile_KIA_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_KIA.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_KIA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_KIA.ShowDialog();

            string path = saveFileDialogTask_KIA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_KIA.RowCount;
            int columns = dataGridViewOut_KIA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut_KIA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewIn_KIA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_KIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_KIA.Enabled = true;
        }

        private void buttonOpenFile_KIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_KIA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_KIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_KIA.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_KIA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonInfo_KIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipTask_KIA.ToolTipTitle = "Справка";

        }

        private void buttonInfo_KIA_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonOpenFile_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonOpenFile_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonDone_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDone_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonSaveFile_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonSaveFile_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void buttonInfo_KIA_MouseMove(object sender, MouseEventArgs e)
        {
            buttonInfo_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_KIA.RowCount = 50;
            dataGridViewOut_KIA.RowCount = 50;

            dataGridViewIn_KIA.ColumnCount = 50;
            dataGridViewOut_KIA.ColumnCount = 50;

            panelOutPut_KIA.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_KIA.Columns[i].Width = 25;
                dataGridViewOut_KIA.Columns[i].Width = 25;
            }
        }
    }
}
