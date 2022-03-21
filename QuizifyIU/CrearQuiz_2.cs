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
            tabla();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public void tabla()
        {
            List<int> DTable = examen.GetPreguntasAsociadas();
            

            if (DTable.Count != 0)
            {
                label1.Text = DTable[0].ToString();
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
                            ds_autor = preg.GetTema(),
                            ds_puntuacion = DTable[i+2]
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
                            ds_autor = preg.GetTema()
                        });


                    }
                    
                    dataGridView1.DataSource = bindinglist;
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CrearQuiz_3 ventanaAlta = new CrearQuiz_3(servicio, usuario, examen))
                ventanaAlta.ShowDialog();
        }
    }
}

