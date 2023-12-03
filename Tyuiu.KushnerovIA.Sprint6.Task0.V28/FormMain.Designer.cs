
namespace Tyuiu.KushnerovIA.Sprint6.Task0.V28
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition_KIA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_KIA = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_KIA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_KIA = new System.Windows.Forms.GroupBox();
            this.labelVarX_KIA = new System.Windows.Forms.Label();
            this.textBoxVarX_KIA = new System.Windows.Forms.TextBox();
            this.groupOutPut_KIA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KIA = new System.Windows.Forms.TextBox();
            this.labelResult_KIA = new System.Windows.Forms.Label();
            this.buttonDone_KIA = new System.Windows.Forms.Button();
            this.buttonHelp_KIA = new System.Windows.Forms.Button();
            this.groupBoxCondition_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KIA)).BeginInit();
            this.groupBoxInPut_KIA.SuspendLayout();
            this.groupOutPut_KIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_KIA
            // 
            this.groupBoxCondition_KIA.Controls.Add(this.pictureBoxFormula_KIA);
            this.groupBoxCondition_KIA.Controls.Add(this.textBoxCondition_KIA);
            this.groupBoxCondition_KIA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_KIA.Name = "groupBoxCondition_KIA";
            this.groupBoxCondition_KIA.Size = new System.Drawing.Size(775, 236);
            this.groupBoxCondition_KIA.TabIndex = 0;
            this.groupBoxCondition_KIA.TabStop = false;
            this.groupBoxCondition_KIA.Text = "Условие";
            // 
            // pictureBoxFormula_KIA
            // 
            this.pictureBoxFormula_KIA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KIA.Image")));
            this.pictureBoxFormula_KIA.Location = new System.Drawing.Point(6, 124);
            this.pictureBoxFormula_KIA.Name = "pictureBoxFormula_KIA";
            this.pictureBoxFormula_KIA.Size = new System.Drawing.Size(629, 42);
            this.pictureBoxFormula_KIA.TabIndex = 1;
            this.pictureBoxFormula_KIA.TabStop = false;
            this.pictureBoxFormula_KIA.Click += new System.EventHandler(this.pictureBoxFormula_KIA_Click);
            // 
            // textBoxCondition_KIA
            // 
            this.textBoxCondition_KIA.Location = new System.Drawing.Point(6, 22);
            this.textBoxCondition_KIA.Multiline = true;
            this.textBoxCondition_KIA.Name = "textBoxCondition_KIA";
            this.textBoxCondition_KIA.ReadOnly = true;
            this.textBoxCondition_KIA.Size = new System.Drawing.Size(624, 96);
            this.textBoxCondition_KIA.TabIndex = 0;
            this.textBoxCondition_KIA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInPut_KIA
            // 
            this.groupBoxInPut_KIA.Controls.Add(this.labelVarX_KIA);
            this.groupBoxInPut_KIA.Controls.Add(this.textBoxVarX_KIA);
            this.groupBoxInPut_KIA.Location = new System.Drawing.Point(13, 265);
            this.groupBoxInPut_KIA.Name = "groupBoxInPut_KIA";
            this.groupBoxInPut_KIA.Size = new System.Drawing.Size(475, 120);
            this.groupBoxInPut_KIA.TabIndex = 1;
            this.groupBoxInPut_KIA.TabStop = false;
            this.groupBoxInPut_KIA.Text = "Ввод данных";
            // 
            // labelVarX_KIA
            // 
            this.labelVarX_KIA.AutoSize = true;
            this.labelVarX_KIA.Location = new System.Drawing.Point(7, 37);
            this.labelVarX_KIA.Name = "labelVarX_KIA";
            this.labelVarX_KIA.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_KIA.TabIndex = 1;
            this.labelVarX_KIA.Text = "Переменная X:";
            // 
            // textBoxVarX_KIA
            // 
            this.textBoxVarX_KIA.Location = new System.Drawing.Point(7, 60);
            this.textBoxVarX_KIA.Name = "textBoxVarX_KIA";
            this.textBoxVarX_KIA.Size = new System.Drawing.Size(108, 22);
            this.textBoxVarX_KIA.TabIndex = 0;
            this.textBoxVarX_KIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KIA_KeyPress);
            // 
            // groupOutPut_KIA
            // 
            this.groupOutPut_KIA.Controls.Add(this.textBoxResult_KIA);
            this.groupOutPut_KIA.Controls.Add(this.labelResult_KIA);
            this.groupOutPut_KIA.Location = new System.Drawing.Point(511, 265);
            this.groupOutPut_KIA.Name = "groupOutPut_KIA";
            this.groupOutPut_KIA.Size = new System.Drawing.Size(277, 120);
            this.groupOutPut_KIA.TabIndex = 2;
            this.groupOutPut_KIA.TabStop = false;
            this.groupOutPut_KIA.Text = "Вывод данных";
            // 
            // textBoxResult_KIA
            // 
            this.textBoxResult_KIA.Location = new System.Drawing.Point(19, 57);
            this.textBoxResult_KIA.Name = "textBoxResult_KIA";
            this.textBoxResult_KIA.ReadOnly = true;
            this.textBoxResult_KIA.Size = new System.Drawing.Size(252, 22);
            this.textBoxResult_KIA.TabIndex = 1;
            // 
            // labelResult_KIA
            // 
            this.labelResult_KIA.AutoSize = true;
            this.labelResult_KIA.Location = new System.Drawing.Point(16, 36);
            this.labelResult_KIA.Name = "labelResult_KIA";
            this.labelResult_KIA.Size = new System.Drawing.Size(80, 17);
            this.labelResult_KIA.TabIndex = 0;
            this.labelResult_KIA.Text = "Результат:";
            // 
            // buttonDone_KIA
            // 
            this.buttonDone_KIA.Location = new System.Drawing.Point(645, 392);
            this.buttonDone_KIA.Name = "buttonDone_KIA";
            this.buttonDone_KIA.Size = new System.Drawing.Size(143, 37);
            this.buttonDone_KIA.TabIndex = 3;
            this.buttonDone_KIA.Text = "Выполнить";
            this.buttonDone_KIA.UseVisualStyleBackColor = true;
            this.buttonDone_KIA.Click += new System.EventHandler(this.buttonDone_KIA_Click);
            // 
            // buttonHelp_KIA
            // 
            this.buttonHelp_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KIA.Location = new System.Drawing.Point(597, 391);
            this.buttonHelp_KIA.Name = "buttonHelp_KIA";
            this.buttonHelp_KIA.Size = new System.Drawing.Size(42, 36);
            this.buttonHelp_KIA.TabIndex = 4;
            this.buttonHelp_KIA.Text = "?";
            this.buttonHelp_KIA.UseVisualStyleBackColor = true;
            this.buttonHelp_KIA.Click += new System.EventHandler(this.buttonHelp_KIA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_KIA);
            this.Controls.Add(this.buttonDone_KIA);
            this.Controls.Add(this.groupOutPut_KIA);
            this.Controls.Add(this.groupBoxInPut_KIA);
            this.Controls.Add(this.groupBoxCondition_KIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 |  Таск 0 |  Вариант 28 | Кушнеров И. А.";
            this.groupBoxCondition_KIA.ResumeLayout(false);
            this.groupBoxCondition_KIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KIA)).EndInit();
            this.groupBoxInPut_KIA.ResumeLayout(false);
            this.groupBoxInPut_KIA.PerformLayout();
            this.groupOutPut_KIA.ResumeLayout(false);
            this.groupOutPut_KIA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_KIA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KIA;
        private System.Windows.Forms.TextBox textBoxCondition_KIA;
        private System.Windows.Forms.GroupBox groupBoxInPut_KIA;
        private System.Windows.Forms.GroupBox groupOutPut_KIA;
        private System.Windows.Forms.Label labelVarX_KIA;
        private System.Windows.Forms.TextBox textBoxVarX_KIA;
        private System.Windows.Forms.TextBox textBoxResult_KIA;
        private System.Windows.Forms.Label labelResult_KIA;
        private System.Windows.Forms.Button buttonDone_KIA;
        private System.Windows.Forms.Button buttonHelp_KIA;
    }
}

