
namespace Tyuiu.KushnerovIA.Sprint6.Task3.V18
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
            this.buttonDone_KIA = new System.Windows.Forms.Button();
            this.buttonInfo_KIA = new System.Windows.Forms.Button();
            this.groupBoxOutInput_KIA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_KIA = new System.Windows.Forms.DataGridView();
            this.labelResult_KIA = new System.Windows.Forms.Label();
            this.groupBoxCondition_KIA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_KIA = new System.Windows.Forms.DataGridView();
            this.textBoxCondition_KIA = new System.Windows.Forms.TextBox();
            this.groupBoxOutInput_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KIA)).BeginInit();
            this.groupBoxCondition_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KIA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_KIA
            // 
            this.buttonDone_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_KIA.Location = new System.Drawing.Point(899, 396);
            this.buttonDone_KIA.Name = "buttonDone_KIA";
            this.buttonDone_KIA.Size = new System.Drawing.Size(170, 42);
            this.buttonDone_KIA.TabIndex = 7;
            this.buttonDone_KIA.Text = "Выполнить";
            this.buttonDone_KIA.UseVisualStyleBackColor = true;
            this.buttonDone_KIA.Click += new System.EventHandler(this.buttonDone_KIA_Click);
            // 
            // buttonInfo_KIA
            // 
            this.buttonInfo_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_KIA.Location = new System.Drawing.Point(834, 396);
            this.buttonInfo_KIA.Name = "buttonInfo_KIA";
            this.buttonInfo_KIA.Size = new System.Drawing.Size(50, 42);
            this.buttonInfo_KIA.TabIndex = 6;
            this.buttonInfo_KIA.Text = "?";
            this.buttonInfo_KIA.UseVisualStyleBackColor = true;
            this.buttonInfo_KIA.Click += new System.EventHandler(this.buttonInfo_KIA_Click);
            // 
            // groupBoxOutInput_KIA
            // 
            this.groupBoxOutInput_KIA.Controls.Add(this.dataGridViewResult_KIA);
            this.groupBoxOutInput_KIA.Controls.Add(this.labelResult_KIA);
            this.groupBoxOutInput_KIA.Location = new System.Drawing.Point(834, 24);
            this.groupBoxOutInput_KIA.Name = "groupBoxOutInput_KIA";
            this.groupBoxOutInput_KIA.Size = new System.Drawing.Size(267, 366);
            this.groupBoxOutInput_KIA.TabIndex = 5;
            this.groupBoxOutInput_KIA.TabStop = false;
            this.groupBoxOutInput_KIA.Text = "Вывод данных";
            // 
            // dataGridViewResult_KIA
            // 
            this.dataGridViewResult_KIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KIA.ColumnHeadersVisible = false;
            this.dataGridViewResult_KIA.Location = new System.Drawing.Point(10, 55);
            this.dataGridViewResult_KIA.Name = "dataGridViewResult_KIA";
            this.dataGridViewResult_KIA.RowHeadersVisible = false;
            this.dataGridViewResult_KIA.RowHeadersWidth = 51;
            this.dataGridViewResult_KIA.RowTemplate.Height = 24;
            this.dataGridViewResult_KIA.Size = new System.Drawing.Size(240, 292);
            this.dataGridViewResult_KIA.TabIndex = 1;
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
            // groupBoxCondition_KIA
            // 
            this.groupBoxCondition_KIA.Controls.Add(this.dataGridViewInPut_KIA);
            this.groupBoxCondition_KIA.Controls.Add(this.textBoxCondition_KIA);
            this.groupBoxCondition_KIA.Location = new System.Drawing.Point(12, 13);
            this.groupBoxCondition_KIA.Name = "groupBoxCondition_KIA";
            this.groupBoxCondition_KIA.Size = new System.Drawing.Size(807, 425);
            this.groupBoxCondition_KIA.TabIndex = 4;
            this.groupBoxCondition_KIA.TabStop = false;
            this.groupBoxCondition_KIA.Text = "Условие";
            // 
            // dataGridViewInPut_KIA
            // 
            this.dataGridViewInPut_KIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_KIA.ColumnHeadersVisible = false;
            this.dataGridViewInPut_KIA.Location = new System.Drawing.Point(398, 22);
            this.dataGridViewInPut_KIA.Name = "dataGridViewInPut_KIA";
            this.dataGridViewInPut_KIA.RowHeadersVisible = false;
            this.dataGridViewInPut_KIA.RowHeadersWidth = 51;
            this.dataGridViewInPut_KIA.RowTemplate.Height = 24;
            this.dataGridViewInPut_KIA.Size = new System.Drawing.Size(409, 386);
            this.dataGridViewInPut_KIA.TabIndex = 1;
            // 
            // textBoxCondition_KIA
            // 
            this.textBoxCondition_KIA.Location = new System.Drawing.Point(6, 22);
            this.textBoxCondition_KIA.Multiline = true;
            this.textBoxCondition_KIA.Name = "textBoxCondition_KIA";
            this.textBoxCondition_KIA.ReadOnly = true;
            this.textBoxCondition_KIA.Size = new System.Drawing.Size(368, 386);
            this.textBoxCondition_KIA.TabIndex = 0;
            this.textBoxCondition_KIA.Text = resources.GetString("textBoxCondition_KIA.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.buttonDone_KIA);
            this.Controls.Add(this.buttonInfo_KIA);
            this.Controls.Add(this.groupBoxOutInput_KIA);
            this.Controls.Add(this.groupBoxCondition_KIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 18 | Кушнеров И. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOutInput_KIA.ResumeLayout(false);
            this.groupBoxOutInput_KIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KIA)).EndInit();
            this.groupBoxCondition_KIA.ResumeLayout(false);
            this.groupBoxCondition_KIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_KIA;
        private System.Windows.Forms.Button buttonInfo_KIA;
        private System.Windows.Forms.GroupBox groupBoxOutInput_KIA;
        private System.Windows.Forms.Label labelResult_KIA;
        private System.Windows.Forms.GroupBox groupBoxCondition_KIA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_KIA;
        private System.Windows.Forms.TextBox textBoxCondition_KIA;
        private System.Windows.Forms.DataGridView dataGridViewResult_KIA;
    }
}

