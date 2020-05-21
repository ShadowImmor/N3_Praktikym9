namespace Задание_1_г
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
            this.Pow3 = new System.Windows.Forms.Button();
            this.Pow3Evenlabel = new System.Windows.Forms.Label();
            this.Pow3Even = new System.Windows.Forms.RichTextBox();
            this.Nminlabel = new System.Windows.Forms.Label();
            this.Nmaxlabel = new System.Windows.Forms.Label();
            this.Nmin = new System.Windows.Forms.NumericUpDown();
            this.Nmax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Nmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmax)).BeginInit();
            this.SuspendLayout();
            // 
            // Pow3
            // 
            this.Pow3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pow3.Location = new System.Drawing.Point(446, 15);
            this.Pow3.Name = "Pow3";
            this.Pow3.Size = new System.Drawing.Size(305, 79);
            this.Pow3.TabIndex = 0;
            this.Pow3.Text = "Чётный степени 3";
            this.Pow3.UseVisualStyleBackColor = true;
            this.Pow3.Click += new System.EventHandler(this.Pow3_Click);
            // 
            // Pow3Evenlabel
            // 
            this.Pow3Evenlabel.AutoSize = true;
            this.Pow3Evenlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pow3Evenlabel.Location = new System.Drawing.Point(288, 118);
            this.Pow3Evenlabel.Name = "Pow3Evenlabel";
            this.Pow3Evenlabel.Size = new System.Drawing.Size(218, 28);
            this.Pow3Evenlabel.TabIndex = 1;
            this.Pow3Evenlabel.Text = "Чётный степени 3";
            // 
            // Pow3Even
            // 
            this.Pow3Even.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pow3Even.Location = new System.Drawing.Point(12, 162);
            this.Pow3Even.Name = "Pow3Even";
            this.Pow3Even.ReadOnly = true;
            this.Pow3Even.Size = new System.Drawing.Size(776, 195);
            this.Pow3Even.TabIndex = 2;
            this.Pow3Even.Text = "";
            // 
            // Nminlabel
            // 
            this.Nminlabel.AutoSize = true;
            this.Nminlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nminlabel.Location = new System.Drawing.Point(12, 15);
            this.Nminlabel.Name = "Nminlabel";
            this.Nminlabel.Size = new System.Drawing.Size(230, 28);
            this.Nminlabel.TabIndex = 3;
            this.Nminlabel.Text = "Начальная степень";
            // 
            // Nmaxlabel
            // 
            this.Nmaxlabel.AutoSize = true;
            this.Nmaxlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nmaxlabel.Location = new System.Drawing.Point(14, 66);
            this.Nmaxlabel.Name = "Nmaxlabel";
            this.Nmaxlabel.Size = new System.Drawing.Size(218, 28);
            this.Nmaxlabel.TabIndex = 4;
            this.Nmaxlabel.Text = "Конечная степень";
            // 
            // Nmin
            // 
            this.Nmin.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nmin.Location = new System.Drawing.Point(258, 13);
            this.Nmin.Name = "Nmin";
            this.Nmin.Size = new System.Drawing.Size(120, 36);
            this.Nmin.TabIndex = 5;
            // 
            // Nmax
            // 
            this.Nmax.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nmax.Location = new System.Drawing.Point(258, 64);
            this.Nmax.Name = "Nmax";
            this.Nmax.Size = new System.Drawing.Size(120, 36);
            this.Nmax.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.Nmax);
            this.Controls.Add(this.Nmin);
            this.Controls.Add(this.Nmaxlabel);
            this.Controls.Add(this.Nminlabel);
            this.Controls.Add(this.Pow3Even);
            this.Controls.Add(this.Pow3Evenlabel);
            this.Controls.Add(this.Pow3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Nmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pow3;
        private System.Windows.Forms.Label Pow3Evenlabel;
        private System.Windows.Forms.RichTextBox Pow3Even;
        private System.Windows.Forms.Label Nminlabel;
        private System.Windows.Forms.Label Nmaxlabel;
        private System.Windows.Forms.NumericUpDown Nmin;
        private System.Windows.Forms.NumericUpDown Nmax;
    }
}

