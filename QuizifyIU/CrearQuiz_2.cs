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
    public partial class CrearQuiz_2 : Form
    {
        private Servicio servicio;
        private dynamic usuario;
        public CrearQuiz_2(Servicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            usuario = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (HacerExamen2 ventanaAlta = new CrearQuiz_3(servicio))
                ventanaAlta.ShowDialog();
        }
    }
}
