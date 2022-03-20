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
    public partial class CrearQuiz : Form
    {
        private Servicio servicio;
        public CrearQuiz(Servicio servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private void a1_Click(object sender, EventArgs e)
        {
            a1.Enabled = false;
            b1.Enabled = true;
            b1.Focus();
            

        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.Enabled = false;
            a1.Enabled = true;
            a1.Focus();
        }

        private void sinlimite_CheckedChanged(object sender, EventArgs e)
        {
            if(sinlimite.Checked) { horas.Enabled = false; minutos.Enabled = false; b1.Visible = false; a1.Visible = false; b1.Enabled = false; mostrar.Visible = false; }
            if (!sinlimite.Checked){ horas.Enabled = true; minutos.Enabled = true; a1.Visible = true; b1.Visible = true;  b1.Enabled = false; mostrar.Visible = true; }
        }

        private void siguiente_Click(object sender, EventArgs e)
        {

        }
    }
}
