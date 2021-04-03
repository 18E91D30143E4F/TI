namespace _1_lab
{
    partial class Form
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.cbMetod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(82, 202);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(149, 34);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(215, 78);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(230, 22);
            this.tbText.TabIndex = 3;
            // 
            // cbMetod
            // 
            this.cbMetod.FormattingEnabled = true;
            this.cbMetod.Items.AddRange(new object[] {
            "Железнодорожная изгородь",
            "Столбцовый метод",
            "Поворачивающаяся решетка",
            "Шифр Цезаря"});
            this.cbMetod.Location = new System.Drawing.Point(215, 33);
            this.cbMetod.Name = "cbMetod";
            this.cbMetod.Size = new System.Drawing.Size(230, 24);
            this.cbMetod.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберете метод";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Зашифровать/Расшифровать";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(263, 202);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(147, 34);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Значение ключа";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(215, 164);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(230, 22);
            this.tbResult.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Результат";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(215, 120);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(230, 22);
            this.tbKey.TabIndex = 12;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 252);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMetod);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Form";
            this.Text = "Кадет";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ComboBox cbMetod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKey;
    }
}

