using Escola.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class CadastroUsuario : Form
    {
        Usuario usuario = new Usuario();
        public CadastroUsuario()
        {
            InitializeComponent();
            cbxTipoUsuario.Items.Add("professor");
            cbxTipoUsuario.Items.Add("secretario");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Tipo = cbxTipoUsuario.Text;
            var id = usuario.InsertUser();
            MessageBox.Show("id inserido: " + id);
        }
    }
}
