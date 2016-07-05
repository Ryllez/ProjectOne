namespace Calcul
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.multiplication = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.involution = new System.Windows.Forms.Button();
            this.extract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 20);
            this.textBox2.TabIndex = 1;
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addition.Location = new System.Drawing.Point(12, 81);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(110, 40);
            this.addition.TabIndex = 2;
            this.addition.Text = "+";
            this.addition.UseMnemonic = false;
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(66, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 20);
            this.textBox3.TabIndex = 7;
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.multiplication.Location = new System.Drawing.Point(128, 81);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(110, 40);
            this.multiplication.TabIndex = 8;
            this.multiplication.Text = "*";
            this.multiplication.UseMnemonic = false;
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtraction
            // 
            this.subtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.subtraction.Location = new System.Drawing.Point(12, 127);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(110, 40);
            this.subtraction.TabIndex = 9;
            this.subtraction.Text = "-";
            this.subtraction.UseMnemonic = false;
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.button1_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.division.Location = new System.Drawing.Point(128, 127);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(110, 40);
            this.division.TabIndex = 10;
            this.division.Text = "/";
            this.division.UseMnemonic = false;
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.button1_Click);
            // 
            // involution
            // 
            this.involution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.involution.Location = new System.Drawing.Point(244, 81);
            this.involution.Name = "involution";
            this.involution.Size = new System.Drawing.Size(110, 40);
            this.involution.TabIndex = 11;
            this.involution.Text = "квадрат";
            this.involution.UseMnemonic = false;
            this.involution.UseVisualStyleBackColor = false;
            this.involution.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // extract
            // 
            this.extract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.extract.Location = new System.Drawing.Point(244, 127);
            this.extract.Name = "extract";
            this.extract.Size = new System.Drawing.Size(110, 40);
            this.extract.TabIndex = 12;
            this.extract.Text = "корень";
            this.extract.UseMnemonic = false;
            this.extract.UseVisualStyleBackColor = false;
            this.extract.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(383, 231);
            this.Controls.Add(this.extract);
            this.Controls.Add(this.involution);
            this.Controls.Add(this.division);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button involution;
        private System.Windows.Forms.Button extract;
    }
}

