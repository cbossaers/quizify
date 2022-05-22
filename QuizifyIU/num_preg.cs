using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizifyIU
{
    public partial class num_preg : Form
    {
        public num_preg()
        {
            InitializeComponent();
        }

        private void botones_fancy1_Click(object sender, EventArgs e)
        {
            Principal.formportal.getCrear().auto(int.Parse(preguntas.Texts));
            this.Close();
        }

        private void botones_fancy2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
