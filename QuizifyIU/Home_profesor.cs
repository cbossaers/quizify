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
    public partial class Home_profesor : Form
    {
        private NuevoServicio servicio;
        private dynamic usuario;
        public Home_profesor(NuevoServicio servicio,dynamic usuario)
        {
            this.servicio = servicio;
            this.usuario = usuario;
            InitializeComponent();
            setearcusos();
        }
        private void setearcusos()
        {
            List<string> curso = servicio.GetCursosProfesor(usuario.GetCorreo());
            for (int i = 0; i < curso.Count; i++)
            {
                cursos.Items.Add(curso[i]);
            }
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            servicio.EnviarMensaje(mensaje.Texts, cursos.Text, usuario.GetCorreo());
        }
    }
}
