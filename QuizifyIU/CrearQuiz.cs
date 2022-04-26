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
        
        int volver_atras = 0, errores_restan = 0, mostrar_resultados = 0;
        List<int> pregunta = new List<int>();
        private Servicio servicio;
        private dynamic usuario;
        int tiempo;
        
        private Examen examen;

        public CrearQuiz(Servicio servicio,dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            fin.Text = "23/03/2022";

        }
        public CrearQuiz(Servicio servicio, dynamic user,Examen examen)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            fin.Text = "23/03/2022";
            this.examen = examen;
            
            mostrear();
        }

        private void mostrear()
        {
            //int id = 666;
            nombre.Text = examen.GetTitulo();
            descripcion.Text = examen.GetDescripcion();
            curso.Text = examen.GetCurso();
            ini.Text = examen.GetFechaIni().ToString();
            fin.Text = examen.GetFechaFin().ToString();
            intentos.Text = examen.GetIntentos().ToString();
            dificultad.Text = "Media";

            //DateTimeOffset fecha_inicial = DateTime.Parse(ini.Text +" "+ hini) ;
            if (examen.GetVolverAtras() == 1)
            {
                a2.Enabled = true;
                b2.Enabled = false;
            }
            if(examen.GetErroresRestan() == 1)
            {
                a3.Enabled = true;
                b3.Enabled = false;
            }
            if(examen.GetMostrarResultados() == 1)
            {
                a5.Enabled=true;
                b5.Enabled=false;
            }
        }

        private void sinlimite_CheckedChanged(object sender, EventArgs e)
        {
            if(sinlimite.Checked) { horas.Enabled = false; minutos.Enabled = false; }
            if (!sinlimite.Checked){ horas.Enabled = true; minutos.Enabled = true; }

        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            
            int id = 666;
            string titulo=nombre.Text;
            string descripcio = descripcion.Text;
            string autor = usuario.GetCorreo();
            string cursos = curso.Text;
            if(sinlimite.Checked){ tiempo = 1000; }
            else {tiempo = int.Parse(horas.Text) * 60 + int.Parse(minutos.Text);}
            int intento = int.Parse(intentos.Text);
            //DateTimeOffset fecha_inicial = DateTime.Parse(ini.Text +" "+ hini) ;
            DateTime fecha_inicial = DateTime.Parse(ini.Text);
            DateTime fecha_finanl = DateTime.Parse(fin.Text);
            DateTime fecha_actual = DateTime.Now;
            string CT = comboBoxCT.Text.ToString();
            
            
            Examen examen = new Examen(id,titulo, descripcio,cursos,autor,tiempo,fecha_actual,fecha_inicial,fecha_finanl,intento, volver_atras, errores_restan, mostrar_resultados,pregunta, CT);

            this.Hide();
            var form2 = new CrearQuiz_2(servicio, usuario, examen);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            
                
        }

        private void a3_Click(object sender, EventArgs e)
        {
            a3.Enabled = false;
            b3.Enabled = true;
            b3.Focus();
            errores_restan = 1;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.Enabled = false;
            a3.Enabled = true;
            a3.Focus();
            errores_restan = 0;
        }

        

        private void a5_Click(object sender, EventArgs e)
        {
            a5.Enabled = false;
            b5.Enabled = true;
            b5.Focus();
            mostrar_resultados = 1;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.Enabled = false;
            a5.Enabled = true;
            a5.Focus();
            mostrar_resultados = 0;
        }

        private void intentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            siguiente.Enabled = true;
        }

        private void a2_Click(object sender, EventArgs e)
        {
            
            a2.Enabled = false;
            b2.Enabled = true;
            b2.Focus();
            volver_atras = 1;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.Enabled = false;
            a2.Enabled = true;
            a2.Focus();
            volver_atras = 0;
        }


    }
}
