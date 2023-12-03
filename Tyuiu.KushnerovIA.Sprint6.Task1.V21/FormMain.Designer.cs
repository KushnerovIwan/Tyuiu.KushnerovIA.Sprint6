
namespace Tyuiu.KushnerovIA.Sprint6.Task1.V21
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
            this.groupBoxCondition_KIA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_KIA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_KIA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KIA = new System.Windows.Forms.TextBox();
            this.labelResult_KIA = new System.Windows.Forms.Label();
            this.groupBoxInPut_KIA = new System.Windows.Forms.GroupBox();
            this.textBoxEndStep_KIA = new System.Windows.Forms.TextBox();
            this.labelEndStep_KIA = new System.Windows.Forms.Label();
            this.textBoxStartStep_KIA = new System.Windows.Forms.TextBox();
            this.labelStartStep_KIA = new System.Windows.Forms.Label();
            this.buttonDone_KIA = new System.Windows.Forms.Button();
            this.buttonHelp_KIA = new System.Windows.Forms.Button();
            this.groupBoxCondition_KIA.SuspendLayout();
            this.groupBoxOutPut_KIA.SuspendLayout();
            this.groupBoxInPut_KIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KIA
            // 
            this.groupBoxCondition_KIA.Controls.Add(this.textBoxCondition_KIA);
            this.groupBoxCondition_KIA.Location = new System.Drawing.Point(11, 12);
            this.groupBoxCondition_KIA.Name = "groupBoxCondition_KIA";
            this.groupBoxCondition_KIA.Size = new System.Drawing.Size(430, 297);
            this.groupBoxCondition_KIA.TabIndex = 0;
            this.groupBoxCondition_KIA.TabStop = false;
            this.groupBoxCondition_KIA.Text = "Условие";
            // 
            // textBoxCondition_KIA
            // 
            this.textBoxCondition_KIA.Location = new System.Drawing.Point(6, 21);
            this.textBoxCondition_KIA.Multiline = true;
            this.textBoxCondition_KIA.Name = "textBoxCondition_KIA";
            this.textBoxCondition_KIA.ReadOnly = true;
            this.textBoxCondition_KIA.Size = new System.Drawing.Size(420, 271);
            this.textBoxCondition_KIA.TabIndex = 0;
            this.textBoxCondition_KIA.Text = "Протабулировать функцию cos(x)+sin(x)/(2-2x)-4x на заданном диапазоне.\r\nРезультат" +
    " вывести в виде таблицы.";
            // 
            // groupBoxOutPut_KIA
            // 
            this.groupBoxOutPut_KIA.Controls.Add(this.textBoxResult_KIA);
            this.groupBoxOutPut_KIA.Controls.Add(this.labelResult_KIA);
            this.groupBoxOutPut_KIA.Location = new System.Drawing.Point(463, 12);
            this.groupBoxOutPut_KIA.Name = "groupBoxOutPut_KIA";
            this.groupBoxOutPut_KIA.Size = new System.Drawing.Size(227, 382);
            this.groupBoxOutPut_KIA.TabIndex = 1;
            this.groupBoxOutPut_KIA.TabStop = false;
            this.groupBoxOutPut_KIA.Text = "Вывод данных";
            // 
            // textBoxResult_KIA
            // 
            this.textBoxResult_KIA.Location = new System.Drawing.Point(9, 40);
            this.textBoxResult_KIA.Multiline = true;
            this.textBoxResult_KIA.Name = "textBoxResult_KIA";
            this.textBoxResult_KIA.ReadOnly = true;
            this.textBoxResult_KIA.Size = new System.Drawing.Size(213, 328);
            this.textBoxResult_KIA.TabIndex = 1;
            // 
            // labelResult_KIA
            // 
            this.labelResult_KIA.AutoSize = true;
            this.labelResult_KIA.Location = new System.Drawing.Point(6, 21);
            this.labelResult_KIA.Name = "labelResult_KIA";
            this.labelResult_KIA.Size = new System.Drawing.Size(88, 17);
            this.labelResult_KIA.TabIndex = 0;
            this.labelResult_KIA.Text = "Результат:";
            // 
            // groupBoxInPut_KIA
            // 
            this.groupBoxInPut_KIA.Controls.Add(this.textBoxEndStep_KIA);
            this.groupBoxInPut_KIA.Controls.Add(this.labelEndStep_KIA);
            this.groupBoxInPut_KIA.Controls.Add(this.textBoxStartStep_KIA);
            this.groupBoxInPut_KIA.Controls.Add(this.labelStartStep_KIA);
            this.groupBoxInPut_KIA.Location = new System.Drawing.Point(11, 315);
            this.groupBoxInPut_KIA.Name = "groupBoxInPut_KIA";
            this.groupBoxInPut_KIA.Size = new System.Drawing.Size(238, 79);
            this.groupBoxInPut_KIA.TabIndex = 2;
            this.groupBoxInPut_KIA.TabStop = false;
            this.groupBoxInPut_KIA.Text = "Ввод данных";
            // 
            // textBoxEndStep_KIA
            // 
            this.textBoxEndStep_KIA.Location = new System.Drawing.Point(119, 45);
            this.textBoxEndStep_KIA.Name = "textBoxEndStep_KIA";
            this.textBoxEndStep_KIA.Size = new System.Drawing.Size(100, 23);
            this.textBoxEndStep_KIA.TabIndex = 3;
            // 
            // labelEndStep_KIA
            // 
            this.labelEndStep_KIA.AutoSize = true;
            this.labelEndStep_KIA.Location = new System.Drawing.Point(116, 25);
            this.labelEndStep_KIA.Name = "labelEndStep_KIA";
            this.labelEndStep_KIA.Size = new System.Drawing.Size(96, 17);
            this.labelEndStep_KIA.TabIndex = 2;
            this.labelEndStep_KIA.Text = "Конец шага:";
            // 
            // textBoxStartStep_KIA
            // 
            this.textBoxStartStep_KIA.Location = new System.Drawing.Point(6, 45);
            this.textBoxStartStep_KIA.Name = "textBoxStartStep_KIA";
            this.textBoxStartStep_KIA.Size = new System.Drawing.Size(99, 23);
            this.textBoxStartStep_KIA.TabIndex = 1;
            // 
            // labelStartStep_KIA
            // 
            this.labelStartStep_KIA.AutoSize = true;
            this.labelStartStep_KIA.Location = new System.Drawing.Point(5, 25);
            this.labelStartStep_KIA.Name = "labelStartStep_KIA";
            this.labelStartStep_KIA.Size = new System.Drawing.Size(96, 17);
            this.labelStartStep_KIA.TabIndex = 0;
            this.labelStartStep_KIA.Text = "Старт шага:";
            // 
            // buttonDone_KIA
            // 
            this.buttonDone_KIA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KIA.Location = new System.Drawing.Point(346, 315);
            this.buttonDone_KIA.Name = "buttonDone_KIA";
            this.buttonDone_KIA.Size = new System.Drawing.Size(96, 79);
            this.buttonDone_KIA.TabIndex = 3;
            this.buttonDone_KIA.Text = "Выполнить";
            this.buttonDone_KIA.UseVisualStyleBackColor = false;
            this.buttonDone_KIA.Click += new System.EventHandler(this.buttonDone_KIA_Click);
            // 
            // buttonHelp_KIA
            // 
            this.buttonHelp_KIA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KIA.Location = new System.Drawing.Point(256, 316);
            this.buttonHelp_KIA.Name = "buttonHelp_KIA";
            this.buttonHelp_KIA.Size = new System.Drawing.Size(85, 78);
            this.buttonHelp_KIA.TabIndex = 4;
            this.buttonHelp_KIA.Text = "Справка";
            this.buttonHelp_KIA.UseVisualStyleBackColor = false;
            this.buttonHelp_KIA.Click += new System.EventHandler(this.buttonHelp_KIA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.buttonHelp_KIA);
            this.Controls.Add(this.buttonDone_KIA);
            this.Controls.Add(this.groupBoxInPut_KIA);
            this.Controls.Add(this.groupBoxOutPut_KIA);
            this.Controls.Add(this.groupBoxCondition_KIA);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 21 | Кушнеров И. А.";
            this.groupBoxCondition_KIA.ResumeLayout(false);
            this.groupBoxCondition_KIA.PerformLayout();
            this.groupBoxOutPut_KIA.ResumeLayout(false);
            this.groupBoxOutPut_KIA.PerformLayout();
            this.groupBoxInPut_KIA.ResumeLayout(false);
            this.groupBoxInPut_KIA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_KIA;
        private System.Windows.Forms.TextBox textBoxCondition_KIA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KIA;
        private System.Windows.Forms.Label labelResult_KIA;
        private System.Windows.Forms.GroupBox groupBoxInPut_KIA;
        private System.Windows.Forms.TextBox textBoxEndStep_KIA;
        private System.Windows.Forms.Label labelEndStep_KIA;
        private System.Windows.Forms.TextBox textBoxStartStep_KIA;
        private System.Windows.Forms.Label labelStartStep_KIA;
        private System.Windows.Forms.Button buttonDone_KIA;
        private System.Windows.Forms.Button buttonHelp_KIA;
        private System.Windows.Forms.TextBox textBoxResult_KIA;
    }
}

