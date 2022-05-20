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
    public partial class CalificarPregunta : Form
    {
        private NuevoServicio servicio;
        dynamic user;
        private ValueTuple<DataTable> tupla;
        public CalificarPregunta(NuevoServicio servicio, dynamic usuario, int preg)
        {
            InitializeComponent();
            this.servicio = servicio;
            user = usuario;
            //tablaExamenesProfesor.DataSource = servicio.GetExamenesProfesor(user.GetCorreo()); PREGUNTAS ALUMNO

        }

        private void EvAtras(object sender, EventArgs e)
        {
            //tirar atrás
        }

        private void EvPonerNota(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //Ventana de poner nota
                    //Principal.formportal.abrirNieto(new CrearQuiz(servicio, user, examen));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
        }
    }
}
