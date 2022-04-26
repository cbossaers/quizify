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
    public partial class GestionarCurso : Form
    {
        private Servicio servicio;
        private dynamic usuario;
        public GestionarCurso(Servicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            AbrirFormCurso(new CursoForm(servicio, usuario));
        }

        private void AbrirFormCurso(object formCurso)
        {
            if (this.panelGestionarCurso.Controls.Count > 0)
                this.panelGestionarCurso.Controls.RemoveAt(0);
            Form fC = formCurso as Form;
            fC.TopLevel = false;
            fC.Dock = DockStyle.Fill;
            this.panelGestionarCurso.Controls.Add(fC);
            this.panelGestionarCurso.Tag = fC;
            fC.Show();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            EliminarCurso();
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            profeAñadeAlumno();
        }

        private void profeAñadeAlumno()
        {
            string curso = cursoBox.Text;
            string alumno = alumnoBox.Text;
            string profesor = usuario.nombre;
            servicio.AddAlumnoACurso(alumno, curso, profesor);
        }

        private void EliminarCurso()
        {
            string curso = cursoBox.Text;
            string profesor = usuario.nombre;
            servicio.EliminarCurso(curso, profesor);
        }
    }
}
