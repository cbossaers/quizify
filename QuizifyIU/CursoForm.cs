using Quizify.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuizifyIU;
using Quizify.Entities;

namespace QuizifyIU
{
    public partial class CursoForm : Form
    {
        private NuevoServicio servicio;
        private dynamic usuario;
        
        public CursoForm(NuevoServicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;


            if (servicio.GetTipoEntidad(user.GetCorreo()) == "alumno")
            {
                bGestionarCurso.Visible = false;
                bCrearCurso.Visible = false;
                List<String> DTable = servicio.GetCursosAlumno(user.GetCorreo());
                DataTable dt = new DataTable();
                dt.Clear();
                dt.Columns.Add("Mis Cursos");
                foreach(string t in DTable)
                {
                    DataRow _ravi = dt.NewRow();
                    _ravi["Mis Cursos"] = t;
                    dt.Rows.Add(_ravi);
                }
                dataGridview1.DataSource = dt;
            }
            else { bApuntarse.Visible = false;miscursos.Visible = false; }
            /*try
            {
                BindingList<object> bindingListMisCursos = new BindingList<object>();

                List<string> lista = servicio.GetCursosProfesor(usuario.correo);

                foreach (string x in lista)
                {
                    Curso cu = servicio.GetCurso(x, usuario.correo);

                    bindingListMisCursos.Add(new
                    {
                        cod = cu.GetCodigo(),
                        nombre = cu.GetNombre(),
                        numAl = cu.GetNumAlumnos(),
                        fechaCreacion = cu.GetFechaCreacion(),
                        maxAl = cu.GetMaxAlumnos()
                    }); ;

                }
                dataGridview1.DataSource = bindingListMisCursos;
            }
            catch (Exception ex)
            {
                DialogResult aviso = MessageBox.Show(this, ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }*/
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new CrearCurso(servicio, usuario));
        }

        private void bGestionarCurso_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new GestionarCurso(servicio, usuario));
        }

        private void bApuntarse_Click(object sender, EventArgs e)
        {
            Principal.formportal.abrirNieto(new ApuntarseCurso(servicio, usuario));
        }
    }
}
