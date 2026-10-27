namespace PessegoMetter
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            listView1 = new ListView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(510, 74);
            label1.Name = "label1";
            label1.Size = new Size(209, 38);
            label1.TabIndex = 0;
            label1.Text = "Pessego Metter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 28);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 1;
            label2.Text = "Voce é";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1086, 27);
            textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(111, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1083, 24);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(188, 173);
            button1.Name = "button1";
            button1.Size = new Size(129, 28);
            button1.TabIndex = 4;
            button1.Text = "enviar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(529, 173);
            button2.Name = "button2";
            button2.Size = new Size(129, 28);
            button2.TabIndex = 5;
            button2.Text = "tentar de novo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(353, 173);
            button3.Name = "button3";
            button3.Size = new Size(129, 28);
            button3.TabIndex = 6;
            button3.Text = "cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(501, 216);
            label3.Name = "label3";
            label3.Size = new Size(239, 38);
            label3.TabIndex = 7;
            label3.Text = "Escala de Pessego";
            // 
            // listView1
            // 
            listView1.Location = new Point(84, 268);
            listView1.Name = "listView1";
            listView1.Size = new Size(1110, 231);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 280);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 9;
            label4.Text = "0% - Macho Alfa";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 310);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 10;
            label5.Text = "1-10% - Normal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 340);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 11;
            label6.Text = "11-25% - Pessego Iniciante";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(100, 369);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 12;
            label7.Text = "26-50% - Pessego";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(99, 401);
            label8.Name = "label8";
            label8.Size = new Size(176, 20);
            label8.TabIndex = 13;
            label8.Text = "50-75% - Formal Pessego";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(99, 431);
            label9.Name = "label9";
            label9.Size = new Size(215, 20);
            label9.TabIndex = 14;
            label9.Text = "76-99% - GrandMaster Pessego";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(99, 461);
            label10.Name = "label10";
            label10.Size = new Size(116, 20);
            label10.TabIndex = 15;
            label10.Text = "100% - Banhoso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 496);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Pessego Metter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private ListView listView1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
