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
    public partial class CadastroProfessor : Form
    {

        Usuario usuario = new Usuario();
        Professor professor = new Professor();

        public CadastroProfessor()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            var usrid = usuario.InsertUser();
            professor.Nome = txtNome.Text;
            professor.Usuario_id = usrid;
            professor.Insert();
        }
    }
}
