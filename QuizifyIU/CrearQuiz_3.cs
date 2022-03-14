using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizifyIU
{
    public partial class CrearQuiz_3 : Form
    {
        public CrearQuiz_3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection(Properties.Settings.Default.conexion);
            String query = "select * from preguntas where " + comboBox1.Text + " like '%" + textBox1.Text + "%'";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);

            con.Open();

            DataSet data = new DataSet();

            ada.Fill(data, "preguntas");

            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "preguntas";
            
             */
        }
    }
}
