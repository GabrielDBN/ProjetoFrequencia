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
    public partial class TelaProfessor : Form
    {
        public DisciplinasProfessor disciplinasProfessor;
        public TelaFaltas telaFaltas;

        public TelaProfessor()
        {
            InitializeComponent();
        }

        private void btnVerDisciplinas_Click(object sender, EventArgs e)
        {
            if (disciplinasProfessor == null || disciplinasProfessor.ActiveControl == null)
            {
                disciplinasProfessor = new DisciplinasProfessor();
                disciplinasProfessor.MdiParent = this;
                disciplinasProfessor.Show();
            }
            else
            {
                disciplinasProfessor.Show();
            }
        }

        private void btnAplicarFaltas_Click(object sender, EventArgs e)
        {
            if (telaFaltas == null || telaFaltas.ActiveControl == null)
            {
                telaFaltas = new TelaFaltas();
                telaFaltas.MdiParent = this;
                telaFaltas.Show();
            }
            else
            {
                disciplinasProfessor.Show();
            }
        }
    }
}
