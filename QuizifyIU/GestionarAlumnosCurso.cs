using Quizify.Entities;
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
    public partial class GestionarAlumnosCurso : Form
    {
        private Servicio servicio;
        private Curso curso;
        private GestionarAlumnosCurso control;
        private dynamic usuario;
        public GestionarAlumnosCurso(Servicio servicio, GestionarAlumnosCurso control, Curso curso, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.curso = curso;
            usuario = user;
            actualizarTabla();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            eliminarAlumno();
            actualizarTabla();
        }


        private void eliminarAlumno()
        {
            string correoAl = tablaAlumnoCurso.SelectedRows[0].Cells["Correo"].Value.ToString();
            string codCurso = curso.GetCodigo();
            string profesor = usuario.correo;
            servicio.EliminarAlumnoDeCurso(correoAl, codCurso, profesor);
            curso.GetListaAlumnos().Remove(correoAl);
        }

        private void actualizarTabla()
        {
            BindingList<object> bindingListAlumnosCurso = new BindingList<object>();

            List<string> lista = curso.GetListaAlumnos();

            foreach (string x in lista)
            {
                Alumno al = servicio.GetEntidadById(x);

                bindingListAlumnosCurso.Add(new
                {
                    correo = al.GetCorreo(),
                    nombre = al.GetNombre(),
                    /*apellidos = al.Getapellidos()*/
                }); ;

            }
            tablaAlumnoCurso.DataSource = bindingListAlumnosCurso;
        }

    }
}
