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
        private NuevoServicio servicio;
        private Curso curso;
        private GestionarAlumnosCurso control;
        private dynamic usuario;
        public GestionarAlumnosCurso(NuevoServicio servicio, GestionarAlumnosCurso control, Curso curso, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            this.curso = curso;
            usuario = user;
            actualizarTabla();
            bEliminar.Enabled = false;
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            eliminarAlumno();
            actualizarTabla();
        }


        private void eliminarAlumno()
        {
            try
            {
                string codCurso = curso.GetCodigo();
                string correoAl = tablaAlumnoCurso.SelectedRows[0].Cells["Correo"].Value.ToString();
                string profesor = usuario.correo;
                servicio.EliminarAlumnoDeCurso(correoAl, codCurso, profesor);
                curso.GetListaAlumnos().Remove(correoAl);
            }
            catch (Exception ex)
            {
                DialogResult aviso = MessageBox.Show(this, ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        }

        private void actualizarTabla()
        {
            try
            {
                BindingList<object> bindingListAlumnosCurso = new BindingList<object>();

                List<string> lista = curso.GetListaAlumnos();

                foreach (string x in lista)
                {
                    Alumno al = servicio.GetAlumno(x);

                    bindingListAlumnosCurso.Add(new
                    {
                        correo = al.GetCorreo(),
                        nombre = al.GetNombre(),
                        apellidos = al.GetApellidos()
                    });

                }
                tablaAlumnoCurso.DataSource = bindingListAlumnosCurso;
            }
            catch(Exception ex)
            {
                DialogResult aviso = MessageBox.Show(this, ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }   
        }

        private void tablaAlumnoCurso_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                BindingList<object> bindingListAlumnosCurso = new BindingList<object>();

                List<string> lista = curso.GetListaAlumnos();

                foreach (string x in lista)
                {
                    Alumno al = servicio.GetAlumno(x);

                    bindingListAlumnosCurso.Add(new
                    {
                        correo = al.GetCorreo(),
                        nombre = al.GetNombre(),
                        apellidos = al.GetApellidos()
                    });

                }
                tablaAlumnoCurso.DataSource = bindingListAlumnosCurso;
            }
            catch (Exception ex)
            {
                DialogResult aviso = MessageBox.Show(this, ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        }
    }
}
