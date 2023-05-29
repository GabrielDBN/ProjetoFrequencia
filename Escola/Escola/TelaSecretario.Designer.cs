namespace Escola
{
    partial class TelaSecretario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSecretario));
            btnRegistrarProfessor = new Button();
            btnRegistrarAluno = new Button();
            lblRegistros = new Label();
            btnRegistrarTurma = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btnRegistrarDisciplina = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrarProfessor
            // 
            btnRegistrarProfessor.Location = new Point(48, 28);
            btnRegistrarProfessor.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarProfessor.Name = "btnRegistrarProfessor";
            btnRegistrarProfessor.Size = new Size(129, 61);
            btnRegistrarProfessor.TabIndex = 0;
            btnRegistrarProfessor.Text = "Registrar";
            btnRegistrarProfessor.UseVisualStyleBackColor = true;
            btnRegistrarProfessor.Click += btnRegistrarProfessor_Click;
            // 
            // btnRegistrarAluno
            // 
            btnRegistrarAluno.Location = new Point(47, 29);
            btnRegistrarAluno.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarAluno.Name = "btnRegistrarAluno";
            btnRegistrarAluno.Size = new Size(130, 61);
            btnRegistrarAluno.TabIndex = 1;
            btnRegistrarAluno.Text = "Registrar";
            btnRegistrarAluno.UseVisualStyleBackColor = true;
            btnRegistrarAluno.Click += btnRegistrarAluno_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistros.Location = new Point(12, 9);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(97, 25);
            lblRegistros.TabIndex = 2;
            lblRegistros.Text = "Secretario";
            // 
            // btnRegistrarTurma
            // 
            btnRegistrarTurma.Location = new Point(48, 29);
            btnRegistrarTurma.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarTurma.Name = "btnRegistrarTurma";
            btnRegistrarTurma.Size = new Size(129, 61);
            btnRegistrarTurma.TabIndex = 3;
            btnRegistrarTurma.Text = "Registrar";
            btnRegistrarTurma.UseVisualStyleBackColor = true;
            btnRegistrarTurma.Click += btnRegistrarTurma_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarTurma);
            groupBox1.Location = new Point(25, 71);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 112);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Turma";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRegistrarAluno);
            groupBox2.Location = new Point(283, 71);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(229, 112);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aluno";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRegistrarProfessor);
            groupBox3.Location = new Point(25, 222);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(229, 112);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Professor";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnRegistrarDisciplina);
            groupBox4.Location = new Point(283, 222);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(229, 112);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Disciplina";
            // 
            // btnRegistrarDisciplina
            // 
            btnRegistrarDisciplina.Location = new Point(47, 28);
            btnRegistrarDisciplina.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarDisciplina.Name = "btnRegistrarDisciplina";
            btnRegistrarDisciplina.Size = new Size(129, 61);
            btnRegistrarDisciplina.TabIndex = 0;
            btnRegistrarDisciplina.Text = "Registrar";
            btnRegistrarDisciplina.UseVisualStyleBackColor = true;
            btnRegistrarDisciplina.Click += btnRegistrarDisciplina_Click;
            // 
            // TelaSecretario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 378);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblRegistros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaSecretario";
            Text = "Tela Secretario";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarProfessor;
        private Button btnRegistrarAluno;
        private Label lblRegistros;
        private Button btnRegistrarTurma;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnRegistrarDisciplina;
    }
}