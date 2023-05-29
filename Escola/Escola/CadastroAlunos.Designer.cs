namespace Escola
{
    partial class CadastroAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAlunos));
            btnEnviar = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            dateTime = new DateTimePicker();
            lblNome = new Label();
            lblEmail = new Label();
            lblData = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(136, 267);
            btnEnviar.Margin = new Padding(3, 4, 3, 4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(130, 31);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(164, 95);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(131, 27);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(164, 144);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(131, 27);
            txtEmail.TabIndex = 4;
            // 
            // dateTime
            // 
            dateTime.Format = DateTimePickerFormat.Short;
            dateTime.Location = new Point(174, 202);
            dateTime.Margin = new Padding(3, 4, 3, 4);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(131, 27);
            dateTime.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(105, 98);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(109, 147);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(26, 202);
            lblData.Name = "lblData";
            lblData.Size = new Size(142, 20);
            lblData.TabIndex = 10;
            lblData.Text = "Data de nascimento";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(109, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(186, 35);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Cadastro Aluno";
            // 
            // CadastroAlunos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 339);
            Controls.Add(lblTitle);
            Controls.Add(lblData);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(dateTime);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(btnEnviar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroAlunos";
            Text = "Cadastro Alunos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private DateTimePicker dateTime;
        private Label lblNome;
        private Label lblEmail;
        private Label lblData;
        private Label lblTitle;
    }
}