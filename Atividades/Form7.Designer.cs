﻿namespace Atividades
{
    partial class Form7
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
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 79);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite o valor para o raio : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(453, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(39, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(367, 106);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 153);
            label2.Name = "label2";
            label2.Size = new Size(268, 15);
            label2.TabIndex = 3;
            label2.Text = "A area do circulo e calculada como A = pi * raio² :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(311, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(39, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(379, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(39, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(445, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(39, 23);
            textBox4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 188);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 7;
            label3.Text = "=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 188);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 8;
            label4.Text = "+";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(490, 185);
            label5.Name = "label5";
            label5.Size = new Size(11, 15);
            label5.TabIndex = 9;
            label5.Text = "²";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}