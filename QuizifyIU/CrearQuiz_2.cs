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
            BindingList<object> bindinglist = new BindingList<object>();


            for (int i = 0; i < DTable.Count; i += 3)
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
                        ds_autor = preg.GetAutor()
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
                        ds_autor = preg.GetAutor()
                    });
                }

            }
            dataGridView1.DataSource = bindinglist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                var form2 = new CrearQuiz_3(servicio, usuario, examen);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            
                
            
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            List<int> lista = examen.GetPreguntasAsociadas();
            lista[e.RowIndex+2]= int.Parse(dataGridView1.SelectedCells[6].Value.ToString());
            //dataGridView1.SelectedCells[1].Value = lista[e.RowIndex + 2];
            examen.SetPreguntasAsociadas(lista);
        }
        private void crear_Click(object sender, EventArgs e)
        {
            
            servicio.AddExamen(examen);
            MessageBox.Show(this, "Se ha creado el examen", "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
            this.Hide();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new CrearPregunta(servicio, usuario, int.Parse(dataGridView1.SelectedCells[0].Value.ToString()), int.Parse(dataGridView1.SelectedCells[3].Value.ToString()), dataGridView1.SelectedCells[2].Value.ToString().ToLower());
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void anular_Click(object sender, EventArgs e)
        {

        }
    }
}

