using FontAwesome.Sharp;
using Quizify.Services;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace QuizifyIU
{
    public partial class Form1 : Form
    {
        private NuevoServicio servicio;
        private dynamic usuario;
        public static DataTable notificaciones;
        private Observador observador = new Observador();
        public static Notificaciones objeto_notif;
        HiloNotificaciones x = new HiloNotificaciones();
        public static CrearQuiz crear;

        private int borderSize = 2;
        private Size formSize; 
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private bool alumno = false;
        

        public Form1(NuevoServicio servicio, dynamic user)
        {
            InitializeComponent();
            this.servicio = servicio;
            //nombreIniciado.Text = user.correo;
            usuario = user;
            dataGridView1.Visible = false;
            noti2.Visible = false;
            noti1.Visible = false;
            bellN.Visible = true;
            numnoti.Visible = true;
            ver(user);
            //CollapseMenu();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244);//Border color
            
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,57);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            ActivateButton(Home, RGBColors.color3);



            objeto_notif  = new Notificaciones(this);
            objeto_notif.Subscribe(observador);
            x.HiloGetNotificaciones(usuario.GetCorreo(),this);
            CambiarIdioma();


        }
        private void ver(dynamic user)
        {
            
            if (servicio.GetTipoEntidad(Principal.user.GetCorreo()) == "alumno")
            {
                alumno = true;
                panelMenu.Controls.Clear();
                this.panelMenu.Controls.Add(this.CerrarSesion);
                this.panelMenu.Controls.Add(this.Cursos);
                this.panelMenu.Controls.Add(this.Misexamenes);
                this.panelMenu.Controls.Add(this.Home);
                this.panelMenu.Controls.Add(this.panel1);
            }
            else
            {
                abrirNieto(new Home_profesor(servicio,usuario));
                bellN.Visible = false;
                numnoti.Visible = false;
            }
        }
        public void setNotificaciones(DataTable notifs)
        {
            notificaciones = notifs;

            if (InvokeRequired) {
                this.Invoke(new Action(() => ActualizarNotificaciones()));
                return;
            }
        }
        
        private void ActualizarNotificaciones(){
            numnoti.Text = notificaciones.Rows.Count.ToString();
            dataGridView1.DataSource = notificaciones;
        }

        private void notificacciones()
        {
            //this.dataGridView1.Columns[0].Visible=false;
            bellN.Visible = false;
            numnoti.Visible = false;
            noti1.Visible = true;
            noti2.Visible = true;

            dataGridView1.Visible = true;
        }

        public void abrirNieto(Form childForm)
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
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: 
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                btnHome.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 230;
                btnHome.Visible = true;
                btnMenu.Dock = DockStyle.None;
                btnMenu.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconoForm.IconChar = currentBtn.IconChar;
                iconoForm.IconColor = Color.FromArgb(98, 102, 244);
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(98, 102, 244);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
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
            labelTitle.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconoForm.IconChar = IconChar.Home;
            iconoForm.IconColor = Color.FromArgb(98, 102, 244);
            labelTitle.Text = "Home";
        }

        //Event methods
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            if (!alumno) { abrirNieto(new Home_profesor(servicio, usuario)); }
        }
        private void btnHome1_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender, RGBColors.color3);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }if(!alumno){abrirNieto(new Home_profesor(servicio, usuario)); }
        }

        private void CrearQuiz_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            crear = new CrearQuiz(servicio, usuario);
            OpenChildForm(crear);
        }
        public CrearQuiz getCrear()
        {
            return crear;
        }

        private void CrearPregunta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new CrearPregunta(servicio, usuario));
        }

        private void Mispreguntas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new MisPreguntas(servicio, usuario, this));
        }

        private void Misexamenes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new MisExamenes(servicio, usuario));
        }

        private void Cursos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new CursoForm(servicio, usuario));
        }
        private void tienda_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new ComprarBono(servicio, usuario));
        }

        private void Estadisticas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new ComprarBono(servicio, usuario));
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Principal(servicio);
            form2.Closed += (s, args) => this.Close();
            form2.ShowDialog();
        }

        public void obsc(string x)
        {
            obs.Texts = x;
        }

        public void LlamarDataFetch(DataTable dt) {
            objeto_notif.DataFetch(dt);
        }

        private void noti1_Click(object sender, EventArgs e)
        {
            if(noti2.Visible == false)
            {
                notificacciones();
            }
            else { dataGridView1.Visible = false; noti2.Visible = false; bellN.Visible = true; noti1.Visible = false; numnoti.Visible = true; } 
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(dataGridView1.SelectedCells[1].Value.ToString());
            servicio.EliminarNotificacion(id, usuario.GetCorreo());

        }
        private void CambiarIdioma()
        {
            if(Principal.ingles == true)
            {
                CrearQuiz.Text = "Create Quiz"; CrearPregunta.Text = "Create Question"; Mispreguntas.Text = "My Questions";
                Misexamenes.Text = "My Quizzes"; Cursos.Text = "My Courses"; tienda.Text = "Shop"; CerrarSesion.Text = "Log Out";
            }
            else
            {
                CrearQuiz.Text = "Crear Quiz"; CrearPregunta.Text = "Crear Pregunta"; Mispreguntas.Text = "Mis Preguntas";
                Misexamenes.Text = "Mis Quizzes"; Cursos.Text = "Mis Cursos"; tienda.Text = "Tienda"; CerrarSesion.Text = "Cerrar Sesión";
            }
        }
    }
}
