namespace Menu
{
    partial class fmImage2
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
            this.btnVivod = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnZagr = new System.Windows.Forms.Button();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVivod
            // 
            this.btnVivod.Location = new System.Drawing.Point(238, 213);
            this.btnVivod.Name = "btnVivod";
            this.btnVivod.Size = new System.Drawing.Size(106, 29);
            this.btnVivod.TabIndex = 9;
            this.btnVivod.Text = "Вывод";
            this.btnVivod.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 212);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(202, 20);
            this.tbName.TabIndex = 8;
            // 
            // btnZagr
            // 
            this.btnZagr.Location = new System.Drawing.Point(238, 177);
            this.btnZagr.Name = "btnZagr";
            this.btnZagr.Size = new System.Drawing.Size(106, 29);
            this.btnZagr.TabIndex = 7;
            this.btnZagr.Text = "Загрузка";
            this.btnZagr.UseVisualStyleBackColor = true;
            this.btnZagr.Click += new System.EventHandler(this.btnZagr_Click);
            // 
            // tbImage
            // 
            this.tbImage.Location = new System.Drawing.Point(12, 177);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(202, 20);
            this.tbImage.TabIndex = 6;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(202, 146);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fmImage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 294);
            this.Controls.Add(this.btnVivod);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnZagr);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.pbImage);
            this.Name = "fmImage2";
            this.Text = "fmImage2";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVivod;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnZagr;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}