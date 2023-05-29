namespace Escola
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            lblTitulo = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            lblTipoUsuario = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            cbxTipoUsuario = new ComboBox();
            btnEnviar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(124, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(206, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro Usuario";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(103, 131);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(100, 170);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 20);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(37, 209);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(115, 20);
            lblTipoUsuario.TabIndex = 3;
            lblTipoUsuario.Text = "Tipo de usuario:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 128);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(158, 167);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(174, 27);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // cbxTipoUsuario
            // 
            cbxTipoUsuario.FormattingEnabled = true;
            cbxTipoUsuario.Location = new Point(158, 206);
            cbxTipoUsuario.Margin = new Padding(3, 4, 3, 4);
            cbxTipoUsuario.Name = "cbxTipoUsuario";
            cbxTipoUsuario.Size = new Size(174, 28);
            cbxTipoUsuario.TabIndex = 7;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(158, 281);
            btnEnviar.Margin = new Padding(3, 4, 3, 4);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(126, 31);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(99, 93);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 9;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(158, 90);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(174, 27);
            txtNome.TabIndex = 10;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 363);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnEnviar);
            Controls.Add(cbxTipoUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblTipoUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroUsuario";
            Text = "CadastroUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblEmail;
        private Label lblSenha;
        private Label lblTipoUsuario;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private ComboBox cbxTipoUsuario;
        private Button btnEnviar;
        private Label lblNome;
        private TextBox txtNome;
    }
}