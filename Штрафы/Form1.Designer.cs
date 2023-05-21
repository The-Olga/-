namespace Штрафы
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
            this.textBoxu = new System.Windows.Forms.TextBox();
            this.labelu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSh = new System.Windows.Forms.Label();
            this.labelend = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxu
            // 
            this.textBoxu.Location = new System.Drawing.Point(87, 98);
            this.textBoxu.Name = "textBoxu";
            this.textBoxu.Size = new System.Drawing.Size(220, 22);
            this.textBoxu.TabIndex = 0;
            // 
            // labelu
            // 
            this.labelu.AutoSize = true;
            this.labelu.Location = new System.Drawing.Point(12, 98);
            this.labelu.Name = "labelu";
            this.labelu.Size = new System.Drawing.Size(44, 16);
            this.labelu.TabIndex = 1;
            this.labelu.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelSh
            // 
            this.labelSh.AutoSize = true;
            this.labelSh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSh.Location = new System.Drawing.Point(12, 9);
            this.labelSh.Name = "labelSh";
            this.labelSh.Size = new System.Drawing.Size(238, 25);
            this.labelSh.TabIndex = 4;
            this.labelSh.Text = "Разрешённая скорость: ";
            // 
            // labelend
            // 
            this.labelend.AutoSize = true;
            this.labelend.Location = new System.Drawing.Point(12, 284);
            this.labelend.Name = "labelend";
            this.labelend.Size = new System.Drawing.Size(44, 16);
            this.labelend.TabIndex = 5;
            this.labelend.Text = "label3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(232, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelend);
            this.Controls.Add(this.labelSh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelu);
            this.Controls.Add(this.textBoxu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxu;
        private System.Windows.Forms.Label labelu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelSh;
        private System.Windows.Forms.Label labelend;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

