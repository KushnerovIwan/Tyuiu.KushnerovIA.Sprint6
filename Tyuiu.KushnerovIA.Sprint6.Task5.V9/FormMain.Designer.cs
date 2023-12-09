
namespace Tyuiu.KushnerovIA.Sprint6.Task5.V9
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelCondition_KIA = new System.Windows.Forms.Panel();
            this.panelOutPut_KIA = new System.Windows.Forms.Panel();
            this.splitterOutPut_KIA = new System.Windows.Forms.Splitter();
            this.panelResult_KIA = new System.Windows.Forms.Panel();
            this.groupBoxCondition_KIA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_KIA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_KIA = new System.Windows.Forms.GroupBox();
            this.chartDiag_KIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewOutPut_KIA = new System.Windows.Forms.DataGridView();
            this.buttonDone_KIA = new System.Windows.Forms.Button();
            this.buttonOpenFile_KIA = new System.Windows.Forms.Button();
            this.buttonInfo_KIA = new System.Windows.Forms.Button();
            this.panelCondition_KIA.SuspendLayout();
            this.panelOutPut_KIA.SuspendLayout();
            this.panelResult_KIA.SuspendLayout();
            this.groupBoxCondition_KIA.SuspendLayout();
            this.groupBoxOutPut_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_KIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_KIA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCondition_KIA
            // 
            this.panelCondition_KIA.BackColor = System.Drawing.SystemColors.Control;
            this.panelCondition_KIA.Controls.Add(this.buttonInfo_KIA);
            this.panelCondition_KIA.Controls.Add(this.buttonOpenFile_KIA);
            this.panelCondition_KIA.Controls.Add(this.buttonDone_KIA);
            this.panelCondition_KIA.Controls.Add(this.groupBoxCondition_KIA);
            this.panelCondition_KIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition_KIA.Location = new System.Drawing.Point(0, 0);
            this.panelCondition_KIA.Name = "panelCondition_KIA";
            this.panelCondition_KIA.Size = new System.Drawing.Size(1032, 92);
            this.panelCondition_KIA.TabIndex = 0;
            // 
            // panelOutPut_KIA
            // 
            this.panelOutPut_KIA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelOutPut_KIA.Controls.Add(this.groupBoxOutPut_KIA);
            this.panelOutPut_KIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_KIA.Location = new System.Drawing.Point(0, 92);
            this.panelOutPut_KIA.Name = "panelOutPut_KIA";
            this.panelOutPut_KIA.Padding = new System.Windows.Forms.Padding(5);
            this.panelOutPut_KIA.Size = new System.Drawing.Size(205, 361);
            this.panelOutPut_KIA.TabIndex = 1;
            // 
            // splitterOutPut_KIA
            // 
            this.splitterOutPut_KIA.Location = new System.Drawing.Point(205, 92);
            this.splitterOutPut_KIA.Name = "splitterOutPut_KIA";
            this.splitterOutPut_KIA.Size = new System.Drawing.Size(3, 361);
            this.splitterOutPut_KIA.TabIndex = 2;
            this.splitterOutPut_KIA.TabStop = false;
            // 
            // panelResult_KIA
            // 
            this.panelResult_KIA.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelResult_KIA.Controls.Add(this.chartDiag_KIA);
            this.panelResult_KIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult_KIA.Location = new System.Drawing.Point(208, 92);
            this.panelResult_KIA.Name = "panelResult_KIA";
            this.panelResult_KIA.Size = new System.Drawing.Size(824, 361);
            this.panelResult_KIA.TabIndex = 3;
            // 
            // groupBoxCondition_KIA
            // 
            this.groupBoxCondition_KIA.Controls.Add(this.textBoxCondition_KIA);
            this.groupBoxCondition_KIA.Location = new System.Drawing.Point(4, 3);
            this.groupBoxCondition_KIA.Name = "groupBoxCondition_KIA";
            this.groupBoxCondition_KIA.Size = new System.Drawing.Size(560, 83);
            this.groupBoxCondition_KIA.TabIndex = 0;
            this.groupBoxCondition_KIA.TabStop = false;
            this.groupBoxCondition_KIA.Text = "Условие:";
            // 
            // textBoxCondition_KIA
            // 
            this.textBoxCondition_KIA.Location = new System.Drawing.Point(7, 22);
            this.textBoxCondition_KIA.Multiline = true;
            this.textBoxCondition_KIA.Name = "textBoxCondition_KIA";
            this.textBoxCondition_KIA.ReadOnly = true;
            this.textBoxCondition_KIA.Size = new System.Drawing.Size(535, 44);
            this.textBoxCondition_KIA.TabIndex = 0;
            this.textBoxCondition_KIA.Text = "Прочитать данные из файла InPutFileTask5V9.txt. Вывести в dataGridView все значен" +
    "ия, равные 0. Построить диаграмму по этим значениям.";
            // 
            // groupBoxOutPut_KIA
            // 
            this.groupBoxOutPut_KIA.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxOutPut_KIA.Controls.Add(this.dataGridViewOutPut_KIA);
            this.groupBoxOutPut_KIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_KIA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutPut_KIA.Name = "groupBoxOutPut_KIA";
            this.groupBoxOutPut_KIA.Size = new System.Drawing.Size(195, 351);
            this.groupBoxOutPut_KIA.TabIndex = 0;
            this.groupBoxOutPut_KIA.TabStop = false;
            this.groupBoxOutPut_KIA.Text = "Вывод данных:";
            // 
            // chartDiag_KIA
            // 
            this.chartDiag_KIA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chartDiag_KIA.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartDiag_KIA.Legends.Add(legend7);
            this.chartDiag_KIA.Location = new System.Drawing.Point(7, 7);
            this.chartDiag_KIA.Name = "chartDiag_KIA";
            this.chartDiag_KIA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series7.ChartArea = "ChartArea1";
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartDiag_KIA.Series.Add(series7);
            this.chartDiag_KIA.Size = new System.Drawing.Size(805, 342);
            this.chartDiag_KIA.TabIndex = 0;
            this.chartDiag_KIA.Text = "chart1";
            // 
            // dataGridViewOutPut_KIA
            // 
            this.dataGridViewOutPut_KIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_KIA.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_KIA.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewOutPut_KIA.Name = "dataGridViewOutPut_KIA";
            this.dataGridViewOutPut_KIA.ReadOnly = true;
            this.dataGridViewOutPut_KIA.RowHeadersVisible = false;
            this.dataGridViewOutPut_KIA.RowHeadersWidth = 51;
            this.dataGridViewOutPut_KIA.RowTemplate.Height = 24;
            this.dataGridViewOutPut_KIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPut_KIA.Size = new System.Drawing.Size(182, 322);
            this.dataGridViewOutPut_KIA.TabIndex = 0;
            // 
            // buttonDone_KIA
            // 
            this.buttonDone_KIA.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDone_KIA.Location = new System.Drawing.Point(570, 18);
            this.buttonDone_KIA.Name = "buttonDone_KIA";
            this.buttonDone_KIA.Size = new System.Drawing.Size(135, 57);
            this.buttonDone_KIA.TabIndex = 1;
            this.buttonDone_KIA.Text = "Выполнить";
            this.buttonDone_KIA.UseVisualStyleBackColor = false;
            this.buttonDone_KIA.Click += new System.EventHandler(this.buttonDone_KIA_Click);
            this.buttonDone_KIA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDone_KIA_MouseMove);
            // 
            // buttonOpenFile_KIA
            // 
            this.buttonOpenFile_KIA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenFile_KIA.Location = new System.Drawing.Point(720, 18);
            this.buttonOpenFile_KIA.Name = "buttonOpenFile_KIA";
            this.buttonOpenFile_KIA.Size = new System.Drawing.Size(132, 57);
            this.buttonOpenFile_KIA.TabIndex = 2;
            this.buttonOpenFile_KIA.Text = "Открыть файл";
            this.buttonOpenFile_KIA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_KIA.Click += new System.EventHandler(this.buttonOpenFile_KIA_Click);
            this.buttonOpenFile_KIA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonOpenFile_KIA_MouseMove);
            // 
            // buttonInfo_KIA
            // 
            this.buttonInfo_KIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_KIA.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonInfo_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_KIA.Location = new System.Drawing.Point(867, 18);
            this.buttonInfo_KIA.Name = "buttonInfo_KIA";
            this.buttonInfo_KIA.Size = new System.Drawing.Size(120, 57);
            this.buttonInfo_KIA.TabIndex = 3;
            this.buttonInfo_KIA.Text = "Справка";
            this.buttonInfo_KIA.UseVisualStyleBackColor = false;
            this.buttonInfo_KIA.Click += new System.EventHandler(this.buttonInfo_KIA_Click);
            this.buttonInfo_KIA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonInfo_KIA_MouseMove);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 453);
            this.Controls.Add(this.panelResult_KIA);
            this.Controls.Add(this.splitterOutPut_KIA);
            this.Controls.Add(this.panelOutPut_KIA);
            this.Controls.Add(this.panelCondition_KIA);
            this.MinimumSize = new System.Drawing.Size(1050, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 9 | Кушнеров И. А.";
            this.panelCondition_KIA.ResumeLayout(false);
            this.panelOutPut_KIA.ResumeLayout(false);
            this.panelResult_KIA.ResumeLayout(false);
            this.groupBoxCondition_KIA.ResumeLayout(false);
            this.groupBoxCondition_KIA.PerformLayout();
            this.groupBoxOutPut_KIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_KIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_KIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCondition_KIA;
        private System.Windows.Forms.Panel panelOutPut_KIA;
        private System.Windows.Forms.Splitter splitterOutPut_KIA;
        private System.Windows.Forms.Panel panelResult_KIA;
        private System.Windows.Forms.GroupBox groupBoxCondition_KIA;
        private System.Windows.Forms.TextBox textBoxCondition_KIA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_KIA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_KIA;
        private System.Windows.Forms.Button buttonInfo_KIA;
        private System.Windows.Forms.Button buttonOpenFile_KIA;
        private System.Windows.Forms.Button buttonDone_KIA;
    }
}

