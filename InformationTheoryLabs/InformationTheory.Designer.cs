namespace InformationTheoryLabs
{
    partial class fInformationTheory
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
            this.tbPlaintext = new System.Windows.Forms.TextBox();
            this.lblPlaintext = new System.Windows.Forms.Label();
            this.lblCiphertext = new System.Windows.Forms.Label();
            this.tpCiphertext = new System.Windows.Forms.TextBox();
            this.cbCipher = new System.Windows.Forms.ComboBox();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnOpenPlaintext = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lblCipher = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbPlaintext
            // 
            this.tbPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlaintext.Location = new System.Drawing.Point(13, 204);
            this.tbPlaintext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPlaintext.Multiline = true;
            this.tbPlaintext.Name = "tbPlaintext";
            this.tbPlaintext.Size = new System.Drawing.Size(380, 310);
            this.tbPlaintext.TabIndex = 1;
            // 
            // lblPlaintext
            // 
            this.lblPlaintext.AutoSize = true;
            this.lblPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlaintext.Location = new System.Drawing.Point(7, 171);
            this.lblPlaintext.Name = "lblPlaintext";
            this.lblPlaintext.Size = new System.Drawing.Size(203, 29);
            this.lblPlaintext.TabIndex = 2;
            this.lblPlaintext.Text = " Исходный текст";
            // 
            // lblCiphertext
            // 
            this.lblCiphertext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCiphertext.AutoSize = true;
            this.lblCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCiphertext.Location = new System.Drawing.Point(412, 172);
            this.lblCiphertext.Name = "lblCiphertext";
            this.lblCiphertext.Size = new System.Drawing.Size(250, 29);
            this.lblCiphertext.TabIndex = 4;
            this.lblCiphertext.Text = "Шифрованный текст";
            // 
            // tpCiphertext
            // 
            this.tpCiphertext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tpCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpCiphertext.Location = new System.Drawing.Point(419, 206);
            this.tpCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpCiphertext.Multiline = true;
            this.tpCiphertext.Name = "tpCiphertext";
            this.tpCiphertext.Size = new System.Drawing.Size(380, 309);
            this.tpCiphertext.TabIndex = 3;
            // 
            // cbCipher
            // 
            this.cbCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCipher.FormattingEnabled = true;
            this.cbCipher.Location = new System.Drawing.Point(13, 52);
            this.cbCipher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCipher.Name = "cbCipher";
            this.cbCipher.Size = new System.Drawing.Size(380, 37);
            this.cbCipher.TabIndex = 5;
            this.cbCipher.Text = "Выберете\n алгоритм";
            // 
            // btnCode
            // 
            this.btnCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCode.Location = new System.Drawing.Point(13, 521);
            this.btnCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(381, 48);
            this.btnCode.TabIndex = 6;
            this.btnCode.Text = "Кодировать";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecode.Location = new System.Drawing.Point(419, 521);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(381, 48);
            this.btnDecode.TabIndex = 7;
            this.btnDecode.Text = "Декодировать";
            this.btnDecode.UseVisualStyleBackColor = true;
            // 
            // btnOpenPlaintext
            // 
            this.btnOpenPlaintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenPlaintext.Location = new System.Drawing.Point(13, 574);
            this.btnOpenPlaintext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenPlaintext.Name = "btnOpenPlaintext";
            this.btnOpenPlaintext.Size = new System.Drawing.Size(381, 48);
            this.btnOpenPlaintext.TabIndex = 9;
            this.btnOpenPlaintext.Text = "Загрузить файл";
            this.btnOpenPlaintext.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveToFile.Location = new System.Drawing.Point(417, 574);
            this.btnSaveToFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(381, 48);
            this.btnSaveToFile.TabIndex = 10;
            this.btnSaveToFile.Text = "Сохранить в файл";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey.Location = new System.Drawing.Point(16, 125);
            this.tbKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(380, 34);
            this.tbKey.TabIndex = 11;
            // 
            // lblCipher
            // 
            this.lblCipher.AutoSize = true;
            this.lblCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCipher.Location = new System.Drawing.Point(11, 20);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(290, 29);
            this.lblCipher.TabIndex = 12;
            this.lblCipher.Text = "Алгоритм шифрования:";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKey.Location = new System.Drawing.Point(15, 94);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(82, 29);
            this.lblKey.TabIndex = 13;
            this.lblKey.Text = "Ключ:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLanguage.Location = new System.Drawing.Point(412, 20);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(120, 29);
            this.lblLanguage.TabIndex = 15;
            this.lblLanguage.Text = "Алфавит:";
            // 
            // cbLanguage
            // 
            this.cbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(417, 52);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(381, 37);
            this.cbLanguage.TabIndex = 14;
            this.cbLanguage.Text = "Выберете\n алфавит";
            // 
            // fInformationTheory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 655);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblCipher);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnOpenPlaintext);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.cbCipher);
            this.Controls.Add(this.lblCiphertext);
            this.Controls.Add(this.tpCiphertext);
            this.Controls.Add(this.lblPlaintext);
            this.Controls.Add(this.tbPlaintext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fInformationTheory";
            this.Text = "TI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPlaintext;
        private System.Windows.Forms.Label lblPlaintext;
        private System.Windows.Forms.Label lblCiphertext;
        private System.Windows.Forms.TextBox tpCiphertext;
        private System.Windows.Forms.ComboBox cbCipher;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnOpenPlaintext;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lblCipher;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cbLanguage;
    }
}

