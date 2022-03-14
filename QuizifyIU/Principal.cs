using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizify.Services;

namespace QuizifyIU
{
    public partial class Principal : Form
    {
        private Servicio servicio;
        public Principal(Servicio servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void biniciarS_Click(object sender, EventArgs e)
        {
            Portal formportal = new Portal(servicio);
            formportal.Show();
        }

        private void bregistrarse_Click(object sender, EventArgs e)
        {
            AbrirFormRegistrarse(new registrarse(servicio));
        }

        private void AbrirFormRegistrarse(object formRegistrarse)
        {
            registrarse formr = new registrarse(servicio);
            formr.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

    }
}
