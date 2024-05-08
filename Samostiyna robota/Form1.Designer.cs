namespace Samostiyna_robota
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(179, 321);
            button1.Name = "button1";
            button1.Size = new Size(133, 23);
            button1.TabIndex = 0;
            button1.Text = "Зареєструватися";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(127, 261);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(237, 28);
            textBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(127, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 28);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(127, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 28);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(168, 55);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 6;
            label1.Text = "Реєстраційна форма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 102);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 7;
            label2.Text = "Логін";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 179);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 8;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 243);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 9;
            label4.Text = "Підтвердити пароль";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Реєстація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
