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
        private int uno,dos,tres,cuatro,cinco,seis,siete,ocho,nueve,diez = 0;

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

            for(int i = 0; i < grafico.Count; i++) {
                double t = grafico[i];
                if(t <= 1) { uno++; continue; }
                if(t <= 2) { dos++; continue; }
                if(t <= 3) { tres++; continue; }
                if(t <= 4) {cuatro++; continue; }
                if(t <= 5) {cinco++; continue; }
                if (t <= 6) { seis++; continue; }
                if (t <= 7) { siete++; continue; }
                if (t <= 8) { ocho++; continue; }
                if (t <= 9) { nueve++; continue; }
                if (t <= 10) { diez++; continue; }
            }
            int max = grafico.Count;
            progress_bar_fancy1.Maximum = max;
            progress_bar_fancy2.Maximum = max;
            progress_bar_fancy3.Maximum = max;
            progress_bar_fancy4.Maximum = max;
            progress_bar_fancy5.Maximum = max;
            progress_bar_fancy6.Maximum = max;
            progress_bar_fancy7.Maximum = max;
            progress_bar_fancy8.Maximum = max;
            progress_bar_fancy9.Maximum = max;
            progress_bar_fancy10.Maximum = max;

            progress_bar_fancy1.Value = uno;
            progress_bar_fancy2.Value = dos;
            progress_bar_fancy3.Value = tres;
            progress_bar_fancy4.Value = cuatro;
            progress_bar_fancy5.Value = cinco;
            progress_bar_fancy6.Value = seis;
            progress_bar_fancy7.Value = siete;
            progress_bar_fancy8.Value = ocho;
            progress_bar_fancy9.Value = nueve;
            progress_bar_fancy10.Value = diez;

        }
    }
}
