using Quizify.Entities;
using Quizify.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuizifyIU
{
    public partial class CrearQuiz_3 : Form
    {

        List<dynamic> filtros;
        private NuevoServicio servicio;
        private dynamic usuario;
        private Examen examen;
        public bool crearquiz = false;
        string tipo;
        dynamic dificultad;
        string tema;
        
        public CrearQuiz_3(NuevoServicio servicio, dynamic user, Examen examen)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.usuario = user;
            filtros = new List<dynamic>() { usuario.GetCorreo(), null, null, null };
            this.examen = examen;
            tabla();
            crearquiz = false;
        }

        private void tabla()
        {
            DataTable datos = servicio.GetPreguntas(filtros);
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                if (examen.GetPreguntasAsociadas().Count > 0)
                {
                    for (int j = 0; j < examen.GetPreguntasAsociadas().Count; j += 3)
                    {
                        if (int.Parse(datos.Rows[i]["id"].ToString()) == examen.GetPreguntasAsociadas()[j] && int.Parse(datos.Rows[i]["ver"].ToString()) == examen.GetPreguntasAsociadas()[j + 1])
                        {
                            datos.Rows[i].Delete();
                            break;
                        };
                    }
                }
            }
            dataGridView1.DataSource = datos;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (tipo_txt.Text == "") { tipo = null; } else { tipo = tipo_txt.Text.ToLower(); }
            if (dificultad_txt.SelectedIndex == -1) { dificultad = null; } else { dificultad = dificultad_txt.SelectedIndex; }
            if (tema_txt.Text == "") { tema = null; } else { tema = tema_txt.Text; }

            filtros = new List<dynamic>() { usuario.GetCorreo(), tipo, dificultad, tema };
            tabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            añadir_pregunta();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            añadir_pregunta();
        }

        private void añadir_pregunta()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                List<int> lista = examen.GetPreguntasAsociadas();
                lista.Add(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                lista.Add(int.Parse(dataGridView1.SelectedCells[1].Value.ToString()));
                lista.Add(1);
                examen.SetPreguntasAsociadas(lista);
                Principal.formportal.abrirNieto(new CrearQuiz_2(servicio, usuario, examen));
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new CrearQuiz_2(servicio, usuario, examen));
        }


    }
}
