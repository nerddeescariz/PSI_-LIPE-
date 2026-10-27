namespace Gestor_De_Tarefas
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
            textBox1 = new TextBox();
            buttonAdicionar = new Button();
            Tarefa = new ListBox();
            ButtonCompletar = new Button();
            ButtonApagar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(419, 22);
            label1.Name = "label1";
            label1.Size = new Size(365, 43);
            label1.TabIndex = 0;
            label1.Text = "Gestor de Tarefas";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(938, 27);
            textBox1.TabIndex = 1;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdicionar.ForeColor = SystemColors.ActiveCaptionText;
            buttonAdicionar.Location = new Point(1022, 89);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(94, 29);
            buttonAdicionar.TabIndex = 2;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // Tarefa
            // 
            Tarefa.FormattingEnabled = true;
            Tarefa.Location = new Point(58, 149);
            Tarefa.Name = "Tarefa";
            Tarefa.Size = new Size(1058, 364);
            Tarefa.TabIndex = 3;
            // 
            // ButtonCompletar
            // 
            ButtonCompletar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonCompletar.ForeColor = SystemColors.ActiveCaptionText;
            ButtonCompletar.Location = new Point(60, 519);
            ButtonCompletar.Name = "ButtonCompletar";
            ButtonCompletar.Size = new Size(134, 34);
            ButtonCompletar.TabIndex = 4;
            ButtonCompletar.Text = "Completar";
            ButtonCompletar.UseVisualStyleBackColor = true;
            ButtonCompletar.Click += ButtonCompletar_Click;
            // 
            // ButtonApagar
            // 
            ButtonApagar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonApagar.ForeColor = SystemColors.ActiveCaptionText;
            ButtonApagar.Location = new Point(200, 519);
            ButtonApagar.Name = "ButtonApagar";
            ButtonApagar.Size = new Size(124, 34);
            ButtonApagar.TabIndex = 5;
            ButtonApagar.Text = "Apagar";
            ButtonApagar.UseVisualStyleBackColor = true;
            ButtonApagar.Click += ButtonApagar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1323, 742);
            Controls.Add(ButtonApagar);
            Controls.Add(ButtonCompletar);
            Controls.Add(Tarefa);
            Controls.Add(buttonAdicionar);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Gestor de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonAdicionar;
        private ListBox Tarefa;
        private Button ButtonCompletar;
        private Button ButtonApagar;
    }
}
