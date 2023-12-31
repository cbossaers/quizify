﻿using System;
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
    public partial class MisExamenes : Form
    {
        private NuevoServicio servicio;
        dynamic user;
        private ValueTuple<DataTable, DataTable> tupla;
        List<dynamic> filtros;
        private bool alumno=false;
        public MisExamenes(NuevoServicio servicio, dynamic usuario)
        {
            InitializeComponent();
            this.servicio = servicio;
            BindingList<object> bindingListExamenDisponible = new BindingList<object>();
            BindingList<object> bindingListExamenFinalizado = new BindingList<object>();

            user = usuario;
            //servicio.ActualizarEstadoQuizes();
            
            if (servicio.GetTipoEntidad(user.GetCorreo()) == "alumno")
            {
                tupla = servicio.GetExamenesAlumno(user.GetCorreo());
                tablaExamenDisponible.DataSource = tupla.Item1;
                tablaExamenFinalizado.DataSource = tupla.Item2;
                alumno=true;
                puntuar.Visible = false; calificar.Visible = false; finalizar.Visible = false; cancelar.Visible = false; button1.Visible = false;
            }
            else
            {
                calificar.Visible = true;
                tablaExamenesProfesor.Visible = true;
                tablaExamenDisponible.Visible = false;
                tablaExamenFinalizado.Visible = false;
                label2.Visible = false;
                label3.Visible=false;
                tablaExamenesProfesor.DataSource = servicio.GetExamenesProfesor(user.GetCorreo());
            }
        }
        private void tablaExamenDisponible_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
            {
                Examen examen = servicio.GetExamen(int.Parse(tablaExamenDisponible.SelectedCells[0].Value.ToString()));
                if (examen != null)
                {
                    Principal.formportal.abrirNieto(new HacerExamen(servicio, user, examen));
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
        private void tablaExamenesProfesor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
            {
                Examen examen = servicio.GetExamen(int.Parse(tablaExamenesProfesor.SelectedCells[0].Value.ToString()));
                if (examen != null)
                {
                    Principal.formportal.abrirNieto(new CrearQuiz(servicio, user, examen));
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
        private void EvCalificar(object sender, EventArgs e)
        {
            if (tablaExamenesProfesor.SelectedRows != null)
            {
                try 
                {
                    BindingList<object> bindingListExamenDisponible = new BindingList<object>();
                    Examen examen = servicio.GetExamen(int.Parse(tablaExamenesProfesor.SelectedCells[0].Value.ToString()));
                    servicio.PublicarNotas(examen.GetId());
                    calificar.Visible = true;
                    tablaExamenesProfesor.Visible = true;
                    tablaExamenDisponible.Visible = false;
                    tablaExamenFinalizado.Visible = false;
                    tablaExamenesProfesor.DataSource = servicio.GetExamenesProfesor(user.GetCorreo());
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

        private void dificultadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dificultad;
            if (dificultadBox.SelectedIndex == -1)
            {
                dificultad = "";
                filtros = new List<dynamic>() { dificultad };
                tabla();
            }
            else if (dificultadBox.Text == "Todos") resetTabla();
            else
            {
                dificultad = dificultadBox.Text;
                filtros = new List<dynamic>() { dificultad };
                tabla();
            }
        }

        private void tabla()
        {
            if (servicio.GetTipoEntidad(user.GetCorreo()) == "alumno")
            {
                tupla = servicio.GetExamenesByDificultadAlumno(user.GetCorreo(), dificultadBox.Text);
                tablaExamenDisponible.DataSource = tupla.Item1;
            }
            else tablaExamenesProfesor.DataSource = servicio.GetExamenByDificultad(filtros);
        }

        private void resetTabla()
        {
            if (servicio.GetTipoEntidad(user.GetCorreo()) == "alumno")
            {
                tupla = servicio.GetExamenesAlumno(user.GetCorreo());
                tablaExamenDisponible.DataSource = tupla.Item1;
            }
            else tablaExamenesProfesor.DataSource = servicio.GetExamenesProfesor(user.GetCorreo());
        }

        private void EvPonerNota(object sender, EventArgs e)
        {
            if (tablaExamenesProfesor.SelectedRows != null)
            {
                //dsatatable.rows.count == 0
                DataTable preguntasDes = servicio.GetPreguntasDesarrolloExamen(int.Parse(tablaExamenesProfesor.SelectedCells[0].Value.ToString()));
                if (preguntasDes.Rows.Count == 0)
                {
                    MessageBox.Show(this, "Este examen no tiene preguntas de desarrollo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Principal.formportal.abrirNieto(new CalificarPregunta(servicio, user, int.Parse(tablaExamenesProfesor.SelectedCells[0].Value.ToString())));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (alumno)
            {
                Principal.formportal.abrirNieto(new Estadisticas(servicio, user, int.Parse(tablaExamenDisponible.SelectedCells[0].Value.ToString())));
            }
            else
            {
                Principal.formportal.abrirNieto(new Estadisticas(servicio, user, int.Parse(tablaExamenesProfesor.SelectedCells[0].Value.ToString())));
            }
        }

        private void EvFinalizar(object sender, EventArgs e)
        {
            servicio.FinalizarExamen(int.Parse(tablaExamenesProfesor.SelectedCells[0].Value.ToString()));
            tablaExamenesProfesor.DataSource = servicio.GetExamenesProfesor(user.GetCorreo());

        }

        private void EvCancelar(object sender, EventArgs e)
        {
            servicio.CancelarExamen(int.Parse(tablaExamenesProfesor.SelectedCells[0].Value.ToString()));
            tablaExamenesProfesor.DataSource = servicio.GetExamenesProfesor(user.GetCorreo());
        }
    }
        
}
