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
        public MisPreguntas(Servicio servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }


        private void bBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscador = buscadorBox.Text;
            int id = int.Parse(textoBuscador);
            //List<Pregunta> preguntas = (List<Pregunta>)servicio.GetPreguntas();
            //tablaPreguntas.DataSource = preguntas;
            if ((servicio.GetPreguntaTestById(id, 1) != null) || (servicio.GetPreguntaVFById(id, 1) != null))
            { }
        }

        
    }
}
