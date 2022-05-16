using Quizify.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuizifyIU;

namespace QuizifyIU
{
    public partial class CursoForm : Form
    {
        private NuevoServicio servicio;
        private dynamic usuario;
        
        public CursoForm(NuevoServicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            

            if (servicio.GetTipoEntidad(user.GetCorreo()) == "alumno")
            {
                bGestionarCurso.Enabled = false;
                bCrearCurso.Enabled = false;
            }
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new CrearCurso(servicio, usuario));
        }

        private void bGestionarCurso_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new GestionarCurso(servicio, usuario));
        }

        private void bApuntarse_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new ApuntarseCurso(servicio, usuario));
        }
    }
}
