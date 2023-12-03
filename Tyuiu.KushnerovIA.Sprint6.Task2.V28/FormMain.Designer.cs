
namespace Tyuiu.KushnerovIA.Sprint6.Task2.V28
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition_KIA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_KIA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_KIA = new System.Windows.Forms.GroupBox();
            this.buttonHelp_KIA = new System.Windows.Forms.Button();
            this.buttonDone_KIA = new System.Windows.Forms.Button();
            this.textBoxCondition_KIA = new System.Windows.Forms.TextBox();
            this.labelStartStep_KIA = new System.Windows.Forms.Label();
            this.labelStopStep_KIA = new System.Windows.Forms.Label();
            this.textBoxStartStep_KIA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_KIA = new System.Windows.Forms.TextBox();
            this.labelResult_KIA = new System.Windows.Forms.Label();
            this.dataGridViewResult_KIA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_KIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition_KIA.SuspendLayout();
            this.groupBoxInPut_KIA.SuspendLayout();
            this.groupBoxOutPut_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KIA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KIA
            // 
            this.groupBoxCondition_KIA.Controls.Add(this.textBoxCondition_KIA);
            this.groupBoxCondition_KIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_KIA.Name = "groupBoxCondition_KIA";
            this.groupBoxCondition_KIA.Size = new System.Drawing.Size(532, 330);
            this.groupBoxCondition_KIA.TabIndex = 0;
            this.groupBoxCondition_KIA.TabStop = false;
            this.groupBoxCondition_KIA.Text = "Условие";
            // 
            // groupBoxInPut_KIA
            // 
            this.groupBoxInPut_KIA.Controls.Add(this.textBoxStopStep_KIA);
            this.groupBoxInPut_KIA.Controls.Add(this.textBoxStartStep_KIA);
            this.groupBoxInPut_KIA.Controls.Add(this.labelStopStep_KIA);
            this.groupBoxInPut_KIA.Controls.Add(this.labelStartStep_KIA);
            this.groupBoxInPut_KIA.Location = new System.Drawing.Point(13, 348);
            this.groupBoxInPut_KIA.Name = "groupBoxInPut_KIA";
            this.groupBoxInPut_KIA.Size = new System.Drawing.Size(314, 90);
            this.groupBoxInPut_KIA.TabIndex = 1;
            this.groupBoxInPut_KIA.TabStop = false;
            this.groupBoxInPut_KIA.Text = "Ввод данных";
            // 
            // groupBoxOutPut_KIA
            // 
            this.groupBoxOutPut_KIA.Controls.Add(this.chartFunction_KIA);
            this.groupBoxOutPut_KIA.Controls.Add(this.dataGridViewResult_KIA);
            this.groupBoxOutPut_KIA.Controls.Add(this.labelResult_KIA);
            this.groupBoxOutPut_KIA.Location = new System.Drawing.Point(551, 13);
            this.groupBoxOutPut_KIA.Name = "groupBoxOutPut_KIA";
            this.groupBoxOutPut_KIA.Size = new System.Drawing.Size(679, 425);
            this.groupBoxOutPut_KIA.TabIndex = 2;
            this.groupBoxOutPut_KIA.TabStop = false;
            this.groupBoxOutPut_KIA.Text = "Вывод данных";
            // 
            // buttonHelp_KIA
            // 
            this.buttonHelp_KIA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KIA.Location = new System.Drawing.Point(334, 348);
            this.buttonHelp_KIA.Name = "buttonHelp_KIA";
            this.buttonHelp_KIA.Size = new System.Drawing.Size(85, 90);
            this.buttonHelp_KIA.TabIndex = 3;
            this.buttonHelp_KIA.Text = "Справка";
            this.buttonHelp_KIA.UseVisualStyleBackColor = false;
            this.buttonHelp_KIA.Click += new System.EventHandler(this.buttonHelp_KIA_Click);
            // 
            // buttonDone_KIA
            // 
            this.buttonDone_KIA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KIA.Location = new System.Drawing.Point(426, 348);
            this.buttonDone_KIA.Name = "buttonDone_KIA";
            this.buttonDone_KIA.Size = new System.Drawing.Size(118, 90);
            this.buttonDone_KIA.TabIndex = 4;
            this.buttonDone_KIA.Text = "Выполнить";
            this.buttonDone_KIA.UseVisualStyleBackColor = false;
            this.buttonDone_KIA.Click += new System.EventHandler(this.buttonDone_KIA_Click);
            this.buttonDone_KIA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_KIA_MouseDown);
            this.buttonDone_KIA.MouseEnter += new System.EventHandler(this.buttonDone_KIA_MouseEnter);
            this.buttonDone_KIA.MouseLeave += new System.EventHandler(this.buttonDone_KIA_MouseLeave);
            // 
            // textBoxCondition_KIA
            // 
            this.textBoxCondition_KIA.Location = new System.Drawing.Point(7, 22);
            this.textBoxCondition_KIA.Multiline = true;
            this.textBoxCondition_KIA.Name = "textBoxCondition_KIA";
            this.textBoxCondition_KIA.ReadOnly = true;
            this.textBoxCondition_KIA.Size = new System.Drawing.Size(519, 302);
            this.textBoxCondition_KIA.TabIndex = 0;
            this.textBoxCondition_KIA.Text = "Протабулировать функцию (sin(x)-2x)/(3x-1)+sin(x)-3x+2 на заданном диапазоне.\r\nРе" +
    "зультат вывести в DataGridView и построить график функции.";
            // 
            // labelStartStep_KIA
            // 
            this.labelStartStep_KIA.AutoSize = true;
            this.labelStartStep_KIA.Location = new System.Drawing.Point(7, 22);
            this.labelStartStep_KIA.Name = "labelStartStep_KIA";
            this.labelStartStep_KIA.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_KIA.TabIndex = 0;
            this.labelStartStep_KIA.Text = "Старт шага:";
            // 
            // labelStopStep_KIA
            // 
            this.labelStopStep_KIA.AutoSize = true;
            this.labelStopStep_KIA.Location = new System.Drawing.Point(165, 22);
            this.labelStopStep_KIA.Name = "labelStopStep_KIA";
            this.labelStopStep_KIA.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_KIA.TabIndex = 1;
            this.labelStopStep_KIA.Text = "Конец шага:";
            // 
            // textBoxStartStep_KIA
            // 
            this.textBoxStartStep_KIA.Location = new System.Drawing.Point(7, 42);
            this.textBoxStartStep_KIA.Name = "textBoxStartStep_KIA";
            this.textBoxStartStep_KIA.Size = new System.Drawing.Size(126, 22);
            this.textBoxStartStep_KIA.TabIndex = 2;
            // 
            // textBoxStopStep_KIA
            // 
            this.textBoxStopStep_KIA.Location = new System.Drawing.Point(168, 42);
            this.textBoxStopStep_KIA.Name = "textBoxStopStep_KIA";
            this.textBoxStopStep_KIA.Size = new System.Drawing.Size(120, 22);
            this.textBoxStopStep_KIA.TabIndex = 3;
            // 
            // labelResult_KIA
            // 
            this.labelResult_KIA.AutoSize = true;
            this.labelResult_KIA.Location = new System.Drawing.Point(7, 22);
            this.labelResult_KIA.Name = "labelResult_KIA";
            this.labelResult_KIA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_KIA.TabIndex = 0;
            this.labelResult_KIA.Text = "Результат:";
            // 
            // dataGridViewResult_KIA
            // 
            this.dataGridViewResult_KIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewResult_KIA.Location = new System.Drawing.Point(7, 43);
            this.dataGridViewResult_KIA.Name = "dataGridViewResult_KIA";
            this.dataGridViewResult_KIA.RowHeadersVisible = false;
            this.dataGridViewResult_KIA.RowHeadersWidth = 51;
            this.dataGridViewResult_KIA.RowTemplate.Height = 24;
            this.dataGridViewResult_KIA.Size = new System.Drawing.Size(135, 376);
            this.dataGridViewResult_KIA.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // chartFunction_KIA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KIA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_KIA.Legends.Add(legend1);
            this.chartFunction_KIA.Location = new System.Drawing.Point(149, 43);
            this.chartFunction_KIA.Name = "chartFunction_KIA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KIA.Series.Add(series1);
            this.chartFunction_KIA.Size = new System.Drawing.Size(524, 376);
            this.chartFunction_KIA.TabIndex = 2;
            this.chartFunction_KIA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 450);
            this.Controls.Add(this.buttonDone_KIA);
            this.Controls.Add(this.buttonHelp_KIA);
            this.Controls.Add(this.groupBoxOutPut_KIA);
            this.Controls.Add(this.groupBoxInPut_KIA);
            this.Controls.Add(this.groupBoxCondition_KIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 28 | Кушнеров И. А.";
            this.groupBoxCondition_KIA.ResumeLayout(false);
            this.groupBoxCondition_KIA.PerformLayout();
            this.groupBoxInPut_KIA.ResumeLayout(false);
            this.groupBoxInPut_KIA.PerformLayout();
            this.groupBoxOutPut_KIA.ResumeLayout(false);
            this.groupBoxOutPut_KIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_KIA;
        private System.Windows.Forms.GroupBox groupBoxInPut_KIA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KIA;
        private System.Windows.Forms.Button buttonHelp_KIA;
        private System.Windows.Forms.Button buttonDone_KIA;
        private System.Windows.Forms.TextBox textBoxCondition_KIA;
        private System.Windows.Forms.TextBox textBoxStopStep_KIA;
        private System.Windows.Forms.TextBox textBoxStartStep_KIA;
        private System.Windows.Forms.Label labelStopStep_KIA;
        private System.Windows.Forms.Label labelStartStep_KIA;
        private System.Windows.Forms.Label labelResult_KIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KIA;
        private System.Windows.Forms.DataGridView dataGridViewResult_KIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

