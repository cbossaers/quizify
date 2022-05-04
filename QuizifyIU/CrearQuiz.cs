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
        private NuevoServicio servicio;
        private dynamic usuario;
        int tiempo;
        int id = -1;
        private Examen examen;
        DateTime fecha = DateTime.Now.AddDays(1);

        public CrearQuiz(NuevoServicio servicio,dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            
            fin.Text = "5/05/2022";

        }
        public CrearQuiz(NuevoServicio servicio, dynamic user,Examen examen)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
            fin.Text = "23/03/2022";
            this.examen = examen;
            id= examen.GetId();
            pregunta = examen.GetPreguntasAsociadas();
            mostrear();
        }

        private void mostrear()
        {
            
            nombre.Text = examen.GetTitulo();
            descripcion.Text = examen.GetDescripcion();
            curso.Text = examen.GetCurso();
            ini.Text = examen.GetFechaIni().ToString();
            fin.Text = examen.GetFechaFin().ToString();
            intentos.Text = examen.GetIntentos().ToString();
            if (examen.GetTiempo()==1000)
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
            comboBoxCT.Text = examen.GetCompetenciaTransversal();
        }

        private void sinlimite_CheckedChanged(object sender, EventArgs e)
        {
            if(sinlimite.Checked) { horas.Enabled = false; minutos.Enabled = false; }
            if (!sinlimite.Checked){ horas.Enabled = true; minutos.Enabled = true; }

        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
               id = servicio.UltimoIdExamen() + 1 ;
            }
            string titulo=nombre.Text;
            string descripcio = descripcion.Text;
            string autor = usuario.GetCorreo();
            string cursos = curso.Text;
            if(sinlimite.Checked){ tiempo = 1000; }
            else {
                if(horas.Text != "") { tiempo = int.Parse(horas.Text) * 60; }
                tiempo += int.Parse(minutos.Text);}
            int intento = int.Parse(intentos.Text);
            //DateTimeOffset fecha_inicial = DateTime.Parse(ini.Text +" "+ hini) ;
            DateTime fecha_inicial = DateTime.Parse(ini.Text);
            DateTime fecha_finanl = DateTime.Parse(fin.Text);
            DateTime fecha_actual = DateTime.Now;
            string CT = comboBoxCT.Text;
            String estado = "Borrador";
              
            Examen examen = new Examen(id,titulo, descripcio,cursos,autor,tiempo,fecha_actual,fecha_inicial,fecha_finanl,intento, volver_atras, errores_restan, 0,pregunta,estado, CT);

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
