namespace Menu
{
    partial class fmImage
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.btnZagr = new System.Windows.Forms.Button();
            this.openPhotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnVivod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(21, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(202, 146);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // tbImage
            // 
            this.tbImage.Location = new System.Drawing.Point(21, 177);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(202, 29);
            this.tbImage.TabIndex = 1;
            this.tbImage.TextChanged += new System.EventHandler(this.tbImage_TextChanged);
            // 
            // btnZagr
            // 
            this.btnZagr.Location = new System.Drawing.Point(247, 177);
            this.btnZagr.Name = "btnZagr";
            this.btnZagr.Size = new System.Drawing.Size(106, 29);
            this.btnZagr.TabIndex = 2;
            this.btnZagr.Text = "Загрузка";
            this.btnZagr.UseVisualStyleBackColor = true;
            this.btnZagr.Click += new System.EventHandler(this.btnZagr_Click);
            // 
            // openPhotoDialog
            // 
            this.openPhotoDialog.FileName = "openFileDialog1";
            this.openPhotoDialog.Filter = "Файлы изображений|*.png";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(21, 212);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(202, 29);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // btnVivod
            // 
            this.btnVivod.Location = new System.Drawing.Point(247, 213);
            this.btnVivod.Name = "btnVivod";
            this.btnVivod.Size = new System.Drawing.Size(106, 29);
            this.btnVivod.TabIndex = 4;
            this.btnVivod.Text = "Вывод";
            this.btnVivod.UseVisualStyleBackColor = true;
            this.btnVivod.Click += new System.EventHandler(this.btnVivod_Click);
            // 
            // fmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 503);
            this.Controls.Add(this.btnVivod);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnZagr);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.pbImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fmImage";
            this.Text = "Загрузка изображения";
            this.Load += new System.EventHandler(this.fmImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Button btnZagr;
        private System.Windows.Forms.OpenFileDialog openPhotoDialog;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnVivod;
    }
}