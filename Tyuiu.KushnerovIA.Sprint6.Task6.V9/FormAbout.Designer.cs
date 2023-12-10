
namespace Tyuiu.KushnerovIA.Sprint6.Task6.V9
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_KIA = new System.Windows.Forms.PictureBox();
            this.labelInfo_KIA = new System.Windows.Forms.Label();
            this.buttonOk_KIA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KIA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_KIA
            // 
            this.pictureBoxAvatar_KIA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_KIA.Image")));
            this.pictureBoxAvatar_KIA.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_KIA.Name = "pictureBoxAvatar_KIA";
            this.pictureBoxAvatar_KIA.Size = new System.Drawing.Size(187, 247);
            this.pictureBoxAvatar_KIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_KIA.TabIndex = 0;
            this.pictureBoxAvatar_KIA.TabStop = false;
            // 
            // labelInfo_KIA
            // 
            this.labelInfo_KIA.AutoSize = true;
            this.labelInfo_KIA.Location = new System.Drawing.Point(207, 13);
            this.labelInfo_KIA.Name = "labelInfo_KIA";
            this.labelInfo_KIA.Size = new System.Drawing.Size(363, 102);
            this.labelInfo_KIA.TabIndex = 1;
            this.labelInfo_KIA.Text = resources.GetString("labelInfo_KIA.Text");
            // 
            // buttonOk_KIA
            // 
            this.buttonOk_KIA.Location = new System.Drawing.Point(473, 232);
            this.buttonOk_KIA.Name = "buttonOk_KIA";
            this.buttonOk_KIA.Size = new System.Drawing.Size(93, 28);
            this.buttonOk_KIA.TabIndex = 2;
            this.buttonOk_KIA.Text = "Ok";
            this.buttonOk_KIA.UseVisualStyleBackColor = true;
            this.buttonOk_KIA.Click += new System.EventHandler(this.buttonOk_KIA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 282);
            this.Controls.Add(this.buttonOk_KIA);
            this.Controls.Add(this.labelInfo_KIA);
            this.Controls.Add(this.pictureBoxAvatar_KIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(625, 329);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_KIA;
        private System.Windows.Forms.Label labelInfo_KIA;
        private System.Windows.Forms.Button buttonOk_KIA;
    }
}