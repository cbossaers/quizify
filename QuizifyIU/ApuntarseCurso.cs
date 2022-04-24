using Quizify.Entities;
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
    public partial class ApuntarseCurso : Form
    {
        private Servicio servicio;
        private dynamic usuario;
        public ApuntarseCurso(Servicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
        }

        private void bApuntarse_Click(object sender, EventArgs e)
        {
            comprobarDatos();
        }

        private void comprobarDatos()
        {
            string alumno = usuario.correo;
            string codigo = codBox.Text;
            Curso cursoApuntado = servicio.GetCurso(codigo);
            string profesor = cursoApuntado.autor;
            servicio.AddAlumnoACurso(alumno, codigo, profesor);
        }
    }
}
