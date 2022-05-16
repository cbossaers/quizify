namespace QuizifyIU
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.CerrarSesion = new FontAwesome.Sharp.IconButton();
            this.Estadisticas = new FontAwesome.Sharp.IconButton();
            this.Cursos = new FontAwesome.Sharp.IconButton();
            this.Misexamenes = new FontAwesome.Sharp.IconButton();
            this.Mispreguntas = new FontAwesome.Sharp.IconButton();
            this.CrearPregunta = new FontAwesome.Sharp.IconButton();
            this.CrearQuiz = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Label();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconoForm = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.obs = new QuizifyIU.Controles_extra.label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panelMenu.Controls.Add(this.Home);
            this.panelMenu.Controls.Add(this.CerrarSesion);
            this.panelMenu.Controls.Add(this.Estadisticas);
            this.panelMenu.Controls.Add(this.Cursos);
            this.panelMenu.Controls.Add(this.Misexamenes);
            this.panelMenu.Controls.Add(this.Mispreguntas);
            this.panelMenu.Controls.Add(this.CrearPregunta);
            this.panelMenu.Controls.Add(this.CrearQuiz);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.panelMenu.Size = new System.Drawing.Size(230, 573);
            this.panelMenu.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home.IconColor = System.Drawing.Color.White;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.IconSize = 30;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(0, 411);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Home.Size = new System.Drawing.Size(230, 57);
            this.Home.TabIndex = 8;
            this.Home.Tag = "Home";
            this.Home.Text = "    Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.btnHome1_Click);
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CerrarSesion.FlatAppearance.BorderSize = 0;
            this.CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarSesion.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CerrarSesion.ForeColor = System.Drawing.Color.White;
            this.CerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.CerrarSesion.IconColor = System.Drawing.Color.White;
            this.CerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CerrarSesion.IconSize = 30;
            this.CerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CerrarSesion.Location = new System.Drawing.Point(0, 504);
            this.CerrarSesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.CerrarSesion.Size = new System.Drawing.Size(230, 52);
            this.CerrarSesion.TabIndex = 7;
            this.CerrarSesion.Tag = "Cerrar sesión";
            this.CerrarSesion.Text = "    Cerrar sesión";
            this.CerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // Estadisticas
            // 
            this.Estadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Estadisticas.FlatAppearance.BorderSize = 0;
            this.Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Estadisticas.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Estadisticas.ForeColor = System.Drawing.Color.White;
            this.Estadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.Estadisticas.IconColor = System.Drawing.Color.White;
            this.Estadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Estadisticas.IconSize = 30;
            this.Estadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Estadisticas.Location = new System.Drawing.Point(0, 354);
            this.Estadisticas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Estadisticas.Name = "Estadisticas";
            this.Estadisticas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Estadisticas.Size = new System.Drawing.Size(230, 57);
            this.Estadisticas.TabIndex = 6;
            this.Estadisticas.Tag = "Estadisticas";
            this.Estadisticas.Text = "    Estadisticas";
            this.Estadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Estadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Estadisticas.UseVisualStyleBackColor = true;
            this.Estadisticas.Click += new System.EventHandler(this.Estadisticas_Click);
            // 
            // Cursos
            // 
            this.Cursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cursos.FlatAppearance.BorderSize = 0;
            this.Cursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cursos.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cursos.ForeColor = System.Drawing.Color.White;
            this.Cursos.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.Cursos.IconColor = System.Drawing.Color.White;
            this.Cursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Cursos.IconSize = 30;
            this.Cursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cursos.Location = new System.Drawing.Point(0, 297);
            this.Cursos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cursos.Name = "Cursos";
            this.Cursos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Cursos.Size = new System.Drawing.Size(230, 57);
            this.Cursos.TabIndex = 5;
            this.Cursos.Tag = "Cursos";
            this.Cursos.Text = "     Cursos";
            this.Cursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cursos.UseVisualStyleBackColor = true;
            this.Cursos.Click += new System.EventHandler(this.Cursos_Click);
            // 
            // Misexamenes
            // 
            this.Misexamenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Misexamenes.FlatAppearance.BorderSize = 0;
            this.Misexamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Misexamenes.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Misexamenes.ForeColor = System.Drawing.Color.White;
            this.Misexamenes.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.Misexamenes.IconColor = System.Drawing.Color.White;
            this.Misexamenes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Misexamenes.IconSize = 30;
            this.Misexamenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Misexamenes.Location = new System.Drawing.Point(0, 240);
            this.Misexamenes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Misexamenes.Name = "Misexamenes";
            this.Misexamenes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Misexamenes.Size = new System.Drawing.Size(230, 57);
            this.Misexamenes.TabIndex = 4;
            this.Misexamenes.Tag = "Mis examenes";
            this.Misexamenes.Text = "    Mis examenes";
            this.Misexamenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Misexamenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Misexamenes.UseVisualStyleBackColor = true;
            this.Misexamenes.Click += new System.EventHandler(this.Misexamenes_Click);
            // 
            // Mispreguntas
            // 
            this.Mispreguntas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Mispreguntas.FlatAppearance.BorderSize = 0;
            this.Mispreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mispreguntas.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mispreguntas.ForeColor = System.Drawing.Color.White;
            this.Mispreguntas.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.Mispreguntas.IconColor = System.Drawing.Color.White;
            this.Mispreguntas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Mispreguntas.IconSize = 30;
            this.Mispreguntas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mispreguntas.Location = new System.Drawing.Point(0, 183);
            this.Mispreguntas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Mispreguntas.Name = "Mispreguntas";
            this.Mispreguntas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Mispreguntas.Size = new System.Drawing.Size(230, 57);
            this.Mispreguntas.TabIndex = 3;
            this.Mispreguntas.Tag = "Mis preguntas";
            this.Mispreguntas.Text = "    Mis preguntas";
            this.Mispreguntas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mispreguntas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Mispreguntas.UseVisualStyleBackColor = true;
            this.Mispreguntas.Click += new System.EventHandler(this.Mispreguntas_Click);
            // 
            // CrearPregunta
            // 
            this.CrearPregunta.Dock = System.Windows.Forms.DockStyle.Top;
            this.CrearPregunta.FlatAppearance.BorderSize = 0;
            this.CrearPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearPregunta.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CrearPregunta.ForeColor = System.Drawing.Color.White;
            this.CrearPregunta.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.CrearPregunta.IconColor = System.Drawing.Color.White;
            this.CrearPregunta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CrearPregunta.IconSize = 30;
            this.CrearPregunta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CrearPregunta.Location = new System.Drawing.Point(0, 126);
            this.CrearPregunta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CrearPregunta.Name = "CrearPregunta";
            this.CrearPregunta.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.CrearPregunta.Size = new System.Drawing.Size(230, 57);
            this.CrearPregunta.TabIndex = 2;
            this.CrearPregunta.Tag = "Crear Pregunta";
            this.CrearPregunta.Text = "    Crear Pregunta";
            this.CrearPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CrearPregunta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CrearPregunta.UseVisualStyleBackColor = true;
            this.CrearPregunta.Click += new System.EventHandler(this.CrearPregunta_Click);
            // 
            // CrearQuiz
            // 
            this.CrearQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.CrearQuiz.FlatAppearance.BorderSize = 0;
            this.CrearQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearQuiz.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CrearQuiz.ForeColor = System.Drawing.Color.White;
            this.CrearQuiz.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.CrearQuiz.IconColor = System.Drawing.Color.White;
            this.CrearQuiz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CrearQuiz.IconSize = 30;
            this.CrearQuiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CrearQuiz.Location = new System.Drawing.Point(0, 69);
            this.CrearQuiz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CrearQuiz.Name = "CrearQuiz";
            this.CrearQuiz.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.CrearQuiz.Size = new System.Drawing.Size(230, 57);
            this.CrearQuiz.TabIndex = 1;
            this.CrearQuiz.Tag = "Crear Quiz";
            this.CrearQuiz.Text = "    Crear Quiz";
            this.CrearQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CrearQuiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CrearQuiz.UseVisualStyleBackColor = true;
            this.CrearQuiz.Click += new System.EventHandler(this.CrearQuiz_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.AutoSize = true;
            this.btnHome.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Snow;
            this.btnHome.Location = new System.Drawing.Point(36, 18);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(106, 32);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Quizify";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(101)))), ((int)(((byte)(245)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(173, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(57, 69);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.iconoForm);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(230, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(754, 69);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconoForm
            // 
            this.iconoForm.BackColor = System.Drawing.Color.White;
            this.iconoForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.iconoForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconoForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.iconoForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconoForm.IconSize = 37;
            this.iconoForm.Location = new System.Drawing.Point(13, 15);
            this.iconoForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconoForm.Name = "iconoForm";
            this.iconoForm.Size = new System.Drawing.Size(37, 37);
            this.iconoForm.TabIndex = 6;
            this.iconoForm.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Location = new System.Drawing.Point(57, 23);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(48, 17);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Home";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(663, 3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinimize.Size = new System.Drawing.Size(28, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 25;
            this.btnMaximize.Location = new System.Drawing.Point(692, 3);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnMaximize.Size = new System.Drawing.Size(33, 20);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(724, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(4, 7, 4, 3);
            this.btnClose.Size = new System.Drawing.Size(28, 21);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panelDesktop.Controls.Add(this.obs);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 69);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelDesktop.Size = new System.Drawing.Size(754, 504);
            this.panelDesktop.TabIndex = 2;
            // 
            // obs
            // 
            this.obs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.obs.BackColor = System.Drawing.SystemColors.Window;
            this.obs.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.obs.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.obs.BorderRadius = 12;
            this.obs.BorderSize = 2;
            this.obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.obs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.obs.Location = new System.Drawing.Point(241, 228);
            this.obs.Margin = new System.Windows.Forms.Padding(4);
            this.obs.Multiline = false;
            this.obs.Name = "obs";
            this.obs.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.obs.PasswordChar = false;
            this.obs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.obs.PlaceholderText = "";
            this.obs.Size = new System.Drawing.Size(250, 31);
            this.obs.TabIndex = 0;
            this.obs.Texts = "";
            this.obs.UnderlinedStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 573);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(950, 566);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton CerrarSesion;
        private FontAwesome.Sharp.IconButton Estadisticas;
        private FontAwesome.Sharp.IconButton Cursos;
        private FontAwesome.Sharp.IconButton Misexamenes;
        private FontAwesome.Sharp.IconButton Mispreguntas;
        private FontAwesome.Sharp.IconButton CrearPregunta;
        private FontAwesome.Sharp.IconButton CrearQuiz;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconPictureBox iconoForm;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Label btnHome;
        private FontAwesome.Sharp.IconButton Home;
        private Controles_extra.label obs;
    }
}

