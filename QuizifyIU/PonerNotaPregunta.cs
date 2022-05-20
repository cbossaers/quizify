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
    public partial class PonerNotaPregunta : Form
    {
        private NuevoServicio servicio;
        dynamic user;
        public PonerNotaPregunta(NuevoServicio servicio, dynamic usuario, string preg)
        {
            InitializeComponent();
            this.servicio = servicio;
            user = usuario;
            //set respuesta
        }

        private void EvCalificar(object sender, EventArgs e)
        {
            try
            {
                int notaInt = int.Parse(nota.Text);
                //if nota entre valores
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Introduce una nota válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //if tiene nota escrita y con sentido calificar y cerrar forms
        }
    }
}
