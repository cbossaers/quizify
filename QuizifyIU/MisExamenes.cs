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

        public MisExamenes(NuevoServicio servicio, dynamic usuario)
        {
            InitializeComponent();
            this.servicio = servicio;
            BindingList<object> bindingListExamenDisponible = new BindingList<object>();
            BindingList<object> bindingListExamenFinalizado = new BindingList<object>();

            user = usuario;
            servicio.ActualizarEstadoQuizes();
            
            if (servicio.GetTipoEntidad(user.GetCorreo()) == "alumno")
            {
                servicio.ActualizarEstadoQuizes();
                List<int> lista = servicio.GetExamenesAlumno(user.GetCorreo());
                foreach (int x in lista)
                {
                    
                    Examen ex = servicio.GetExamen(x);
                    if (servicio.GetNota(usuario.GetCorreo(), ex.GetId()) == -1)
                    {
                        if (ex.GetEstado() == "Activo") {
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

                            });
                        }
                    }
                    //SI NO LOS HAS HECHO TIENEN QUE SALIR AQUI PLS
                    else
                    {  
                        double nota = servicio.GetNota(usuario.GetCorreo(),ex.GetId());
                        bindingListExamenFinalizado.Add(new
                        {
                            id = ex.GetId(),
                            nota = nota,
                            estado = ex.GetEstado(),
                            titulo = ex.GetTitulo(),
                            descripcion = ex.GetDescripcion(),
                            curso = ex.GetCurso(),
                            tiempo = ex.GetTiempo(),
                            fecha_ini = ex.GetFechaIni(),
                            fecha_fin = ex.GetFechaFin(),
                            ct = ex.GetCompetenciaTransversal()
                        }); 
                    }
                }
                tablaExamenDisponible.DataSource = bindingListExamenDisponible;
                tablaExamenFinalizado.DataSource = bindingListExamenFinalizado;
            }
            else
            {
                List<int> lista = servicio.GetExamenesProfesor(user.GetCorreo());
                calificar.Visible = true;
                tablaExamenesProfesor.Visible = true;
                tablaExamenDisponible.Visible = false;
                tablaExamenFinalizado.Visible = false ;
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
                        ct = ex.GetCompetenciaTransversal()
                    }); 
                    
                }
                tablaExamenesProfesor.DataSource = bindingListExamenDisponible;
            }
        }
        private void tablaExamenDisponible_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
            {
                Examen examen = servicio.GetExamen(int.Parse(tablaExamenDisponible.SelectedCells[0].Value.ToString()));
                if (examen != null)
                {
                    this.Hide();
                    var form2 = new HacerExamen(servicio, user, examen);
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
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
                    this.Hide();
                    var form2 = new CrearQuiz(servicio, user, examen);
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
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
                            ct = ex.GetCompetenciaTransversal()
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
    }
        
}
