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
        private Servicio servicio;
        List<dynamic> filtros = new List<dynamic>() { "angel",null,null,null };
        public CrearQuiz_3(Servicio servicio)
        {
            this.servicio = servicio;
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "222";

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
                    ds_autor = preg.GetTema()
                    });


                }else
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
                Console.WriteLine("dsds");
            }
            dataGridView1.DataSource = bindinglist;
            comboBox1.Text = DTable[0].ToString();
            /*Console.WriteLine(servicio.GetPreguntas(filtros).ToString());*/

            /*bindinglist.Add(new
            {
                //ds_... are DataPropertyNames defined in the DataGridView object
                //see DataGridView column definitions in Visual Studio Designer
                ID = r.Crates.First().Group.Parcel.Name,
                enunciado = r.Crates.First().Group.Date,
                Tipo = r.Crates.Count,
                ds_peso = r.CarriedWeight
            });
            bindingSource1.DataSource = bindinglist;*/


            //dataGridView1.DataMember = "preguntas";
        }
    }
}
