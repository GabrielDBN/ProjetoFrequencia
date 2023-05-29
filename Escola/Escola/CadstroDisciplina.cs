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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Escola
{
    public partial class CadstroDisciplina : Form
    {
        private Professor professor = new();
        private List<Professor> professors;
        private Disciplinas disciplinas;
        private List<string> diasDaSemana = new List<string>()
        {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira"
        };
        private List<string> horarios = new List<string>()
        {
            "Matutino",
            "Vespertino",
            "Noturno"
        };

        public CadstroDisciplina()
        {
            InitializeComponent();
            professors = professor.ListAll();
            cbxTipoDsiciplina.Items.Add("2");
            cbxTipoDsiciplina.Items.Add("4");
            foreach (string dia in diasDaSemana)
            {
                cbxDiaSemana.Items.Add(dia);
            }
            foreach (string horario in horarios)
            {
                cbxHorarios.Items.Add(horario);
            }
            for (int i = 0; i < professors.Count; i++)
            {
                cbxProfessorNome.Items.Add(professors[i].Nome);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = cbxProfessorNome.SelectedIndex;
            var idProfessor = professors[index].Id;

            Disciplinas disciplinas = new();
            Horario horario = new();
            Turma turma = new();
            disciplinas.Nome = txtNome.Text;
            disciplinas.Professor_id = idProfessor;
            disciplinas.Tipo_disciplina = cbxTipoDsiciplina.Text;
            var idDisciplina = disciplinas.Insert();
            // falta puxar as turmas para o form

        }
    }
}
