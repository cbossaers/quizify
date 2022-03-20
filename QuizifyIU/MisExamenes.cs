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
        public MisExamenes(Servicio servicio, dynamic usuario)
        {
            InitializeComponent();
            this.servicio = servicio;
            BindingList<object> bindingListExamenDisponible = new BindingList<object>();
            

            dynamic user = usuario;
            List<int> lista = servicio.GetExamenes(user);

            foreach (int x in lista)
            {
                Examen ex = servicio.GetExamenById(x);
                if(servicio.GetTipoEntidad(user.GetCorreo()) == "alumno" && ex.GetFechaFin() > DateTime.Now)
                {
                    bindingListExamenDisponible.Add(new
                    {
                        titulo = ex.GetTitulo(),
                        descripcion = ex.GetDescripcion(),
                        curso = ex.GetCurso(),
                        tiempo = ex.GetTiempo(),
                        fecha_ini = ex.GetFechaIni(),
                        fecha_fin = ex.GetFechaFin()
                    });;
                }
                else
                {
                    bindingListExamenDisponible.Add(new
                    {
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

        private void tablaExamenDisponible_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
