using Escola.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Escola
{
    public partial class DisciplinasProfessor : Form
    {
        public DisciplinasProfessor()
        {
            InitializeComponent();
        }

        private void btnMostrarDP_Click(object sender, EventArgs e)
        {
            string IdProfessor = txtIdProfessor.Text;

            try
            {
                using (MySqlConnection conexaoDP = ConexaoDB.GetConexao())
                {
                    string queryDP = @"SELECT d.nome AS disciplina, h.dia_semana, h.horario, t.nome AS turma
                                      FROM disciplinas d
                                      JOIN horarios h ON d.id = h.disciplina_id
                                      JOIN turmas t ON h.turma_id = t.id
                                      JOIN disciplinas_turmas dt ON d.id = dt.disciplina_id
                                      JOIN professor p ON d.professor_id = p.id
                                      WHERE p.id = @IdProfessor";

                    using (MySqlCommand comandoDP = new MySqlCommand(queryDP, conexaoDP))
                    {
                        comandoDP.Parameters.AddWithValue("@IdProfessor", IdProfessor);

                        using (MySqlDataReader resultadoDP = comandoDP.ExecuteReader())
                        {
                            while (resultadoDP.Read())
                            {
                                string disciplina = resultadoDP.GetString("disciplina");
                                string diaSemana = resultadoDP.GetString("dia_semana");
                                string horario = resultadoDP.GetString("horario");
                                string turma = resultadoDP.GetString("turma");

                                LBDisciplinaP.Items.Add($"{disciplina} - {diaSemana} - {horario} - {turma}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
