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
    public partial class MisExamenes : Form
    {
        private NuevoServicio servicio;
        dynamic user;
        private ValueTuple<DataTable, DataTable> tupla;
        List<dynamic> filtros;
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
            }
            else
            {
                calificar.Visible = true;
                tablaExamenesProfesor.Visible = true;
                tablaExamenDisponible.Visible = false;
                tablaExamenFinalizado.Visible = false;
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
                    List<int> lista = servicio.GetExamenesProfesor(user.GetCorreo());
                    calificar.Visible = true;
                    tablaExamenesProfesor.Visible = true;
                    tablaExamenDisponible.Visible = false;
                    tablaExamenFinalizado.Visible = false;
                    foreach (int x in lista)
                    {
                        Examen ex = servicio.GetExamen(x);
                        bindingListExamenDisponible.Add(new
                        {
                            id = ex.GetId(),
                            estado = ex.GetEstado(),
                            titulo = ex.GetTitulo(),
                            descripcion = ex.GetDescripcion(),
                            curso = ex.GetCurso(),
                            tiempo = ex.GetTiempo(),
                            fecha_ini = ex.GetFechaIni(),
                            fecha_fin = ex.GetFechaFin(),
                            ct = ex.GetCompetenciaTransversal(),
                            dificultad = ex.GetDificultad()
                        });

                    }
                    tablaExamenesProfesor.DataSource = bindingListExamenDisponible;
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

        private void tunometecabra_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dificultad = tunometecabra.Text;
            if (tunometecabra.SelectedIndex == -1) { dificultad = ""; } else { dificultad = tunometecabra.SelectedIndex.ToString(); }
            filtros = new List<dynamic>() { dificultad };
            tabla();
        }
        private void tabla()
        {
            tablaExamenesProfesor.DataSource = servicio.GetExamenByDificultad(filtros);
        }
    }
        
}
