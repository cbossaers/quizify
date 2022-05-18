using Quizify.Entities;
using Quizify.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizifyIU
{
    public partial class CrearQuiz_2 : Form
    {
        private NuevoServicio servicio;
        private dynamic usuario;
        private Examen examen;
        public CrearQuiz_2(NuevoServicio servicio, dynamic user,Examen examen)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            this.examen = examen; 
            label1.Text=examen.titulo.ToString();
            tabla();
        }


        private void tabla()
        {
            List<int> DTable = examen.GetPreguntasAsociadas();
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("ID");
            dt.Columns.Add("Versión");
            dt.Columns.Add("Enunciado");
            dt.Columns.Add("Dificultad");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("Autor");
            dt.Columns.Add("Materia");
            dt.Columns.Add("Puntuación");
            for (int i = 0; i < DTable.Count; i += 3)
            {
                Pregunta2 preg = servicio.GetPregunta(DTable[i], DTable[i + 1]);

                DataRow _ravi = dt.NewRow();
                _ravi["ID"] = preg.GetId().ToString();
                _ravi["Versión"] = preg.GetVersion();
                _ravi["Enunciado"] = preg.GetEnunciado();
                _ravi["Autor"] = preg.GetAutor();
                _ravi["Materia"] = preg.GetTema();
                _ravi["Puntuación"] = DTable[i + 2];
                switch (preg.GetDificultad())
                {
                    case (0): _ravi["Dificultad"] = "Fácil"; break;
                    case (1): _ravi["Dificultad"] = "Normal"; break;
                    case (2): _ravi["Dificultad"] = "Difícil"; break;
                }
                switch (preg.GetTipo())
                {
                    case ("test"): _ravi["Tipo"] = "Test"; break;
                    case ("vf"): _ravi["Tipo"] = "VF"; break;
                    case ("mult"): _ravi["Tipo"] = "Multi"; break;
                    case ("des"): _ravi["Tipo"] = "Desarrollo"; break;
                }
                dt.Rows.Add(_ravi);
            }
            dataGridView1.DataSource = dt;
        }

        private void crear_Click(object sender, EventArgs e)
        {
            List<int> lista = examen.GetPreguntasAsociadas();
            for (int i = 0; i < lista.Count; i += 3)
            {
                lista[i + 2] = int.Parse(dataGridView1.SelectedCells[7].Value.ToString());
            }
            examen.SetPreguntasAsociadas(lista);
            servicio.AddExamen(examen);
            MessageBox.Show(this, "Se ha creado el examen", "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
            this.Hide();
        }

        private void anular_Click(object sender, EventArgs e)
        {
            List<int> lista = examen.GetPreguntasAsociadas();
            int ide = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            for (int i = 0; i < lista.Count; i += 3)
            {
                if(lista[i] == ide )
                {
                    lista[i+2] = 0;
                }
            }
            examen.SetPreguntasAsociadas(lista);
            tabla();
        }
        private void editar_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new CrearPregunta(servicio, usuario, servicio.GetPregunta(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()), int.Parse(dataGridView1.SelectedCells[3].Value.ToString()))));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new CrearQuiz(servicio, usuario, examen));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new CrearQuiz_3(servicio, usuario, examen));
        }
    }
}

