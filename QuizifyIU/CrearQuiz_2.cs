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
        private Servicio servicio;
        private dynamic usuario;
        private Examen examen;
        public CrearQuiz_2(Servicio servicio, dynamic user,Examen examen)
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
                if (servicio.GetTipoPregunta(DTable[i]).ToString() == "test")
                {
                    PreguntaTest preg = servicio.GetPreguntaTestById(DTable[i], DTable[i + 1]);
                    bindinglist.Add(new
                    {
                        ds_ID = preg.GetId().ToString(),
                        ds_enunciado = preg.GetEnunciado(),
                        ds_tipo = "Test",
                        ds_version = preg.GetVersion(),
                        ds_dificultad = preg.GetDificultad(),
                        ds_materia = preg.GetDificultad(),
                        ds_autor = preg.GetAutor()
                    });


                }
                else
                    if (servicio.GetTipoPregunta(DTable[i]).ToString() == "vf")
                {
                    PreguntaVF preg = servicio.GetPreguntaVFById(DTable[i], DTable[i + 1]);
                    bindinglist.Add(new
                    {
                        ds_ID = preg.GetId().ToString(),
                        ds_enunciado = preg.GetEnunciado(),
                        ds_tipo = "VF",
                        ds_version = preg.GetVersion(),
                        ds_dificultad = preg.GetDificultad(),
                        ds_materia = preg.GetDificultad(),
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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.ColumnIndex == 0)
            {
                string value = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(value);
            }*/
        }

        private void crear_Click(object sender, EventArgs e)
        {
            
            servicio.AddExamen(examen);
            MessageBox.Show(this, "Se ha creado el examen", "Éxito",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
            this.Hide();
            
            

        }
    }
}

