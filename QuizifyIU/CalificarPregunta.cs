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
        private DataTable preguntas;
        private int examen;
        private int idex;
        private int idpreg;
        private int vers;
        private string alumno;
        double puntuacion;
        public CalificarPregunta(NuevoServicio servicio, dynamic usuario, int examen)
        {
            InitializeComponent();
            this.servicio = servicio;
            user = usuario;
            this.examen = examen;
            preguntas = servicio.GetPreguntasDesarrolloExamen(examen);
            tablaExamenesProfesor.DataSource = preguntas;

        }

        private void EvAtras(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new MisExamenes(servicio, user));
        }

        private void EvPonerNota(object sender, DataGridViewCellMouseEventArgs e)
        {
            respuesta.Visible = true; nota.Visible = true; respuestabox.Visible = true; notabox.Visible = true; PonerNota.Visible = true;
            tablaExamenesProfesor.Visible = false; notaMax.Visible = true;
            try
            {
                idex = int.Parse(tablaExamenesProfesor.SelectedCells[0].Value.ToString());
                idpreg = int.Parse(tablaExamenesProfesor.SelectedCells[2].Value.ToString());
                vers = int.Parse(tablaExamenesProfesor.SelectedCells[3].Value.ToString());
                alumno = tablaExamenesProfesor.SelectedCells[1].Value.ToString();
                respuestabox.Text = tablaExamenesProfesor.SelectedCells[4].Value.ToString();
                puntuacion = servicio.GetPuntuacionDePregunta(idex, idpreg);
                notaMax.Text = "Nota máxima: " + puntuacion.ToString();
                notabox.Text = servicio.GetNotaPregunta(idex,idpreg,alumno).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message.ToString(), "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
        }

        private void EvPonerNota(object sender, EventArgs e)
        {
            
            double notaReal;
            try
            {
                
                notaReal = double.Parse(notabox.Text);
                if (notaReal >= 0 && notaReal <= puntuacion)
                {
                    servicio.CalificarDesarrollo(idex, idpreg, vers, alumno, notaReal);
                    servicio.CalcularNotaExamen(idex, alumno);
                    respuesta.Visible = false; nota.Visible = false; respuestabox.Visible = false; notabox.Visible = false; PonerNota.Visible = false;
                    tablaExamenesProfesor.Visible = true; notaMax.Visible = false;
                }
                else
                {
                    MessageBox.Show(this, "Introduce una nota válida", "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }

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

