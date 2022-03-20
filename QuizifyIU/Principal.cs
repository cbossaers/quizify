using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizify.Entities;
using Quizify.Services;

namespace QuizifyIU
{
    public partial class Principal : Form
    {
        private Servicio servicio;
        Portal formportal;
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
            formportal = new Portal(servicio, formportal);
            formportal.Show();
            logUser();
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

        public void logUser()
        {
            Profesor prof = servicio.GetProfesorById(emailField.Text);
            Alumno alum = servicio.GetAlumnoById(emailField.Text);
            if(prof != null)
            {
                if (prof.contraseña.Equals(contraField.Text))
                {
                    //formportal = new Portal(servicio, prof);
                    //formportal.ShowDialog();
                }
                else
                {
                    DialogResult answer = MessageBox.Show(this, "Email o contraseña incorrectos",
                                                            "Error", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Exclamation);
                }
            }
            else if (alum != null)
            {
                if (alum.contraseña.Equals(contraField.Text))
                {
                    //formportal = new Portal(servicio, alum);
                    //formportal.ShowDialog();
                }
                else
                {
                    DialogResult answer = MessageBox.Show(this, "Email o contraseña incorrectos",
                                                            "Error", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                DialogResult answer = MessageBox.Show(this, "Este email no está registrado",
                                                            "Error", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Exclamation);
            }
        }
    }
}
