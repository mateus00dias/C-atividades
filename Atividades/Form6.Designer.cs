﻿namespace Atividades
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o valor para : ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(372, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(21, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 54);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 2;
            label2.Text = "a :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 87);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 3;
            label3.Text = "b :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 121);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 4;
            label4.Text = "c :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(372, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(21, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(372, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(21, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(337, 154);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 7;
            label5.Text = "Delta = b² - 4ac";
            // 
            // button1
            // 
            button1.Location = new Point(350, 183);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 223);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(226, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(343, 23);
            textBox4.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 261);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 11;
            label7.Text = "X1 :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(372, 252);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(21, 23);
            textBox5.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 292);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 13;
            label8.Text = "X2 :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(372, 284);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(21, 23);
            textBox6.TabIndex = 14;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
    }
}