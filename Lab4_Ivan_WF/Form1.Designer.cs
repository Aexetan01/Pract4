namespace Lab4_Ivan_WF
{
    partial class Form1
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
            this.btnGetResult = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.lbArray = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveInFile = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetResult
            // 
            this.btnGetResult.Location = new System.Drawing.Point(6, 133);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(261, 31);
            this.btnGetResult.TabIndex = 5;
            this.btnGetResult.Text = "Отримати результат";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(6, 96);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(261, 31);
            this.btnFill.TabIndex = 4;
            this.btnFill.Text = "Заповнити масив";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // lbArray
            // 
            this.lbArray.FormattingEnabled = true;
            this.lbArray.ItemHeight = 24;
            this.lbArray.Location = new System.Drawing.Point(12, 12);
            this.lbArray.Name = "lbArray";
            this.lbArray.Size = new System.Drawing.Size(346, 316);
            this.lbArray.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFill);
            this.groupBox1.Controls.Add(this.btnLoadFromFile);
            this.groupBox1.Controls.Add(this.btnSaveInFile);
            this.groupBox1.Controls.Add(this.btnGetResult);
            this.groupBox1.Location = new System.Drawing.Point(364, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 316);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функціонал";
            // 
            // btnSaveInFile
            // 
            this.btnSaveInFile.Location = new System.Drawing.Point(6, 170);
            this.btnSaveInFile.Name = "btnSaveInFile";
            this.btnSaveInFile.Size = new System.Drawing.Size(261, 31);
            this.btnSaveInFile.TabIndex = 5;
            this.btnSaveInFile.Text = "Зберегти у файл";
            this.btnSaveInFile.UseVisualStyleBackColor = true;
            this.btnSaveInFile.Click += new System.EventHandler(this.btnSaveInFile_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(6, 207);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(261, 31);
            this.btnLoadFromFile.TabIndex = 5;
            this.btnLoadFromFile.Text = "Загрузити з файлу";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 332);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbArray);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.ListBox lbArray;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnSaveInFile;
    }
}

