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
        public MisExamenes(Servicio servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
            BindingList<object> bindingList = new BindingList<object>();
            for (int i = 0; i < 2; i++)
            {
                bindingList.Add(new
                {
                    examen = "hola",
                    asignatura = "PSW",
                    tiempo = "12",
                    inicio = "1",
                    fin = "3"
                });
            }
            BindingList<object> bindingList2 = new BindingList<object>();
            for (int i = 0; i < 5; i++)
            {
                bindingList2.Add(new
                {
                    examen = "suuu",
                    asignatura = "PdadSW",
                    tiempo = "12dd",
                    inicio = "1342",
                    fin = "2342343"
                });
            }
            tablaExamenDisponible.DataSource = bindingList;
            tablaExamenResuelto.DataSource = bindingList2;
        }

        private void tablaExamenDisponible_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
