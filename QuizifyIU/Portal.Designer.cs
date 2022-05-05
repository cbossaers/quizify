namespace QuizifyIU
{
    partial class Portal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.bHome = new System.Windows.Forms.Button();
            this.hora = new System.Windows.Forms.Label();
            this.bCrearCurso = new System.Windows.Forms.Button();
            this.nombreIniciado = new System.Windows.Forms.Label();
            this.bSalir = new System.Windows.Forms.Button();
            this.bMisExamenes = new System.Windows.Forms.Button();
            this.bCrearQuiz = new System.Windows.Forms.Button();
            this.bMisPreguntas = new System.Windows.Forms.Button();
            this.bCrearPregunta = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.foticoBacana = new System.Windows.Forms.PictureBox();
            this.titulo2 = new System.Windows.Forms.Label();
            this.titulo1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuVertical.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foticoBacana)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MenuVertical.Controls.Add(this.bHome);
            this.MenuVertical.Controls.Add(this.hora);
            this.MenuVertical.Controls.Add(this.bCrearCurso);
            this.MenuVertical.Controls.Add(this.nombreIniciado);
            this.MenuVertical.Controls.Add(this.bSalir);
            this.MenuVertical.Controls.Add(this.bMisExamenes);
            this.MenuVertical.Controls.Add(this.bCrearQuiz);
            this.MenuVertical.Controls.Add(this.bMisPreguntas);
            this.MenuVertical.Controls.Add(this.bCrearPregunta);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(147, 449);
            this.MenuVertical.TabIndex = 0;
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(77, 410);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(64, 23);
            this.bHome.TabIndex = 9;
            this.bHome.Text = "Home";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Verdana Pro Cond", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hora.Location = new System.Drawing.Point(39, 18);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(57, 28);
            this.hora.TabIndex = 8;
            this.hora.Text = "hora";
            // 
            // bCrearCurso
            // 
            this.bCrearCurso.FlatAppearance.BorderSize = 0;
            this.bCrearCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCrearCurso.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCrearCurso.Location = new System.Drawing.Point(2, 296);
            this.bCrearCurso.Name = "bCrearCurso";
            this.bCrearCurso.Size = new System.Drawing.Size(141, 40);
            this.bCrearCurso.TabIndex = 7;
            this.bCrearCurso.Text = "Cursos";
            this.bCrearCurso.UseVisualStyleBackColor = true;
            this.bCrearCurso.Click += new System.EventHandler(this.bCrearCurso_Click);
            // 
            // nombreIniciado
            // 
            this.nombreIniciado.AutoSize = true;
            this.nombreIniciado.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreIniciado.Location = new System.Drawing.Point(15, 72);
            this.nombreIniciado.Name = "nombreIniciado";
            this.nombreIniciado.Size = new System.Drawing.Size(53, 18);
            this.nombreIniciado.TabIndex = 6;
            this.nombreIniciado.Text = "usuario";
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(15, 414);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(44, 23);
            this.bSalir.TabIndex = 4;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bMisExamenes
            // 
            this.bMisExamenes.FlatAppearance.BorderSize = 0;
            this.bMisExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMisExamenes.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMisExamenes.Location = new System.Drawing.Point(3, 248);
            this.bMisExamenes.Name = "bMisExamenes";
            this.bMisExamenes.Size = new System.Drawing.Size(141, 40);
            this.bMisExamenes.TabIndex = 3;
            this.bMisExamenes.Text = "Mis exámenes";
            this.bMisExamenes.UseVisualStyleBackColor = true;
            this.bMisExamenes.Click += new System.EventHandler(this.bMisExamenes_Click);
            // 
            // bCrearQuiz
            // 
            this.bCrearQuiz.FlatAppearance.BorderSize = 0;
            this.bCrearQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCrearQuiz.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCrearQuiz.Location = new System.Drawing.Point(2, 122);
            this.bCrearQuiz.Name = "bCrearQuiz";
            this.bCrearQuiz.Size = new System.Drawing.Size(141, 40);
            this.bCrearQuiz.TabIndex = 2;
            this.bCrearQuiz.Text = "Crear quiz";
            this.bCrearQuiz.UseVisualStyleBackColor = true;
            this.bCrearQuiz.Click += new System.EventHandler(this.bCrearQuiz_Click);
            // 
            // bMisPreguntas
            // 
            this.bMisPreguntas.FlatAppearance.BorderSize = 0;
            this.bMisPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMisPreguntas.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bMisPreguntas.Location = new System.Drawing.Point(3, 202);
            this.bMisPreguntas.Name = "bMisPreguntas";
            this.bMisPreguntas.Size = new System.Drawing.Size(141, 40);
            this.bMisPreguntas.TabIndex = 1;
            this.bMisPreguntas.Text = "Mis preguntas";
            this.bMisPreguntas.UseVisualStyleBackColor = true;
            this.bMisPreguntas.Click += new System.EventHandler(this.bMisPreguntas_Click);
            // 
            // bCrearPregunta
            // 
            this.bCrearPregunta.FlatAppearance.BorderSize = 0;
            this.bCrearPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCrearPregunta.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCrearPregunta.Location = new System.Drawing.Point(2, 163);
            this.bCrearPregunta.Name = "bCrearPregunta";
            this.bCrearPregunta.Size = new System.Drawing.Size(142, 40);
            this.bCrearPregunta.TabIndex = 0;
            this.bCrearPregunta.Text = "Crear pregunta";
            this.bCrearPregunta.UseVisualStyleBackColor = true;
            this.bCrearPregunta.Click += new System.EventHandler(this.bCrearPregunta_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.foticoBacana);
            this.panelContenedor.Controls.Add(this.titulo2);
            this.panelContenedor.Controls.Add(this.titulo1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(147, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(653, 449);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // foticoBacana
            // 
            this.foticoBacana.Image = ((System.Drawing.Image)(resources.GetObject("foticoBacana.Image")));
            this.foticoBacana.Location = new System.Drawing.Point(181, 111);
            this.foticoBacana.Name = "foticoBacana";
            this.foticoBacana.Size = new System.Drawing.Size(280, 236);
            this.foticoBacana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foticoBacana.TabIndex = 2;
            this.foticoBacana.TabStop = false;
            // 
            // titulo2
            // 
            this.titulo2.AutoSize = true;
            this.titulo2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo2.Location = new System.Drawing.Point(262, 361);
            this.titulo2.Name = "titulo2";
            this.titulo2.Size = new System.Drawing.Size(94, 19);
            this.titulo2.TabIndex = 1;
            this.titulo2.Text = "By Softdring";
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.Font = new System.Drawing.Font("Corbel", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titulo1.Location = new System.Drawing.Point(219, 49);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(197, 59);
            this.titulo1.TabIndex = 0;
            this.titulo1.Text = "QUIZIFY";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tag = "horaPapi";
            this.timer1.Tick += new System.EventHandler(this.horaCualEs);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Name = "Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal";
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foticoBacana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bMisExamenes;
        private System.Windows.Forms.Button bCrearQuiz;
        private System.Windows.Forms.Button bMisPreguntas;
        private System.Windows.Forms.Button bCrearPregunta;
        private System.Windows.Forms.Label nombreIniciado;
        private System.Windows.Forms.Button bCrearCurso;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox foticoBacana;
        private System.Windows.Forms.Label titulo2;
        private System.Windows.Forms.Label titulo1;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}