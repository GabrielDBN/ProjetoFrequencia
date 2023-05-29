namespace Escola
{
    partial class TelaProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProfessor));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnVerDisciplinas = new Button();
            groupBox2 = new GroupBox();
            btnAplicarFaltas = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Professor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVerDisciplinas);
            groupBox1.Location = new Point(93, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Disciplinas";
            // 
            // btnVerDisciplinas
            // 
            btnVerDisciplinas.Location = new Point(53, 26);
            btnVerDisciplinas.Name = "btnVerDisciplinas";
            btnVerDisciplinas.Size = new Size(129, 61);
            btnVerDisciplinas.TabIndex = 0;
            btnVerDisciplinas.Text = "Ver Disciplinas";
            btnVerDisciplinas.UseVisualStyleBackColor = true;
            btnVerDisciplinas.Click += btnVerDisciplinas_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAplicarFaltas);
            groupBox2.Location = new Point(93, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 112);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Faltas";
            // 
            // btnAplicarFaltas
            // 
            btnAplicarFaltas.Location = new Point(53, 26);
            btnAplicarFaltas.Name = "btnAplicarFaltas";
            btnAplicarFaltas.Size = new Size(129, 61);
            btnAplicarFaltas.TabIndex = 0;
            btnAplicarFaltas.Text = "Aplicar faltas";
            btnAplicarFaltas.UseVisualStyleBackColor = true;
            btnAplicarFaltas.Click += btnAplicarFaltas_Click;
            // 
            // TelaProfessor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 384);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaProfessor";
            Text = "Tela do Professor";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnVerDisciplinas;
        private GroupBox groupBox2;
        private Button btnAplicarFaltas;
    }
}