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
    public partial class MisPreguntas : Form
    {
        private NuevoServicio servicio;
        dynamic usuario;
        List<dynamic> filtros;
        List<int> DTable;
        string tipo;
        dynamic dificultad;
        string tema;
        Pregunta2 preg;
        Form1 portal;
        DataTable datos;

        public MisPreguntas(NuevoServicio servicio,dynamic user, Form1 portal)
        {
            InitializeComponent();
            this.portal = portal;
            this.servicio = servicio;
            this.usuario = user;
            filtros = new List<dynamic>() { usuario.GetCorreo(), null, null, null };
            tabla();
        }

        private void bBuscar_Click_1(object sender, EventArgs e)
        {
            if(tipo_txt.Text == "") { tipo = null; } else { tipo = tipo_txt.Text.ToLower(); } 
            if(dificultad_txt.SelectedIndex == -1) { dificultad = null; } else { dificultad = dificultad_txt.SelectedIndex; }
            if(tema_txt.Text == "") { tema = null; } else { tema = tema_txt.Text; }
            filtros = new List<dynamic>() { usuario.GetCorreo(), tipo, dificultad, tema};
            tabla();
        }

        private void tabla()
        {
            tablaPreguntas.DataSource = servicio.GetPreguntas(filtros);
        }

        private void tablaPreguntas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.tablaPreguntas.Rows[e.RowIndex];
            int id = int.Parse(tablaPreguntas.SelectedCells[0].Value.ToString());
            int ver = int.Parse(tablaPreguntas.SelectedCells[3].Value.ToString());
            
            try { preg = servicio.GetPregunta(id, ver);
                int vers = preg.GetVersion();
            }
            catch(Exception ex) {
                MessageBox.Show(this, ex.Message.ToString(), "Error",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            }
            Principal.formportal.abrirNieto(new CrearPregunta(servicio, usuario, preg));
        }
    }
}
