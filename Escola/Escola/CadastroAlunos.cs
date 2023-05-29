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
    public partial class CadastroAlunos : Form
    {
        public CadastroAlunos()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new();
            aluno.Nome = txtNome.Text;
            aluno.DataNascimento = dateTime.Value;
            aluno.Email = txtEmail.Text;
            aluno.SalvarAluno();
            MessageBox.Show("Aluno Cadastrado!");
        }
    }
}
