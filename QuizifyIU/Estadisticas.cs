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
    public partial class Estadisticas : Form
    {
        private NuevoServicio servicio;
        private dynamic usuario;
        private int id;
        public Estadisticas(NuevoServicio servicio, dynamic user,int id)
        {
            this.servicio = servicio;
            this.id = id;
            this.usuario = user;
            InitializeComponent();
            ver();
        }

        private void ver()
        {
            dataGridView1.DataSource = servicio.EstadisticasExamenPreguntas(id);
            List<dynamic> dt = servicio.EstadisticasExamen(id);
            List<double> grafico = dt[3];
            label.Text = dt[0].ToString();
            label1.Text = dt[1].ToString();
            label2.Text = dt[2].ToString();
        }
    }
}
