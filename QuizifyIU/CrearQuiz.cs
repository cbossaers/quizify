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
        public CrearQuiz(Servicio servicio,dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private void sinlimite_CheckedChanged(object sender, EventArgs e)
        {
            if(sinlimite.Checked) { horas.Enabled = false; minutos.Enabled = false; b1.Visible = false; a1.Visible = false; b1.Enabled = false; mostrar.Visible = false; }
            if (!sinlimite.Checked){ horas.Enabled = true; minutos.Enabled = true; a1.Visible = true; b1.Visible = true;  b1.Enabled = false; mostrar.Visible = true; }
        }

        private void siguiente_Click(object sender, EventArgs e)
        {

        }

        private void a3_Click(object sender, EventArgs e)
        {
            a3.Enabled = false;
            b3.Enabled = true;
            b3.Focus();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.Enabled = false;
            a3.Enabled = true;
            a3.Focus();
        }

        private void a4_Click(object sender, EventArgs e)
        {
            a4.Enabled = false;
            b4.Enabled = true;
            b4.Focus();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.Enabled = false;
            a4.Enabled = true;
            a4.Focus();
        }

        private void a5_Click(object sender, EventArgs e)
        {
            a5.Enabled = false;
            b5.Enabled = true;
            b5.Focus();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.Enabled = false;
            a5.Enabled = true;
            a5.Focus();
        }

        private void a1_Click_1(object sender, EventArgs e)
        {
            a1.Enabled = false;
            b1.Enabled = true;
            b1.Focus();
        }

        private void b1_Click_1(object sender, EventArgs e)
        {
            b1.Enabled = false;
            a1.Enabled = true;
            a1.Focus();
        }

        private void a2_Click(object sender, EventArgs e)
        {
            a2.Enabled = false;
            b2.Enabled = true;
            b2.Focus();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.Enabled = false;
            a2.Enabled = true;
            a2.Focus();
        }
    }
}
