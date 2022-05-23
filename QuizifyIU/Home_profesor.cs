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

        private TimeSpan ts = DateTime.Now.TimeOfDay;
        private System.Windows.Forms.Timer timer2;
        string formattedTimespan;
        public Home_profesor(NuevoServicio servicio,dynamic usuario)
        {
            this.servicio = servicio;
            this.usuario = usuario;
            InitializeComponent();
            setearcusos();
            CambiarIdioma();
            label3.Text = "Bienvenido, " + Principal.user.GetCorreo();
            timer2 = new System.Windows.Forms.Timer();
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 1000; // 1 second
            timer2.Start();
            formattedTimespan = ts.ToString("hh\\:mm");
            lbTiempo.Text = formattedTimespan;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ts = DateTime.Now.TimeOfDay;
            formattedTimespan = ts.ToString("hh\\:mm");
            lbTiempo.Text = formattedTimespan;
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
        private void CambiarIdioma()
        {
            if (Principal.ingles == true)
            {
                nombre_quiz.Text = "Message for course students";
                enviar.Text = "Send Message";
            }
            else
            {
                nombre_quiz.Text = "Mensaje para los alumnos del curso";
                enviar.Text = "Enviar Mensaje";
            }
        }
    }
}
