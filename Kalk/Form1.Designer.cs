namespace Kalk
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Minys = new System.Windows.Forms.Button();
            this.Pomnog = new System.Windows.Forms.Button();
            this.Podil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(26, 104);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(51, 51);
            this.Plus.TabIndex = 2;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            // 
            // Minys
            // 
            this.Minys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minys.Location = new System.Drawing.Point(99, 104);
            this.Minys.Name = "Minys";
            this.Minys.Size = new System.Drawing.Size(51, 51);
            this.Minys.TabIndex = 3;
            this.Minys.Text = "-";
            this.Minys.UseVisualStyleBackColor = true;
            // 
            // Pomnog
            // 
            this.Pomnog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pomnog.Location = new System.Drawing.Point(26, 181);
            this.Pomnog.Name = "Pomnog";
            this.Pomnog.Size = new System.Drawing.Size(51, 51);
            this.Pomnog.TabIndex = 4;
            this.Pomnog.Text = "*";
            this.Pomnog.UseVisualStyleBackColor = true;
            // 
            // Podil
            // 
            this.Podil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Podil.Location = new System.Drawing.Point(99, 181);
            this.Podil.Name = "Podil";
            this.Podil.Size = new System.Drawing.Size(51, 51);
            this.Podil.TabIndex = 5;
            this.Podil.Text = "/";
            this.Podil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 415);
            this.Controls.Add(this.Podil);
            this.Controls.Add(this.Pomnog);
            this.Controls.Add(this.Minys);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minys;
        private System.Windows.Forms.Button Pomnog;
        private System.Windows.Forms.Button Podil;
    }
}

