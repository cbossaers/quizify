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
        private Servicio servicio;
        dynamic user;

        public MisExamenes(Servicio servicio, dynamic usuario)
        {
            InitializeComponent();
            this.servicio = servicio;
            BindingList<object> bindingListExamenDisponible = new BindingList<object>();
            

            user = usuario;
            
            List<int> lista = servicio.GetExamenes(user);

            foreach (int x in lista)
            {
                Examen ex = servicio.GetExamenById(x);
                if(servicio.GetTipoEntidad(user.GetCorreo()) == "alumno" && ex.GetFechaFin() > DateTime.Now)
                {
                    bindingListExamenDisponible.Add(new
                    {
                        id = ex.GetId(),
                        titulo = ex.GetTitulo(),
                        descripcion = ex.GetDescripcion(),
                        curso = ex.GetCurso(),
                        tiempo = ex.GetTiempo(),
                        fecha_ini = ex.GetFechaIni(),
                        fecha_fin = ex.GetFechaFin()
                    }) ;;
                }
                else if(servicio.GetTipoEntidad(user.GetCorreo()) == "profesor")
                {
                    bindingListExamenDisponible.Add(new
                    {
                        id = ex.GetId(),
                        titulo = ex.GetTitulo(),
                        descripcion = ex.GetDescripcion(),
                        curso = ex.GetCurso(),
                        tiempo = ex.GetTiempo(),
                        fecha_ini = ex.GetFechaIni(),
                        fecha_fin = ex.GetFechaFin()
                    }) ; ;
                }
            }
            tablaExamenDisponible.DataSource = bindingListExamenDisponible;
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
                            fecha_fin = ex.GetFechaFin()
                        }); ;
                    }
                    
                }
                tablaExamenDisponible.DataSource = bindingListExamenDisponible;
            }
        }

        private void tablaExamenDisponible_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
