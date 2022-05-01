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
            
            
            if (servicio.GetTipoEntidad(user) == "alumno")
            {
                List<int> lista = servicio.GetExamenesAlumno(user);
                foreach (int x in lista)
                {
                    Examen ex = servicio.GetExamen(x);
                    if (ex.GetFechaFin() > DateTime.Now)
                    {
                        bindingListExamenDisponible.Add(new
                        {
                            estado = ex.GetEstado(),
                            titulo = ex.GetTitulo(),
                            descripcion = ex.GetDescripcion(),
                            curso = ex.GetCurso(),
                            tiempo = ex.GetTiempo(),
                            fecha_ini = ex.GetFechaIni(),
                            fecha_fin = ex.GetFechaFin(),
                            competenciaTransversal = ex.GetCompetenciaTransversal(),
                            
                        });
                    }
                    else
                    {
                        string nota = "-";
                        if(ex.GetEstado() == "Calificado")
                        {
                            //get nota
                        }
                        bindingListExamenFinalizado.Add(new
                        {
                            nota = nota,
                            estado = ex.GetEstado(),
                            titulo = ex.GetTitulo(),
                            descripcion = ex.GetDescripcion(),
                            curso = ex.GetCurso(),
                            tiempo = ex.GetTiempo(),
                            fecha_ini = ex.GetFechaIni(),
                            fecha_fin = ex.GetFechaFin(),
                            competenciaTransversal = ex.GetCompetenciaTransversal()

                        });
                    }
                }
                tablaExamenDisponible.DataSource = bindingListExamenDisponible;
                tablaExamenFinalizado.DataSource = bindingListExamenFinalizado;
            }
            else
            {
                List<int> lista = servicio.GetExamenesProfesor(user);
                calificar.Visible = true;
                tablaExamenesProfesor.Visible = true;
                tablaExamenDisponible.Visible = false;
                tablaExamenFinalizado.Visible = false ;
                foreach (int x in lista)
                {
                    Examen ex = servicio.GetExamen(x);
                    bindingListExamenDisponible.Add(new
                    {
                        estado = ex.GetEstado(),
                        titulo = ex.GetTitulo(),
                        descripcion = ex.GetDescripcion(),
                        curso = ex.GetCurso(),
                        tiempo = ex.GetTiempo(),
                        fecha_ini = ex.GetFechaIni(),
                        fecha_fin = ex.GetFechaFin(),
                        competenciaTransversal = ex.GetCompetenciaTransversal()
                    }); 
                    
                }
                tablaExamenesProfesor.DataSource = bindingListExamenDisponible;
            }
            
            //alumno();

        }

        private void alumno()
        {
            BindingList<object> bindingListExamenDisponible = new BindingList<object>();
            //List<int> lista = servicio.GetExamenes();
            if (servicio.GetTipoEntidad(user) == "alumno"){

                for(int i =0; i <7; i++)
                {
                    Examen ex = servicio.GetExamen(i);
                    if (ex.GetFechaFin() > DateTime.Now)
                    {
                        bindingListExamenDisponible.Add(new
                        {
                            id=i,
                            titulo = ex.GetTitulo(),
                            descripcion = ex.GetDescripcion(),
                            curso = ex.GetCurso(),
                            tiempo = ex.GetTiempo(),
                            fecha_ini = ex.GetFechaIni(),
                            fecha_fin = ex.GetFechaFin(),
                            competenciaTransversal = ex.GetCompetenciaTransversal()
                        }); ;
                    }
                    
                }
                tablaExamenDisponible.DataSource = bindingListExamenDisponible;
            }
        }

        private void tablaExamenDisponible_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (servicio.GetTipoEntidad(user) == "alumno")
            {
                
                Examen examen = servicio.GetExamen(int.Parse(tablaExamenDisponible.SelectedCells[0].Value.ToString()));
                if(examen != null)
                {
                this.Hide();
                var form2 = new HacerExamen(servicio, user,examen);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
                }
            }
            else
            {
                
                    Examen examen = servicio.GetExamen(int.Parse(tablaExamenDisponible.SelectedCells[0].Value.ToString()));
                
                
                if (examen != null)
                {
                    this.Hide();
                    var form2 = new CrearQuiz(servicio, user, examen);
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
            }
             
        }

        private void MisExamenes_Load(object sender, EventArgs e)
        {

        }

        private void EvCalificar(object sender, EventArgs e)
        {
            if (tablaExamenesProfesor.SelectedRows != null)
            {
                Examen examen = servicio.GetExamen(int.Parse(tablaExamenesProfesor.SelectedCells[0].Value.ToString()));
                //publicar nota
            }
        }
    }
        
}
