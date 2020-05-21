namespace Задание_2_г
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
            this.Search = new System.Windows.Forms.Button();
            this.Kolwordlabel = new System.Windows.Forms.Label();
            this.Kolword = new System.Windows.Forms.TextBox();
            this.FilePathlabel = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(355, 64);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(233, 49);
            this.Search.TabIndex = 0;
            this.Search.Text = "Узнать";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Kolwordlabel
            // 
            this.Kolwordlabel.AutoSize = true;
            this.Kolwordlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kolwordlabel.Location = new System.Drawing.Point(12, 136);
            this.Kolwordlabel.Name = "Kolwordlabel";
            this.Kolwordlabel.Size = new System.Drawing.Size(780, 28);
            this.Kolwordlabel.TabIndex = 1;
            this.Kolwordlabel.Text = "Количество слов, начинающихся и заканчивающихся одной буквой";
            // 
            // Kolword
            // 
            this.Kolword.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kolword.Location = new System.Drawing.Point(834, 133);
            this.Kolword.Name = "Kolword";
            this.Kolword.ReadOnly = true;
            this.Kolword.Size = new System.Drawing.Size(174, 36);
            this.Kolword.TabIndex = 2;
            // 
            // FilePathlabel
            // 
            this.FilePathlabel.AutoSize = true;
            this.FilePathlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePathlabel.Location = new System.Drawing.Point(13, 13);
            this.FilePathlabel.Name = "FilePathlabel";
            this.FilePathlabel.Size = new System.Drawing.Size(167, 28);
            this.FilePathlabel.TabIndex = 3;
            this.FilePathlabel.Text = "Путь к файлу";
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilePath.Location = new System.Drawing.Point(196, 10);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(799, 36);
            this.FilePath.TabIndex = 4;
            this.FilePath.Text = "..\\\\..\\\\..\\\\text.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 182);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.FilePathlabel);
            this.Controls.Add(this.Kolword);
            this.Controls.Add(this.Kolwordlabel);
            this.Controls.Add(this.Search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Kolwordlabel;
        private System.Windows.Forms.TextBox Kolword;
        private System.Windows.Forms.Label FilePathlabel;
        private System.Windows.Forms.TextBox FilePath;
    }
}

