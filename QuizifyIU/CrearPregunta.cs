using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizifyIU
{
    public partial class CrearPregunta : Form
    {
        public CrearPregunta()
        {
            InitializeComponent();
        }

        private void CambiaTipoPregunta(object sender, EventArgs e)
        {
            if (tipoPregunta.Text == "Test")
            {
                letraA.Visible = true; letraB.Visible = true; letraC.Visible = true;
                opcA.Visible = true; opcB.Visible = true; opcC.Visible = true;
                botonAdd.Visible = true; botonBorrar.Visible = true;
                correcta.Visible = true;
            }
            else
            {
                letraA.Visible = false; letraB.Visible = false; letraC.Visible = false; letraD.Visible = false; letraE.Visible = false;
                opcA.Visible = false; opcB.Visible = false; opcC.Visible = false; opcD.Visible = false; opcE.Visible = false;
                botonAdd.Visible = false; botonBorrar.Visible = false;
                correcta.Visible = false;
            }
        }

        private void BorrarOp(object sender, EventArgs e)
        {
            if (opcE.Visible == true)
            {
                opcE.Visible = false; letraE.Visible = false; correctaE.Visible = false;
            }
            else if (opcD.Visible == true)
            {
                opcD.Visible = false; letraD.Visible = false; correctaD.Visible = false;
            }
        }

        private void AddOpc(object sender, EventArgs e)
        {
            if(opcD.Visible != true)
            {
                opcD.Visible = true; letraD.Visible = true; correctaD.Visible = true;
            }
            else if(opcE.Visible != true)
            {
                opcE.Visible = true; letraE.Visible = true; correctaE.Visible = true;
            }
            
        }
    }
}
