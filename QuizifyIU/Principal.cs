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
        private NuevoServicio servicio;
        Portal formportal;
        public Principal(NuevoServicio servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private void label1_Click(object sender, EventArgs e) {}

        private void biniciarS_Click(object sender, EventArgs e) { logUser(); }

        private void bregistrarse_Click(object sender, EventArgs e) { AbrirFormRegistrarse(); }

        private void AbrirFormRegistrarse()
        {
            registrarse formr = new registrarse(servicio);
            formr.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e) {}

        public void logUser() {

            dynamic user = null;

            try { user = servicio.GetAlumno(emailField.Text); } 
            catch (Exception) {
                try { user = servicio.GetProfesor(emailField.Text); } 
                catch (Exception ex) { DialogResult answer = MessageBox.Show(this, "" + ex, 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (user.GetContraseña().Equals(contraField.Text)) {
                this.Hide();
                formportal = new Portal(servicio, formportal, user);
                formportal.ShowDialog();
            } else {
                DialogResult answer = MessageBox.Show(this, "Contraseña incorrecta",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
