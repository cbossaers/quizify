using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizify.Entities;
using Quizify.Services;
using QuizifyClases.BusinessLogic.Entities;

namespace QuizifyIU
{
    public partial class Principal : Form
    {
        public static NuevoServicio servicio;
        public static Form1 formportal;
        public static dynamic user;

        private int borderSize = 2;
        private Size formSize;

        private Form currentChildForm;

        public Principal(NuevoServicio servicio)
        {
            InitializeComponent();
            Principal.servicio = servicio;
            this.ActiveControl = emailField;
        }

        private void biniciarS_Click(object sender, EventArgs e) { logUser(); }

        private void bregistrarse_Click(object sender, EventArgs e) { OpenChildForm(new registrarse(servicio)); }

        

        private void Principal_Load(object sender, EventArgs e) {}

        public void logUser() {

             user = null;

            try { user = servicio.GetAlumno(emailField.Texts); } 
            catch (Exception) {
                try { user = servicio.GetProfesor(emailField.Texts); Singleton.getInstancia(); } 
                catch (Exception) { DialogResult answer = MessageBox.Show(this, "Esta persona no está registrada", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (user.GetContraseña().Equals(contraField.Texts)) {
                servicio.HiloEstadoQuizes();
                this.Hide(); 
                formportal = new Form1(servicio,user);
                formportal.ShowDialog();
                this.Close();
            } else {
                DialogResult answer = MessageBox.Show(this, "Contraseña incorrecta",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        private void Form3_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void biniciarS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logUser();
            }
        }
    }

}
