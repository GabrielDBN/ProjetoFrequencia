using Escola.Entities;
using MySql.Data.MySqlClient;

namespace Escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new();
            TelaSecretario telaSecretario = new();
            var usr = usuario.GetUserByEmailAndPassword(txtEmail.Text, txtSenha.Text);
            if (usr != null)
            {
                // MessageBox.Show(usr.Tipo);
                if (usr.Tipo == "secretario")
                {
                    telaSecretario.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario Invalido");
            }

        }
    }
}