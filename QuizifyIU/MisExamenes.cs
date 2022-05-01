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
            
            List<int> lista = servicio.GetExamenes(user);
            if (servicio.GetTipoEntidad(user.GetCorreo()) == "alumno")
            {
                foreach (int x in lista)
                {
                    Examen ex = servicio.GetExamenById(x);
                    if (ex.GetFechaFin() > DateTime.Now)
                    {
                        bindingListExamenDisponible.Add(new
                        {

                            titulo = ex.GetTitulo(),
                            descripcion = ex.GetDescripcion(),
                            curso = ex.GetCurso(),
                            tiempo = ex.GetTiempo(),
                            fecha_ini = ex.GetFechaIni(),
                            fecha_fin = ex.GetFechaFin(),
                            competenciaTransversal = ex.GetCompetenciaTransversal(),
                            nota = servicio.GetNota(usuario.correo, ex.GetId())
                        });
                    }
                    else
                    {
                        bindingListExamenFinalizado.Add(new
                        {

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
                tablaExamenesProfesor.Visible = true;
                tablaExamenDisponible.Visible = false;
                tablaExamenFinalizado.Visible = false ;
                foreach (int x in lista)
                {
                    Examen ex = servicio.GetExamenById(x);
                    bindingListExamenDisponible.Add(new
                    {
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
            if (servicio.GetTipoEntidad(user.GetCorreo()) == "alumno"){

                for(int i =0; i <7; i++)
                {
                    Examen ex = servicio.GetExamenById(i);
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
            if (servicio.GetTipoEntidad(user.GetCorreo()) == "alumno")
            {
                
                Examen examen = servicio.GetExamenById(int.Parse(tablaExamenDisponible.SelectedCells[0].Value.ToString()));
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
                
                    Examen examen = servicio.GetExamenById(int.Parse(tablaExamenDisponible.SelectedCells[0].Value.ToString()));
                
                
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
    }
        
}
