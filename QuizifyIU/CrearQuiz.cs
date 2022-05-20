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
    
    public partial class CrearQuiz : Form
    {
        
        int volver_atras = 0, errores_restan = 0, mostrar_resultados = 0, recu = 0;
        List<int> pregunta = new List<int>();
        private NuevoServicio servicio;
        private dynamic usuario;
        int tiempo;
        int id = -1;
        private Examen examen;
        private Profesor profe;

        public CrearQuiz(NuevoServicio servicio,dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            profe = servicio.GetProfesor(usuario.correo);
            fin.Value = DateTime.Now.AddDays(1);
            setear_cursos();

        }
        public CrearQuiz(NuevoServicio servicio, dynamic user,Examen examen)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            //fin.Value = DateTime.Now.AddDays(1);
            setear_cursos();
            this.examen = examen;
            id= examen.GetId();
            pregunta = examen.GetPreguntasAsociadas();
            rela.Visible = false;
            recuperación.Visible = false;
            mostrear();
        }

        private void setear_cursos()
        {
            List<string> list = servicio.GetCursosProfesor(usuario.GetCorreo());
            curso.Items.Clear();
            foreach (string s in list)
            {
                curso.Items.Add(s);
            }
        }

        private void sinlimite_CheckedChanged(object sender, EventArgs e)
        {
            if(sinlimite.Checked) { horas.Enabled = false; minutos.Enabled = false; }
            if (!sinlimite.Checked){ horas.Enabled = true; minutos.Enabled = true; }

        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            if (profe.GetQuizes() == 0)
            {
                DialogResult noQuedanQuizes = MessageBox.Show(this, "Necesitas bonos para poder crear un examen. Accede a la tienda para poder comprar más bonos", "¡No te quedan bonos!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (id == -1) { id = servicio.UltimoIdExamen() + 1; }

                string titulo = nombre.Text;
                string descripcio = descripcion.Text;
                string autor = usuario.GetCorreo();
                string cursos = curso.Text;
                int intento = 1;
                tiempo = 0;
                if (sinlimite.Checked) { tiempo = 999; }
                else
                {
                    if (horas.Text != "") { tiempo = int.Parse(horas.Text) * 60; }
                    try { tiempo += int.Parse(minutos.Text); }
                    catch (Exception)
                    {
                        DialogResult answer = MessageBox.Show(this, "Formato de tiempo incorrecto",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                try { intento = int.Parse(intentos.Text); }
                catch (Exception)
                {
                    DialogResult answer = MessageBox.Show(this, "Formato de intentos incorrecto",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //DateTimeOffset fecha_inicial = DateTime.Parse(ini.Text +" "+ hini) ;
                DateTime fecha_inicial = new DateTime(ini.Value.Year, ini.Value.Month, ini.Value.Day, hini.Value.Hour, hini.Value.Minute, hini.Value.Second);
                DateTime fecha_finanl = new DateTime(fin.Value.Year, fin.Value.Month, fin.Value.Day, hfin.Value.Hour, hfin.Value.Minute, hfin.Value.Second);
                DateTime fecha_actual = DateTime.Now;
                string CT = comboBoxCT.Text;
                String estado = "Inactivo";
                string difi = dificultad.Text;

                int bonos = profe.GetQuizes() - 1;
                servicio.AlterarBonos(profe.correo, bonos);

                Examen examen = new Examen(id, titulo, descripcio, cursos, autor, tiempo, fecha_actual, fecha_inicial, fecha_finanl, intento, volver_atras, errores_restan, 0, pregunta, estado, difi, CT);

                Principal.formportal.abrirNieto(new CrearQuiz_2(servicio, usuario, examen));
            }
            
        }
        private void mostrear()
        {

            nombre.Text = examen.GetTitulo();
            descripcion.Text = examen.GetDescripcion();
            curso.Text = examen.GetCurso();
            ini.Text = examen.GetFechaIni().ToString();
            fin.Text = examen.GetFechaFin().ToString();
            intentos.Text = examen.GetIntentos().ToString();
            if (examen.GetTiempo() == 1000)
            {
                sinlimite.Checked = true;
                horas.Enabled = false; minutos.Enabled = false;
            }
            else
            {
                minutos.Text = examen.GetTiempo().ToString();
            }

            if (examen.GetVolverAtras() == 1)
            {
                toggle_button1.Checked = true;
            }
            if (examen.GetErroresRestan() == 1)
            {
                toggle_button2.Checked = true;
            }
            if (examen.GetMostrarResultados() == 1)
            {
                toggle_button3.Checked = true;
            }
            dificultad.Text = examen.GetDificultad();
            comboBoxCT.Text = examen.GetCompetenciaTransversal();
        }

        private void intentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            siguiente.Enabled = true;
        }

        private void toggle_button1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_button1.Checked)
            {
                volver_atras = 1;
            }
            else { volver_atras = 0; }
        }

        private void recuperación_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_button1.Checked)
            {
                recu = 1;
            }
            else { recu = 0; }
        }

        private void toggle_button2_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_button1.Checked)
            {
                errores_restan = 1;
            }
            else { errores_restan = 0; }
        }

        private void toggle_button3_CheckedChanged(object sender, EventArgs e)
        {
            if (toggle_button1.Checked)
            {
                mostrar_resultados = 1;
            }
            else { mostrar_resultados = 0; }
        }
    }
}
