using Quizify.Entities;
using Quizify.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
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
        List<int> DTable;
        string tipo;
        dynamic dificultad;
        string tema;
        public CrearQuiz_3(NuevoServicio servicio, dynamic user,Examen examen)
        {
            InitializeComponent();
            
            this.servicio = servicio;
            this.usuario = user;
            //filtros[0] = usuario.nombre;
            filtros = new List<dynamic>() { usuario.GetCorreo(), null, null, null };
            this.examen = examen;
            DTable = servicio.GetPreguntas(filtros);
            tabla();
            crearquiz = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new CrearPregunta(servicio,usuario,examen);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tabla();
        }
        private void tabla()
        {
            
            bool esta = false;
            BindingList<object> bindinglist = new BindingList<object>();


            for (int i = 0; i < DTable.Count; i += 2)
            {
                esta = false;
                if(examen.GetPreguntasAsociadas().Count > 0)
                {
                    for (int j = 0; j < examen.GetPreguntasAsociadas().Count; j += 3)
                    {
                        if (DTable[i] == examen.GetPreguntasAsociadas()[j]) { esta = true; };
                    }
                }
                
                if (!esta)
                {
                    Pregunta2 preg = servicio.GetPregunta(DTable[i], DTable[i + 1]);
                    if (preg.GetTipo() == "test")
                    {
                        bindinglist.Add(new
                        {
                            ds_ID = preg.GetId().ToString(),
                            ds_enunciado = preg.GetEnunciado(),
                            ds_tipo = "Test",
                            ds_version = preg.GetVersion(),
                            ds_dificultad = preg.GetDificultad(),
                            ds_materia = preg.GetTema(),
                            ds_autor = filtros[0]
                        });

                    }
                    else
                    if (preg.GetTipo() == "vf")
                    {
                        bindinglist.Add(new
                        {
                            ds_ID = preg.GetId().ToString(),
                            ds_enunciado = preg.GetEnunciado(),
                            ds_tipo = "VF",
                            ds_version = preg.GetVersion(),
                            ds_dificultad = preg.GetDificultad(),
                            ds_materia = preg.GetTema(),
                            ds_autor = filtros[0]
                        });
                    }
                }
                
                

            }
            dataGridView1.DataSource = bindinglist;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView1.SelectedCells[0].Value.ToString();
            if (dataGridView1.Rows.Count > 0)
            {
                List<int> lista = examen.GetPreguntasAsociadas();
                lista.Add(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                lista.Add(int.Parse(dataGridView1.SelectedCells[3].Value.ToString()));
                lista.Add(1);
                examen.SetPreguntasAsociadas(lista);
                this.Hide();
                var form2 = new CrearQuiz_2(servicio, usuario, examen);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                List<int> lista = examen.GetPreguntasAsociadas();
                lista.Add(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                lista.Add(int.Parse(dataGridView1.SelectedCells[3].Value.ToString()));
                lista.Add(1);
                examen.SetPreguntasAsociadas(lista);
                this.Hide();
                var form2 = new CrearQuiz_2(servicio, usuario, examen);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (tipo_txt.Text == "") { tipo = null; } else { tipo = tipo_txt.Text.ToLower(); }
            if (dificultad_txt.SelectedIndex == -1) { dificultad = null; } else { dificultad = dificultad_txt.SelectedIndex; }
            if (tema_txt.Text == "") { tema = null; } else { tema = tema_txt.Text; }

            filtros = new List<dynamic>() { usuario.GetCorreo(), tipo, dificultad, tema };
            tabla();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new CrearQuiz_2(servicio, usuario, examen);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
