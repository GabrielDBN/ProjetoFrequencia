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
    public partial class TelaSecretario : Form
    {
        public TelaSecretario()
        {
            InitializeComponent();
        }

        private void btnRegistrarProfessor_Click(object sender, EventArgs e)
        {
            CadastroProfessor cadastroProfessor = new();
            cadastroProfessor.Show();
        }

        private void btnRegistrarAluno_Click(object sender, EventArgs e)
        {
            CadastroAlunos cadastroAlunos = new();
            cadastroAlunos.Show();
        }

        private void btnRegistrarTurma_Click(object sender, EventArgs e)
        {
            CadastroTurma cadastroTurma = new();
            cadastroTurma.Show();
        }

        private void btnRegistrarDisciplina_Click(object sender, EventArgs e)
        {
            CadstroDisciplina cadstroDisciplina = new CadstroDisciplina();
            cadstroDisciplina.Show();
        }
    }
}
