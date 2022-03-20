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
            try
            {
                dynamic user = servicio.GetEntidadById(emailField.Text);
                if (user.contraseña.Equals(contraField.Text))
                {
                    formportal = new Portal(servicio, formportal, user);
                    formportal.ShowDialog();
                }
                else
                {
                    DialogResult answer = MessageBox.Show(this, "Contraseña incorrecta, inténtelo de nuevo.",
                                                            "Error", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Exclamation);
                }
                
            }
            
            catch (Exception ex)
            {
                DialogResult answer = MessageBox.Show(this, "Este email no está registrado.",
                                                            "Error", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Exclamation);
            }
        }

    }
}
