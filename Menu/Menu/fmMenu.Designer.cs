namespace Menu
{
    partial class fmMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnDGV = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 1066);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(588, 130);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Меню";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImage
            // 
            this.btnImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImage.Location = new System.Drawing.Point(0, 130);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(588, 52);
            this.btnImage.TabIndex = 2;
            this.btnImage.Text = "Загрузка изображений";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnDGV
            // 
            this.btnDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDGV.Location = new System.Drawing.Point(0, 182);
            this.btnDGV.Name = "btnDGV";
            this.btnDGV.Size = new System.Drawing.Size(588, 52);
            this.btnDGV.TabIndex = 3;
            this.btnDGV.Text = "DataGridView";
            this.btnDGV.UseVisualStyleBackColor = true;
            this.btnDGV.Click += new System.EventHandler(this.btnDGV_Click);
            // 
            // btnDate
            // 
            this.btnDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDate.Location = new System.Drawing.Point(0, 234);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(588, 52);
            this.btnDate.TabIndex = 4;
            this.btnDate.Text = "Поиск по дате";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // fmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 592);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnDGV);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "fmMenu";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnDGV;
        private System.Windows.Forms.Button btnDate;
    }
}

