namespace Escola
{
    partial class TelaFaltas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFaltas));
            label1 = new Label();
            btnMostrarFaltas = new Button();
            btnSairFalta = new Button();
            btnSalvarFaltas = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 71);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Disciplina:";
            // 
            // btnMostrarFaltas
            // 
            btnMostrarFaltas.Location = new Point(96, 176);
            btnMostrarFaltas.Name = "btnMostrarFaltas";
            btnMostrarFaltas.Size = new Size(94, 29);
            btnMostrarFaltas.TabIndex = 2;
            btnMostrarFaltas.Text = "Mostrar";
            btnMostrarFaltas.UseVisualStyleBackColor = true;
            btnMostrarFaltas.Click += btnMostrarFaltas_Click;
            // 
            // btnSairFalta
            // 
            btnSairFalta.Location = new Point(96, 271);
            btnSairFalta.Name = "btnSairFalta";
            btnSairFalta.Size = new Size(94, 29);
            btnSairFalta.TabIndex = 3;
            btnSairFalta.Text = "Sair";
            btnSairFalta.UseVisualStyleBackColor = true;
            btnSairFalta.Click += btnSairFalta_Click;
            // 
            // btnSalvarFaltas
            // 
            btnSalvarFaltas.Location = new Point(96, 224);
            btnSalvarFaltas.Name = "btnSalvarFaltas";
            btnSalvarFaltas.Size = new Size(94, 29);
            btnSalvarFaltas.TabIndex = 4;
            btnSalvarFaltas.Text = "Salvar";
            btnSalvarFaltas.UseVisualStyleBackColor = true;
            btnSalvarFaltas.Click += btnSalvarFaltas_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(249, 19);
            label2.Name = "label2";
            label2.Size = new Size(171, 23);
            label2.TabIndex = 5;
            label2.Text = "Tabela de Frequência";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 128);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 7;
            label3.Text = "Mês:";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(270, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 241);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Presença";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(70, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 28);
            comboBox1.TabIndex = 11;
            // 
            // TelaFaltas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 331);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSalvarFaltas);
            Controls.Add(btnSairFalta);
            Controls.Add(btnMostrarFaltas);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaFaltas";
            Text = "Tela de Faltas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMostrarFaltas;
        private Button btnSairFalta;
        private Button btnSalvarFaltas;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
    }
}