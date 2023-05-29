namespace Escola
{
    partial class CadastroTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTurma));
            label1 = new Label();
            txtNome = new TextBox();
            btnEnviar = new Button();
            txtSemestre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(111, 18);
            label1.Name = "label1";
            label1.Size = new Size(86, 35);
            label1.TabIndex = 0;
            label1.Text = "Turma";
            // 
            // txtNome
            // 
            txtNome.HideSelection = false;
            txtNome.Location = new Point(131, 80);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 27);
            txtNome.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(111, 204);
            btnEnviar.Margin = new Padding(3, 4, 3, 4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(86, 31);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtSemestre
            // 
            txtSemestre.Location = new Point(131, 135);
            txtSemestre.Margin = new Padding(3, 4, 3, 4);
            txtSemestre.Name = "txtSemestre";
            txtSemestre.Size = new Size(114, 27);
            txtSemestre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 83);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Turma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 138);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 5;
            label3.Text = "Semestre:";
            // 
            // CadastroTurma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 271);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSemestre);
            Controls.Add(btnEnviar);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroTurma";
            Text = "CadastroTurma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button btnEnviar;
        private TextBox txtSemestre;
        private Label label2;
        private Label label3;
    }
}