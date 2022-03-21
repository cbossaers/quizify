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
        
        List<dynamic> filtros = new List<dynamic>() { "angel",null,null,null };
        private Servicio servicio;
        private dynamic usuario;
        private Examen examen;
        public bool crearquiz = false;
        public CrearQuiz_3(Servicio servicio, dynamic user,Examen examen)
        {
            InitializeComponent();
            
            this.servicio = servicio;
            this.usuario = user;
            //filtros[0] = usuario.nombre;
            tabla();
            this.examen = examen;
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
            List<int> DTable = servicio.GetPreguntas(filtros);
            BindingList<object> bindinglist = new BindingList<object>();


            for (int i = 0; i < DTable.Count; i += 2)
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
                        ds_autor = filtros[0]
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
                        ds_autor = filtros[0]
                    });
                }

            }
            dataGridView1.DataSource = bindinglist;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView1.SelectedCells[0].Value.ToString();
            List<int> lista = examen.GetPreguntasAsociadas();
            lista.Add(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
            lista.Add(int.Parse(dataGridView1.SelectedCells[3].Value.ToString()));
            lista.Add(1);
            examen.SetPreguntasAsociadas(lista);
            /*this.Hide();
            var form2 = new CrearQuiz_2(servicio, usuario, examen);
            form2.Closed += (s, args) => this.Close();
            form2.Show();*/

            try{
                using (CrearQuiz_2 ventanaAlta = new CrearQuiz_2(servicio, usuario, examen))
                    ventanaAlta.ShowDialog();
            }catch(Exception ex){
                DialogResult answer = MessageBox.Show(this, ex.ToString(),
                                            "Exito", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

            }
                
            
            


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
    }
}
