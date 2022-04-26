namespace QuizifyIU
{
    partial class CrearPregunta
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
            this.enunciado = new System.Windows.Forms.TextBox();
            this.tipoPregunta = new System.Windows.Forms.ComboBox();
            this.opc0 = new System.Windows.Forms.TextBox();
            this.opc1 = new System.Windows.Forms.TextBox();
            this.opc2 = new System.Windows.Forms.TextBox();
            this.opc3 = new System.Windows.Forms.TextBox();
            this.opc4 = new System.Windows.Forms.TextBox();
            this.letraA = new System.Windows.Forms.Label();
            this.letraB = new System.Windows.Forms.Label();
            this.letraC = new System.Windows.Forms.Label();
            this.letraD = new System.Windows.Forms.Label();
            this.letraE = new System.Windows.Forms.Label();
            this.botonAdd = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.correcta0 = new System.Windows.Forms.RadioButton();
            this.correcta1 = new System.Windows.Forms.RadioButton();
            this.correcta2 = new System.Windows.Forms.RadioButton();
            this.correcta3 = new System.Windows.Forms.RadioButton();
            this.correcta4 = new System.Windows.Forms.RadioButton();
            this.correctaTest = new System.Windows.Forms.Panel();
            this.correctaVF = new System.Windows.Forms.Panel();
            this.falso1 = new System.Windows.Forms.RadioButton();
            this.verdadero0 = new System.Windows.Forms.RadioButton();
            this.dificultad = new System.Windows.Forms.ComboBox();
            this.crear = new System.Windows.Forms.Button();
            this.RespuestaTxt = new System.Windows.Forms.TextBox();
            this.CorrectaMult = new System.Windows.Forms.Panel();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check0 = new System.Windows.Forms.CheckBox();
            this.botonAdd2 = new System.Windows.Forms.Button();
            this.botonBorrar2 = new System.Windows.Forms.Button();
            this.tema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.correctaTest.SuspendLayout();
            this.correctaVF.SuspendLayout();
            this.CorrectaMult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enunciado:";
            // 
            // enunciado
            // 
            this.enunciado.Location = new System.Drawing.Point(14, 53);
            this.enunciado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enunciado.Multiline = true;
            this.enunciado.Name = "enunciado";
            this.enunciado.Size = new System.Drawing.Size(711, 99);
            this.enunciado.TabIndex = 1;
            // 
            // tipoPregunta
            // 
            this.tipoPregunta.FormattingEnabled = true;
            this.tipoPregunta.Items.AddRange(new object[] {
            "Test",
            "Verdadero Falso",
            "Desarrollo",
            "Selección Múltiple"});
            this.tipoPregunta.Location = new System.Drawing.Point(14, 201);
            this.tipoPregunta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tipoPregunta.Name = "tipoPregunta";
            this.tipoPregunta.Size = new System.Drawing.Size(138, 28);
            this.tipoPregunta.TabIndex = 6;
            this.tipoPregunta.Text = "Tipo de pregunta";
            this.tipoPregunta.SelectedIndexChanged += new System.EventHandler(this.CambiaTipoPregunta);
            // 
            // opc0
            // 
            this.opc0.Location = new System.Drawing.Point(53, 259);
            this.opc0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opc0.Name = "opc0";
            this.opc0.Size = new System.Drawing.Size(555, 27);
            this.opc0.TabIndex = 7;
            this.opc0.Visible = false;
            // 
            // opc1
            // 
            this.opc1.Location = new System.Drawing.Point(53, 320);
            this.opc1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opc1.Name = "opc1";
            this.opc1.Size = new System.Drawing.Size(555, 27);
            this.opc1.TabIndex = 8;
            this.opc1.Visible = false;
            // 
            // opc2
            // 
            this.opc2.Location = new System.Drawing.Point(53, 385);
            this.opc2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opc2.Name = "opc2";
            this.opc2.Size = new System.Drawing.Size(555, 27);
            this.opc2.TabIndex = 9;
            this.opc2.Visible = false;
            // 
            // opc3
            // 
            this.opc3.Location = new System.Drawing.Point(53, 449);
            this.opc3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opc3.Name = "opc3";
            this.opc3.Size = new System.Drawing.Size(555, 27);
            this.opc3.TabIndex = 10;
            this.opc3.Visible = false;
            // 
            // opc4
            // 
            this.opc4.Location = new System.Drawing.Point(53, 515);
            this.opc4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opc4.Name = "opc4";
            this.opc4.Size = new System.Drawing.Size(555, 27);
            this.opc4.TabIndex = 11;
            this.opc4.Visible = false;
            // 
            // letraA
            // 
            this.letraA.AutoSize = true;
            this.letraA.Location = new System.Drawing.Point(29, 264);
            this.letraA.Name = "letraA";
            this.letraA.Size = new System.Drawing.Size(19, 20);
            this.letraA.TabIndex = 12;
            this.letraA.Text = "A";
            this.letraA.Visible = false;
            // 
            // letraB
            // 
            this.letraB.AutoSize = true;
            this.letraB.Location = new System.Drawing.Point(29, 324);
            this.letraB.Name = "letraB";
            this.letraB.Size = new System.Drawing.Size(18, 20);
            this.letraB.TabIndex = 13;
            this.letraB.Text = "B";
            this.letraB.Visible = false;
            // 
            // letraC
            // 
            this.letraC.AutoSize = true;
            this.letraC.Location = new System.Drawing.Point(29, 389);
            this.letraC.Name = "letraC";
            this.letraC.Size = new System.Drawing.Size(18, 20);
            this.letraC.TabIndex = 14;
            this.letraC.Text = "C";
            this.letraC.Visible = false;
            // 
            // letraD
            // 
            this.letraD.AutoSize = true;
            this.letraD.Location = new System.Drawing.Point(29, 455);
            this.letraD.Name = "letraD";
            this.letraD.Size = new System.Drawing.Size(20, 20);
            this.letraD.TabIndex = 15;
            this.letraD.Text = "D";
            this.letraD.Visible = false;
            // 
            // letraE
            // 
            this.letraE.AutoSize = true;
            this.letraE.Location = new System.Drawing.Point(29, 519);
            this.letraE.Name = "letraE";
            this.letraE.Size = new System.Drawing.Size(17, 20);
            this.letraE.TabIndex = 16;
            this.letraE.Text = "E";
            this.letraE.Visible = false;
            // 
            // botonAdd
            // 
            this.botonAdd.Location = new System.Drawing.Point(423, 200);
            this.botonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonAdd.Name = "botonAdd";
            this.botonAdd.Size = new System.Drawing.Size(63, 31);
            this.botonAdd.TabIndex = 17;
            this.botonAdd.Text = "Añadir";
            this.botonAdd.UseVisualStyleBackColor = true;
            this.botonAdd.Visible = false;
            this.botonAdd.Click += new System.EventHandler(this.AddOpc);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(503, 200);
            this.botonBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(63, 31);
            this.botonBorrar.TabIndex = 18;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Visible = false;
            this.botonBorrar.Click += new System.EventHandler(this.BorrarOp);
            // 
            // correcta0
            // 
            this.correcta0.AutoSize = true;
            this.correcta0.Location = new System.Drawing.Point(22, 21);
            this.correcta0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.correcta0.Name = "correcta0";
            this.correcta0.Size = new System.Drawing.Size(17, 16);
            this.correcta0.TabIndex = 19;
            this.correcta0.TabStop = true;
            this.correcta0.UseVisualStyleBackColor = true;
            this.correcta0.CheckedChanged += new System.EventHandler(this.MarcarCorrecta);
            // 
            // correcta1
            // 
            this.correcta1.AutoSize = true;
            this.correcta1.Location = new System.Drawing.Point(22, 84);
            this.correcta1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.correcta1.Name = "correcta1";
            this.correcta1.Size = new System.Drawing.Size(17, 16);
            this.correcta1.TabIndex = 21;
            this.correcta1.TabStop = true;
            this.correcta1.UseVisualStyleBackColor = true;
            this.correcta1.CheckedChanged += new System.EventHandler(this.MarcarCorrecta);
            // 
            // correcta2
            // 
            this.correcta2.AutoSize = true;
            this.correcta2.Location = new System.Drawing.Point(22, 147);
            this.correcta2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.correcta2.Name = "correcta2";
            this.correcta2.Size = new System.Drawing.Size(17, 16);
            this.correcta2.TabIndex = 22;
            this.correcta2.TabStop = true;
            this.correcta2.UseVisualStyleBackColor = true;
            this.correcta2.CheckedChanged += new System.EventHandler(this.MarcarCorrecta);
            // 
            // correcta3
            // 
            this.correcta3.AutoSize = true;
            this.correcta3.Location = new System.Drawing.Point(22, 211);
            this.correcta3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.correcta3.Name = "correcta3";
            this.correcta3.Size = new System.Drawing.Size(17, 16);
            this.correcta3.TabIndex = 23;
            this.correcta3.TabStop = true;
            this.correcta3.UseVisualStyleBackColor = true;
            this.correcta3.Visible = false;
            this.correcta3.CheckedChanged += new System.EventHandler(this.MarcarCorrecta);
            // 
            // correcta4
            // 
            this.correcta4.AutoSize = true;
            this.correcta4.Location = new System.Drawing.Point(22, 275);
            this.correcta4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.correcta4.Name = "correcta4";
            this.correcta4.Size = new System.Drawing.Size(17, 16);
            this.correcta4.TabIndex = 24;
            this.correcta4.TabStop = true;
            this.correcta4.UseVisualStyleBackColor = true;
            this.correcta4.Visible = false;
            this.correcta4.CheckedChanged += new System.EventHandler(this.MarcarCorrecta);
            // 
            // correctaTest
            // 
            this.correctaTest.Controls.Add(this.correcta4);
            this.correctaTest.Controls.Add(this.correcta0);
            this.correctaTest.Controls.Add(this.correcta3);
            this.correctaTest.Controls.Add(this.correcta1);
            this.correctaTest.Controls.Add(this.correcta2);
            this.correctaTest.Location = new System.Drawing.Point(627, 244);
            this.correctaTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.correctaTest.Name = "correctaTest";
            this.correctaTest.Size = new System.Drawing.Size(77, 327);
            this.correctaTest.TabIndex = 26;
            this.correctaTest.Visible = false;
            // 
            // correctaVF
            // 
            this.correctaVF.Controls.Add(this.falso1);
            this.correctaVF.Controls.Add(this.verdadero0);
            this.correctaVF.Location = new System.Drawing.Point(160, 264);
            this.correctaVF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.correctaVF.Name = "correctaVF";
            this.correctaVF.Size = new System.Drawing.Size(406, 133);
            this.correctaVF.TabIndex = 29;
            this.correctaVF.Visible = false;
            // 
            // falso1
            // 
            this.falso1.AutoSize = true;
            this.falso1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.falso1.Location = new System.Drawing.Point(241, 45);
            this.falso1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.falso1.Name = "falso1";
            this.falso1.Size = new System.Drawing.Size(92, 39);
            this.falso1.TabIndex = 1;
            this.falso1.TabStop = true;
            this.falso1.Text = "Falso";
            this.falso1.UseVisualStyleBackColor = true;
            this.falso1.CheckedChanged += new System.EventHandler(this.MarcarCorrecta);
            // 
            // verdadero0
            // 
            this.verdadero0.AutoSize = true;
            this.verdadero0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verdadero0.Location = new System.Drawing.Point(65, 44);
            this.verdadero0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.verdadero0.Name = "verdadero0";
            this.verdadero0.Size = new System.Drawing.Size(152, 39);
            this.verdadero0.TabIndex = 0;
            this.verdadero0.TabStop = true;
            this.verdadero0.Text = "Verdadero";
            this.verdadero0.UseVisualStyleBackColor = true;
            this.verdadero0.CheckedChanged += new System.EventHandler(this.MarcarCorrecta);
            // 
            // dificultad
            // 
            this.dificultad.FormattingEnabled = true;
            this.dificultad.Items.AddRange(new object[] {
            "Fácil",
            "Normal",
            "Difícil"});
            this.dificultad.Location = new System.Drawing.Point(587, 164);
            this.dificultad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dificultad.Name = "dificultad";
            this.dificultad.Size = new System.Drawing.Size(138, 28);
            this.dificultad.TabIndex = 30;
            this.dificultad.Text = "Dificultad";
            this.dificultad.SelectedIndexChanged += new System.EventHandler(this.EvCambiarDificultad);
            // 
            // crear
            // 
            this.crear.Enabled = false;
            this.crear.Location = new System.Drawing.Point(649, 553);
            this.crear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(86, 31);
            this.crear.TabIndex = 31;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.EvCrearPregunta);
            // 
            // RespuestaTxt
            // 
            this.RespuestaTxt.Location = new System.Drawing.Point(18, 251);
            this.RespuestaTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RespuestaTxt.Multiline = true;
            this.RespuestaTxt.Name = "RespuestaTxt";
            this.RespuestaTxt.Size = new System.Drawing.Size(711, 293);
            this.RespuestaTxt.TabIndex = 32;
            this.RespuestaTxt.Visible = false;
            // 
            // CorrectaMult
            // 
            this.CorrectaMult.Controls.Add(this.check4);
            this.CorrectaMult.Controls.Add(this.check3);
            this.CorrectaMult.Controls.Add(this.check2);
            this.CorrectaMult.Controls.Add(this.check1);
            this.CorrectaMult.Controls.Add(this.check0);
            this.CorrectaMult.Location = new System.Drawing.Point(631, 244);
            this.CorrectaMult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CorrectaMult.Name = "CorrectaMult";
            this.CorrectaMult.Size = new System.Drawing.Size(77, 327);
            this.CorrectaMult.TabIndex = 33;
            this.CorrectaMult.Visible = false;
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(18, 276);
            this.check4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(18, 17);
            this.check4.TabIndex = 4;
            this.check4.UseVisualStyleBackColor = true;
            this.check4.Visible = false;
            this.check4.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(18, 212);
            this.check3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(18, 17);
            this.check3.TabIndex = 3;
            this.check3.UseVisualStyleBackColor = true;
            this.check3.Visible = false;
            this.check3.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(18, 147);
            this.check2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(18, 17);
            this.check2.TabIndex = 2;
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(18, 83);
            this.check1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(18, 17);
            this.check1.TabIndex = 1;
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check0
            // 
            this.check0.AutoSize = true;
            this.check0.Location = new System.Drawing.Point(18, 20);
            this.check0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check0.Name = "check0";
            this.check0.Size = new System.Drawing.Size(18, 17);
            this.check0.TabIndex = 0;
            this.check0.UseVisualStyleBackColor = true;
            this.check0.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // botonAdd2
            // 
            this.botonAdd2.Location = new System.Drawing.Point(423, 201);
            this.botonAdd2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonAdd2.Name = "botonAdd2";
            this.botonAdd2.Size = new System.Drawing.Size(63, 31);
            this.botonAdd2.TabIndex = 34;
            this.botonAdd2.Text = "Añadir";
            this.botonAdd2.UseVisualStyleBackColor = true;
            this.botonAdd2.Visible = false;
            this.botonAdd2.Click += new System.EventHandler(this.AddOpc2);
            // 
            // botonBorrar2
            // 
            this.botonBorrar2.Location = new System.Drawing.Point(503, 201);
            this.botonBorrar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonBorrar2.Name = "botonBorrar2";
            this.botonBorrar2.Size = new System.Drawing.Size(63, 31);
            this.botonBorrar2.TabIndex = 35;
            this.botonBorrar2.Text = "Borrar";
            this.botonBorrar2.UseVisualStyleBackColor = true;
            this.botonBorrar2.Visible = false;
            this.botonBorrar2.Click += new System.EventHandler(this.BorrarOpc2);
            // 
            // tema
            // 
            this.tema.Location = new System.Drawing.Point(70, 164);
            this.tema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tema.Multiline = true;
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(210, 30);
            this.tema.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tema:";
            // 
            // CrearPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 600);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.tema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonBorrar2);
            this.Controls.Add(this.botonAdd2);
            this.Controls.Add(this.CorrectaMult);
            this.Controls.Add(this.dificultad);
            this.Controls.Add(this.correctaVF);
            this.Controls.Add(this.correctaTest);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonAdd);
            this.Controls.Add(this.letraE);
            this.Controls.Add(this.letraD);
            this.Controls.Add(this.letraC);
            this.Controls.Add(this.letraB);
            this.Controls.Add(this.letraA);
            this.Controls.Add(this.opc4);
            this.Controls.Add(this.opc3);
            this.Controls.Add(this.opc2);
            this.Controls.Add(this.opc1);
            this.Controls.Add(this.opc0);
            this.Controls.Add(this.tipoPregunta);
            this.Controls.Add(this.enunciado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RespuestaTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrearPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearPregunta";
            this.correctaTest.ResumeLayout(false);
            this.correctaTest.PerformLayout();
            this.correctaVF.ResumeLayout(false);
            this.correctaVF.PerformLayout();
            this.CorrectaMult.ResumeLayout(false);
            this.CorrectaMult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enunciado;
        private System.Windows.Forms.ComboBox tipoPregunta;
        private System.Windows.Forms.TextBox opc0;
        private System.Windows.Forms.TextBox opc1;
        private System.Windows.Forms.TextBox opc2;
        private System.Windows.Forms.TextBox opc3;
        private System.Windows.Forms.TextBox opc4;
        private System.Windows.Forms.Label letraA;
        private System.Windows.Forms.Label letraB;
        private System.Windows.Forms.Label letraC;
        private System.Windows.Forms.Label letraD;
        private System.Windows.Forms.Label letraE;
        private System.Windows.Forms.Button botonAdd;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.RadioButton correcta0;
        private System.Windows.Forms.RadioButton correcta1;
        private System.Windows.Forms.RadioButton correcta2;
        private System.Windows.Forms.RadioButton correcta3;
        private System.Windows.Forms.RadioButton correcta4;
        private System.Windows.Forms.Panel correctaTest;
        private System.Windows.Forms.Panel correctaVF;
        private System.Windows.Forms.RadioButton falso1;
        private System.Windows.Forms.RadioButton verdadero0;
        private System.Windows.Forms.ComboBox dificultad;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.TextBox RespuestaTxt;
        private System.Windows.Forms.Panel CorrectaMult;
        private System.Windows.Forms.CheckBox check0;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.Button botonAdd2;
        private System.Windows.Forms.Button botonBorrar2;
        private System.Windows.Forms.TextBox tema;
        private System.Windows.Forms.Label label2;
    }
}