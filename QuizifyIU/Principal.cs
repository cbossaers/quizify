﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Quizify.Services;
using Quizify.Entities;

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
        public static bool ingles;
        public Singleton singleton = new Singleton();

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

            try { user = singleton.GetAlumno(emailField.Texts); } 
            catch (Exception) {
                try { user = singleton.GetProfesor(emailField.Texts); } 
                catch (Exception) { DialogResult answer = MessageBox.Show(this, "Esta persona no está registrada", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            /*
            try
            {
                Singleton.Login(user);
                Singleton s1 = Singleton.getInstancia();
                Singleton.Logout();
            }
            catch (Exception e)
            {
                DialogResult aviso = MessageBox.Show(this, e.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/

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
            Environment.Exit(Environment.ExitCode);
            Application.Exit();
        }

        private void biniciarS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logUser();
            }
        }
        private void EvCambiarIdioma(object sender, EventArgs e)
        {
            if (idioma.Checked == true)
            {
                ingles = true;
                label1.Text = "Welcome to Quizify"; label7.Text = "Log In"; contraField.PlaceholderText = "Password"; biniciarS.Text = "Log In";
                label4.Text = "You dont have an acount yet?"; bregistrarse.Text = "Sign in";
            }
            else
            {
                ingles = false;
                label1.Text = "Bienvenido a Quizify"; label7.Text = "Iniciar sesión"; contraField.PlaceholderText = "Contraseña"; biniciarS.Text = "Iniciar sesión";
                label4.Text = "¿No tienes cuenta todavía?"; bregistrarse.Text = "Registrarse";
            }
        }
    }

}
