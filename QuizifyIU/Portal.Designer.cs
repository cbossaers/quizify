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
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.bHacerExamen = new System.Windows.Forms.Button();
            this.bAjustes = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.bMisExamenes = new System.Windows.Forms.Button();
            this.bCrearQuiz = new System.Windows.Forms.Button();
            this.bMisPreguntas = new System.Windows.Forms.Button();
            this.bCrearPregunta = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.bHacerExamen);
            this.MenuVertical.Controls.Add(this.bAjustes);
            this.MenuVertical.Controls.Add(this.bSalir);
            this.MenuVertical.Controls.Add(this.bMisExamenes);
            this.MenuVertical.Controls.Add(this.bCrearQuiz);
            this.MenuVertical.Controls.Add(this.bMisPreguntas);
            this.MenuVertical.Controls.Add(this.bCrearPregunta);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(147, 450);
            this.MenuVertical.TabIndex = 0;
            // 
            // bHacerExamen
            // 
            this.bHacerExamen.Location = new System.Drawing.Point(0, 316);
            this.bHacerExamen.Name = "bHacerExamen";
            this.bHacerExamen.Size = new System.Drawing.Size(147, 40);
            this.bHacerExamen.TabIndex = 4;
            this.bHacerExamen.Text = "Hacer examen";
            this.bHacerExamen.UseVisualStyleBackColor = true;
            this.bHacerExamen.Click += new System.EventHandler(this.bHacerExamen_Click);
            // 
            // bAjustes
            // 
            this.bAjustes.Location = new System.Drawing.Point(106, 414);
            this.bAjustes.Name = "bAjustes";
            this.bAjustes.Size = new System.Drawing.Size(35, 23);
            this.bAjustes.TabIndex = 5;
            this.bAjustes.Text = "Ajustes";
            this.bAjustes.UseVisualStyleBackColor = true;
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(15, 414);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(44, 23);
            this.bSalir.TabIndex = 4;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            // 
            // bMisExamenes
            // 
            this.bMisExamenes.Location = new System.Drawing.Point(0, 260);
            this.bMisExamenes.Name = "bMisExamenes";
            this.bMisExamenes.Size = new System.Drawing.Size(147, 40);
            this.bMisExamenes.TabIndex = 3;
            this.bMisExamenes.Text = "Mis exámenes";
            this.bMisExamenes.UseVisualStyleBackColor = true;
            this.bMisExamenes.Click += new System.EventHandler(this.bMisExamenes_Click);
            // 
            // bCrearQuiz
            // 
            this.bCrearQuiz.Location = new System.Drawing.Point(0, 156);
            this.bCrearQuiz.Name = "bCrearQuiz";
            this.bCrearQuiz.Size = new System.Drawing.Size(147, 40);
            this.bCrearQuiz.TabIndex = 2;
            this.bCrearQuiz.Text = "Crear quiz";
            this.bCrearQuiz.UseVisualStyleBackColor = true;
            this.bCrearQuiz.Click += new System.EventHandler(this.bCrearQuiz_Click);
            // 
            // bMisPreguntas
            // 
            this.bMisPreguntas.Location = new System.Drawing.Point(0, 202);
            this.bMisPreguntas.Name = "bMisPreguntas";
            this.bMisPreguntas.Size = new System.Drawing.Size(147, 40);
            this.bMisPreguntas.TabIndex = 1;
            this.bMisPreguntas.Text = "Mis preguntas";
            this.bMisPreguntas.UseVisualStyleBackColor = true;
            this.bMisPreguntas.Click += new System.EventHandler(this.bMisPreguntas_Click);
            // 
            // bCrearPregunta
            // 
            this.bCrearPregunta.Location = new System.Drawing.Point(0, 110);
            this.bCrearPregunta.Name = "bCrearPregunta";
            this.bCrearPregunta.Size = new System.Drawing.Size(147, 40);
            this.bCrearPregunta.TabIndex = 0;
            this.bCrearPregunta.Text = "Crear pregunta";
            this.bCrearPregunta.UseVisualStyleBackColor = true;
            this.bCrearPregunta.Click += new System.EventHandler(this.bCrearPregunta_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(147, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(653, 450);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Name = "Portal";
            this.Text = "Portal";
            this.MenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button bAjustes;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bMisExamenes;
        private System.Windows.Forms.Button bCrearQuiz;
        private System.Windows.Forms.Button bMisPreguntas;
        private System.Windows.Forms.Button bCrearPregunta;
        private System.Windows.Forms.Button bHacerExamen;
    }
}