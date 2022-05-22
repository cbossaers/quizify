namespace QuizifyIU
{
    partial class CrearQuiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.siguiente = new System.Windows.Forms.Button();
            this.sinlimite = new System.Windows.Forms.CheckBox();
            this.m = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.minutos = new System.Windows.Forms.ComboBox();
            this.horas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ini = new System.Windows.Forms.DateTimePicker();
            this.fin = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.curso = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toggle_button1 = new QuizifyIU.Controles_extra.Toggle_button();
            this.toggle_button2 = new QuizifyIU.Controles_extra.Toggle_button();
            this.toggle_button3 = new QuizifyIU.Controles_extra.Toggle_button();
            this.dificultad = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.automatico = new System.Windows.Forms.Button();
            this.hfin = new System.Windows.Forms.DateTimePicker();
            this.hini = new System.Windows.Forms.DateTimePicker();
            this.intentos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del quiz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dificultad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volver a atras";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(178, 30);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(360, 23);
            this.nombre.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(35, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mostrar respuestas al finalizar el quiz";
            this.label8.Visible = false;
            // 
            // siguiente
            // 
            this.siguiente.Location = new System.Drawing.Point(301, 476);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(105, 28);
            this.siguiente.TabIndex = 15;
            this.siguiente.Text = "Manualmente";
            this.siguiente.UseVisualStyleBackColor = true;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // sinlimite
            // 
            this.sinlimite.AutoSize = true;
            this.sinlimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sinlimite.Location = new System.Drawing.Point(51, 312);
            this.sinlimite.Name = "sinlimite";
            this.sinlimite.Size = new System.Drawing.Size(142, 20);
            this.sinlimite.TabIndex = 57;
            this.sinlimite.Text = "Sin limite de tiempo";
            this.sinlimite.UseVisualStyleBackColor = true;
            this.sinlimite.CheckedChanged += new System.EventHandler(this.sinlimite_CheckedChanged);
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Location = new System.Drawing.Point(498, 294);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(18, 15);
            this.m.TabIndex = 56;
            this.m.Text = "m";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Location = new System.Drawing.Point(402, 294);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(16, 15);
            this.h.TabIndex = 55;
            this.h.Text = "H";
            // 
            // minutos
            // 
            this.minutos.FormattingEnabled = true;
            this.minutos.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.minutos.Location = new System.Drawing.Point(422, 291);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(70, 23);
            this.minutos.TabIndex = 54;
            // 
            // horas
            // 
            this.horas.FormattingEnabled = true;
            this.horas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.horas.Location = new System.Drawing.Point(329, 290);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(70, 23);
            this.horas.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Limite de tiempo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "Descripción :";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(178, 62);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(360, 78);
            this.descripcion.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Errores restan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(35, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Fecha de apertura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(35, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 20);
            this.label10.TabIndex = 62;
            this.label10.Text = "Fecha de finalización";
            // 
            // ini
            // 
            this.ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ini.Location = new System.Drawing.Point(324, 203);
            this.ini.Name = "ini";
            this.ini.Size = new System.Drawing.Size(82, 23);
            this.ini.TabIndex = 63;
            // 
            // fin
            // 
            this.fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fin.Location = new System.Drawing.Point(324, 232);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(82, 23);
            this.fin.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(37, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 65;
            this.label11.Text = "Curso";
            // 
            // curso
            // 
            this.curso.FormattingEnabled = true;
            this.curso.Items.AddRange(new object[] {
            "Ejemplo",
            "Primero",
            "Segundo",
            "Tercero"});
            this.curso.Location = new System.Drawing.Point(356, 175);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(111, 23);
            this.curso.TabIndex = 66;
            this.curso.Text = "Curso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(36, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 67;
            this.label12.Text = "Intentos";
            // 
            // comboBoxCT
            // 
            this.comboBoxCT.FormattingEnabled = true;
            this.comboBoxCT.Items.AddRange(new object[] {
            "Comprensión e Integración",
            "Aplicación y pensamiento práctico",
            "Análisis y resolución de problemas",
            "Innovación, creatividad y emprendimiento",
            "Diseño y proyecto",
            "Trabajo en equipo y liderazgo",
            "Responsabilidad ética",
            "Comunicación efectiva",
            "Pensamiento crítico",
            "Conocimiento de problemas actuales contemporáneos",
            "Aprendizaje permanente",
            "Planificación y Gestión del tiempo"});
            this.comboBoxCT.Location = new System.Drawing.Point(306, 334);
            this.comboBoxCT.Name = "comboBoxCT";
            this.comboBoxCT.Size = new System.Drawing.Size(210, 23);
            this.comboBoxCT.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(36, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "Elige una Competencia Transversal:";
            // 
            // toggle_button1
            // 
            this.toggle_button1.AutoSize = true;
            this.toggle_button1.Location = new System.Drawing.Point(385, 364);
            this.toggle_button1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggle_button1.Name = "toggle_button1";
            this.toggle_button1.OffBackColor = System.Drawing.Color.Gray;
            this.toggle_button1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggle_button1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggle_button1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggle_button1.Size = new System.Drawing.Size(45, 22);
            this.toggle_button1.TabIndex = 74;
            this.toggle_button1.UseVisualStyleBackColor = true;
            this.toggle_button1.CheckedChanged += new System.EventHandler(this.toggle_button1_CheckedChanged);
            // 
            // toggle_button2
            // 
            this.toggle_button2.AutoSize = true;
            this.toggle_button2.Location = new System.Drawing.Point(385, 393);
            this.toggle_button2.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggle_button2.Name = "toggle_button2";
            this.toggle_button2.OffBackColor = System.Drawing.Color.Gray;
            this.toggle_button2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggle_button2.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggle_button2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggle_button2.Size = new System.Drawing.Size(45, 22);
            this.toggle_button2.TabIndex = 75;
            this.toggle_button2.UseVisualStyleBackColor = true;
            this.toggle_button2.CheckedChanged += new System.EventHandler(this.toggle_button2_CheckedChanged);
            // 
            // toggle_button3
            // 
            this.toggle_button3.AutoSize = true;
            this.toggle_button3.Location = new System.Drawing.Point(385, 424);
            this.toggle_button3.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggle_button3.Name = "toggle_button3";
            this.toggle_button3.OffBackColor = System.Drawing.Color.Gray;
            this.toggle_button3.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggle_button3.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggle_button3.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggle_button3.Size = new System.Drawing.Size(45, 22);
            this.toggle_button3.TabIndex = 76;
            this.toggle_button3.UseVisualStyleBackColor = true;
            this.toggle_button3.Visible = false;
            this.toggle_button3.CheckedChanged += new System.EventHandler(this.toggle_button3_CheckedChanged);
            // 
            // dificultad
            // 
            this.dificultad.FormattingEnabled = true;
            this.dificultad.Items.AddRange(new object[] {
            "Fácil",
            "Normal",
            "Difícil"});
            this.dificultad.Location = new System.Drawing.Point(356, 146);
            this.dificultad.Name = "dificultad";
            this.dificultad.Size = new System.Drawing.Size(111, 23);
            this.dificultad.TabIndex = 77;
            this.dificultad.Text = "Normal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(39, 480);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 18);
            this.label15.TabIndex = 81;
            this.label15.Text = "Rellenar lista de preguntas";
            // 
            // automatico
            // 
            this.automatico.Location = new System.Drawing.Point(421, 476);
            this.automatico.Name = "automatico";
            this.automatico.Size = new System.Drawing.Size(108, 28);
            this.automatico.TabIndex = 82;
            this.automatico.Text = "Automatiamente";
            this.automatico.UseVisualStyleBackColor = true;
            this.automatico.Click += new System.EventHandler(this.automatico_Click);
            // 
            // hfin
            // 
            this.hfin.AllowDrop = true;
            this.hfin.Checked = false;
            this.hfin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hfin.Location = new System.Drawing.Point(412, 232);
            this.hfin.Name = "hfin";
            this.hfin.Size = new System.Drawing.Size(69, 23);
            this.hfin.TabIndex = 70;
            // 
            // hini
            // 
            this.hini.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hini.Location = new System.Drawing.Point(412, 203);
            this.hini.Name = "hini";
            this.hini.Size = new System.Drawing.Size(69, 23);
            this.hini.TabIndex = 69;
            // 
            // intentos
            // 
            this.intentos.Location = new System.Drawing.Point(357, 261);
            this.intentos.Name = "intentos";
            this.intentos.Size = new System.Drawing.Size(100, 23);
            this.intentos.TabIndex = 83;
            this.intentos.Text = "1";
            this.intentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intentos.TextChanged += new System.EventHandler(this.intentos_SelectedIndexChanged);
            // 
            // CrearQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(730, 531);
            this.Controls.Add(this.intentos);
            this.Controls.Add(this.automatico);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dificultad);
            this.Controls.Add(this.toggle_button3);
            this.Controls.Add(this.toggle_button2);
            this.Controls.Add(this.toggle_button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxCT);
            this.Controls.Add(this.hfin);
            this.Controls.Add(this.hini);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.curso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fin);
            this.Controls.Add(this.ini);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sinlimite);
            this.Controls.Add(this.m);
            this.Controls.Add(this.h);
            this.Controls.Add(this.minutos);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.CheckBox sinlimite;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.ComboBox minutos;
        private System.Windows.Forms.ComboBox horas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ini;
        private System.Windows.Forms.DateTimePicker fin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox curso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCT;
        private System.Windows.Forms.Label label7;
        private Controles_extra.Toggle_button toggle_button1;
        private Controles_extra.Toggle_button toggle_button2;
        private Controles_extra.Toggle_button toggle_button3;
        private System.Windows.Forms.ComboBox dificultad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button automatico;
        private System.Windows.Forms.DateTimePicker hfin;
        private System.Windows.Forms.DateTimePicker hini;
        private System.Windows.Forms.TextBox intentos;
    }
}