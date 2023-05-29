namespace Escola
{
    partial class CadstroDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadstroDisciplina));
            btnEnviar = new Button();
            cbxTipoDsiciplina = new ComboBox();
            cbxProfessorNome = new ComboBox();
            txtNome = new TextBox();
            lblNome = new Label();
            lblTipoDsciplina = new Label();
            lblProfessor = new Label();
            lblDiaSemana = new Label();
            cbxDiaSemana = new ComboBox();
            cbxHorarios = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(220, 267);
            btnEnviar.Margin = new Padding(3, 4, 3, 4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(157, 31);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += button1_Click;
            // 
            // cbxTipoDsiciplina
            // 
            cbxTipoDsiciplina.FormattingEnabled = true;
            cbxTipoDsiciplina.Location = new Point(407, 100);
            cbxTipoDsiciplina.Margin = new Padding(3, 4, 3, 4);
            cbxTipoDsiciplina.Name = "cbxTipoDsiciplina";
            cbxTipoDsiciplina.Size = new Size(138, 28);
            cbxTipoDsiciplina.TabIndex = 1;
            // 
            // cbxProfessorNome
            // 
            cbxProfessorNome.FormattingEnabled = true;
            cbxProfessorNome.Location = new Point(143, 139);
            cbxProfessorNome.Margin = new Padding(3, 4, 3, 4);
            cbxProfessorNome.Name = "cbxProfessorNome";
            cbxProfessorNome.Size = new Size(138, 28);
            cbxProfessorNome.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(143, 100);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(138, 27);
            txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(84, 104);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // lblTipoDsciplina
            // 
            lblTipoDsciplina.AutoSize = true;
            lblTipoDsciplina.Location = new Point(294, 104);
            lblTipoDsciplina.Name = "lblTipoDsciplina";
            lblTipoDsciplina.Size = new Size(107, 20);
            lblTipoDsciplina.TabIndex = 5;
            lblTipoDsciplina.Text = "Tipo Dsciplina:";
            // 
            // lblProfessor
            // 
            lblProfessor.AutoSize = true;
            lblProfessor.Location = new Point(64, 142);
            lblProfessor.Name = "lblProfessor";
            lblProfessor.Size = new Size(73, 20);
            lblProfessor.TabIndex = 6;
            lblProfessor.Text = "Professor:";
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(26, 181);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(111, 20);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "Dia da semana:";
            // 
            // cbxDiaSemana
            // 
            cbxDiaSemana.FormattingEnabled = true;
            cbxDiaSemana.Location = new Point(143, 177);
            cbxDiaSemana.Margin = new Padding(3, 4, 3, 4);
            cbxDiaSemana.Name = "cbxDiaSemana";
            cbxDiaSemana.Size = new Size(138, 28);
            cbxDiaSemana.TabIndex = 8;
            // 
            // cbxHorarios
            // 
            cbxHorarios.FormattingEnabled = true;
            cbxHorarios.Location = new Point(407, 177);
            cbxHorarios.Margin = new Padding(3, 4, 3, 4);
            cbxHorarios.Name = "cbxHorarios";
            cbxHorarios.Size = new Size(138, 28);
            cbxHorarios.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 181);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 10;
            label1.Text = "Horario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 142);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 11;
            label2.Text = "Turma:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(407, 139);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(169, 21);
            label3.Name = "label3";
            label3.Size = new Size(263, 35);
            label3.TabIndex = 13;
            label3.Text = "Cadastro de Disciplina";
            // 
            // CadstroDisciplina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 331);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxHorarios);
            Controls.Add(cbxDiaSemana);
            Controls.Add(lblDiaSemana);
            Controls.Add(lblProfessor);
            Controls.Add(lblTipoDsciplina);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(cbxProfessorNome);
            Controls.Add(cbxTipoDsiciplina);
            Controls.Add(btnEnviar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadstroDisciplina";
            Text = "Cadastro Disciplina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private ComboBox cbxTipoDsiciplina;
        private ComboBox cbxProfessorNome;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblTipoDsciplina;
        private Label lblProfessor;
        private Label lblDiaSemana;
        private ComboBox cbxDiaSemana;
        private ComboBox cbxHorarios;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
    }
}