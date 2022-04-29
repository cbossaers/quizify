using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Quizify.Entities;
using Quizify.Services;

namespace QuizifyIU
{
    public partial class MisPreguntas : Form
    {
        private Servicio servicio;
        dynamic usuario;
        List<dynamic> filtros;
        List<int> DTable;
        string tipo;
        dynamic dificultad;
        string tema;

        public MisPreguntas(Servicio servicio,dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.usuario = user;
            filtros = new List<dynamic>() { usuario.GetCorreo(), null, null, null };
            tabla();
        }


        

        private void bBuscar_Click_1(object sender, EventArgs e)
        {
            if(tipo_txt.Text == "") { tipo = null; } else { tipo = tipo_txt.Text.ToLower(); } 
            if(dificultad_txt.SelectedIndex == -1) { dificultad = null; } else { dificultad = dificultad_txt.SelectedIndex; }
            if(tema_txt.Text == "") { tema = null; } else { tema = tema_txt.Text; }

            filtros = new List<dynamic>() { usuario.GetCorreo(), tipo, dificultad, tema};
            tabla();
        }
        private void tabla()
        {
            DTable = servicio.GetPreguntas(filtros);
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
            tablaPreguntas.DataSource = bindinglist;
        }

        private void tablaPreguntas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            var form2 = new CrearPregunta(servicio, usuario, int.Parse(tablaPreguntas.SelectedCells[0].Value.ToString()), int.Parse(tablaPreguntas.SelectedCells[3].Value.ToString()), tablaPreguntas.SelectedCells[2].Value.ToString().ToLower());
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
