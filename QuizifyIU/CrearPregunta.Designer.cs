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
            this.button1 = new System.Windows.Forms.Button();
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
            this.check0 = new System.Windows.Forms.CheckBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.correctaTest.SuspendLayout();
            this.correctaVF.SuspendLayout();
            this.CorrectaMult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enunciado:";
            // 
            // enunciado
            // 
            this.enunciado.Location = new System.Drawing.Point(12, 40);
            this.enunciado.Multiline = true;
            this.enunciado.Name = "enunciado";
            this.enunciado.Size = new System.Drawing.Size(623, 75);
            this.enunciado.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adjuntar archivo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tipoPregunta
            // 
            this.tipoPregunta.FormattingEnabled = true;
            this.tipoPregunta.Items.AddRange(new object[] {
            "Test",
            "Verdadero Falso",
            "Desarrollo",
            "Selección Múltiple"});
            this.tipoPregunta.Location = new System.Drawing.Point(12, 151);
            this.tipoPregunta.Name = "tipoPregunta";
            this.tipoPregunta.Size = new System.Drawing.Size(121, 23);
            this.tipoPregunta.TabIndex = 6;
            this.tipoPregunta.Text = "Tipo de pregunta";
            this.tipoPregunta.SelectedIndexChanged += new System.EventHandler(this.CambiaTipoPregunta);
            // 
            // opc0
            // 
            this.opc0.Location = new System.Drawing.Point(46, 194);
            this.opc0.Name = "opc0";
            this.opc0.Size = new System.Drawing.Size(486, 23);
            this.opc0.TabIndex = 7;
            this.opc0.Visible = false;
            // 
            // opc1
            // 
            this.opc1.Location = new System.Drawing.Point(46, 240);
            this.opc1.Name = "opc1";
            this.opc1.Size = new System.Drawing.Size(486, 23);
            this.opc1.TabIndex = 8;
            this.opc1.Visible = false;
            // 
            // opc2
            // 
            this.opc2.Location = new System.Drawing.Point(46, 289);
            this.opc2.Name = "opc2";
            this.opc2.Size = new System.Drawing.Size(486, 23);
            this.opc2.TabIndex = 9;
            this.opc2.Visible = false;
            // 
            // opc3
            // 
            this.opc3.Location = new System.Drawing.Point(46, 337);
            this.opc3.Name = "opc3";
            this.opc3.Size = new System.Drawing.Size(486, 23);
            this.opc3.TabIndex = 10;
            this.opc3.Visible = false;
            // 
            // opc4
            // 
            this.opc4.Location = new System.Drawing.Point(46, 386);
            this.opc4.Name = "opc4";
            this.opc4.Size = new System.Drawing.Size(486, 23);
            this.opc4.TabIndex = 11;
            this.opc4.Visible = false;
            // 
            // letraA
            // 
            this.letraA.AutoSize = true;
            this.letraA.Location = new System.Drawing.Point(25, 198);
            this.letraA.Name = "letraA";
            this.letraA.Size = new System.Drawing.Size(15, 15);
            this.letraA.TabIndex = 12;
            this.letraA.Text = "A";
            this.letraA.Visible = false;
            // 
            // letraB
            // 
            this.letraB.AutoSize = true;
            this.letraB.Location = new System.Drawing.Point(25, 243);
            this.letraB.Name = "letraB";
            this.letraB.Size = new System.Drawing.Size(14, 15);
            this.letraB.TabIndex = 13;
            this.letraB.Text = "B";
            this.letraB.Visible = false;
            // 
            // letraC
            // 
            this.letraC.AutoSize = true;
            this.letraC.Location = new System.Drawing.Point(25, 292);
            this.letraC.Name = "letraC";
            this.letraC.Size = new System.Drawing.Size(15, 15);
            this.letraC.TabIndex = 14;
            this.letraC.Text = "C";
            this.letraC.Visible = false;
            // 
            // letraD
            // 
            this.letraD.AutoSize = true;
            this.letraD.Location = new System.Drawing.Point(25, 341);
            this.letraD.Name = "letraD";
            this.letraD.Size = new System.Drawing.Size(15, 15);
            this.letraD.TabIndex = 15;
            this.letraD.Text = "D";
            this.letraD.Visible = false;
            // 
            // letraE
            // 
            this.letraE.AutoSize = true;
            this.letraE.Location = new System.Drawing.Point(25, 389);
            this.letraE.Name = "letraE";
            this.letraE.Size = new System.Drawing.Size(13, 15);
            this.letraE.TabIndex = 16;
            this.letraE.Text = "E";
            this.letraE.Visible = false;
            // 
            // botonAdd
            // 
            this.botonAdd.Location = new System.Drawing.Point(370, 150);
            this.botonAdd.Name = "botonAdd";
            this.botonAdd.Size = new System.Drawing.Size(55, 23);
            this.botonAdd.TabIndex = 17;
            this.botonAdd.Text = "Añadir";
            this.botonAdd.UseVisualStyleBackColor = true;
            this.botonAdd.Visible = false;
            this.botonAdd.Click += new System.EventHandler(this.AddOpc);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Location = new System.Drawing.Point(440, 150);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(55, 23);
            this.botonBorrar.TabIndex = 18;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Visible = false;
            this.botonBorrar.Click += new System.EventHandler(this.BorrarOp);
            // 
            // correcta0
            // 
            this.correcta0.AutoSize = true;
            this.correcta0.Location = new System.Drawing.Point(19, 16);
            this.correcta0.Name = "correcta0";
            this.correcta0.Size = new System.Drawing.Size(14, 13);
            this.correcta0.TabIndex = 19;
            this.correcta0.TabStop = true;
            this.correcta0.UseVisualStyleBackColor = true;
            this.correcta0.CheckedChanged += new System.EventHandler(this.MarcarCorrecta);
            // 
            // correcta1
            // 
            this.correcta1.AutoSize = true;
            this.correcta1.Location = new System.Drawing.Point(19, 63);
            this.correcta1.Name = "correcta1";
            this.correcta1.Size = new System.Drawing.Size(14, 13);
            this.correcta1.TabIndex = 21;
            this.correcta1.TabStop = true;
            this.correcta1.UseVisualStyleBackColor = true;
            this.correcta1.CheckedChanged += new System.EventHandler(this.MarcarCorrecta);
            // 
            // correcta2
            // 
            this.correcta2.AutoSize = true;
            this.correcta2.Location = new System.Drawing.Point(19, 110);
            this.correcta2.Name = "correcta2";
            this.correcta2.Size = new System.Drawing.Size(14, 13);
            this.correcta2.TabIndex = 22;
            this.correcta2.TabStop = true;
            this.correcta2.UseVisualStyleBackColor = true;
            this.correcta2.CheckedChanged += new System.EventHandler(this.MarcarCorrecta);
            // 
            // correcta3
            // 
            this.correcta3.AutoSize = true;
            this.correcta3.Location = new System.Drawing.Point(19, 158);
            this.correcta3.Name = "correcta3";
            this.correcta3.Size = new System.Drawing.Size(14, 13);
            this.correcta3.TabIndex = 23;
            this.correcta3.TabStop = true;
            this.correcta3.UseVisualStyleBackColor = true;
            this.correcta3.Visible = false;
            this.correcta3.CheckedChanged += new System.EventHandler(this.MarcarCorrecta);
            // 
            // correcta4
            // 
            this.correcta4.AutoSize = true;
            this.correcta4.Location = new System.Drawing.Point(19, 206);
            this.correcta4.Name = "correcta4";
            this.correcta4.Size = new System.Drawing.Size(14, 13);
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
            this.correctaTest.Location = new System.Drawing.Point(549, 183);
            this.correctaTest.Name = "correctaTest";
            this.correctaTest.Size = new System.Drawing.Size(67, 245);
            this.correctaTest.TabIndex = 26;
            this.correctaTest.Visible = false;
            // 
            // correctaVF
            // 
            this.correctaVF.Controls.Add(this.falso1);
            this.correctaVF.Controls.Add(this.verdadero0);
            this.correctaVF.Location = new System.Drawing.Point(140, 198);
            this.correctaVF.Name = "correctaVF";
            this.correctaVF.Size = new System.Drawing.Size(355, 100);
            this.correctaVF.TabIndex = 29;
            this.correctaVF.Visible = false;
            // 
            // falso1
            // 
            this.falso1.AutoSize = true;
            this.falso1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.falso1.Location = new System.Drawing.Point(211, 34);
            this.falso1.Name = "falso1";
            this.falso1.Size = new System.Drawing.Size(74, 32);
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
            this.verdadero0.Location = new System.Drawing.Point(57, 33);
            this.verdadero0.Name = "verdadero0";
            this.verdadero0.Size = new System.Drawing.Size(121, 32);
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
            this.dificultad.Location = new System.Drawing.Point(514, 123);
            this.dificultad.Name = "dificultad";
            this.dificultad.Size = new System.Drawing.Size(121, 23);
            this.dificultad.TabIndex = 30;
            this.dificultad.Text = "Dificultad";
            this.dificultad.SelectedIndexChanged += new System.EventHandler(this.EvCambiarDificultad);
            // 
            // crear
            // 
            this.crear.Enabled = false;
            this.crear.Location = new System.Drawing.Point(568, 415);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(75, 23);
            this.crear.TabIndex = 31;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.EvCrearPregunta);
            // 
            // RespuestaTxt
            // 
            this.RespuestaTxt.Location = new System.Drawing.Point(16, 188);
            this.RespuestaTxt.Multiline = true;
            this.RespuestaTxt.Name = "RespuestaTxt";
            this.RespuestaTxt.Size = new System.Drawing.Size(623, 221);
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
            this.CorrectaMult.Location = new System.Drawing.Point(552, 183);
            this.CorrectaMult.Name = "CorrectaMult";
            this.CorrectaMult.Size = new System.Drawing.Size(67, 245);
            this.CorrectaMult.TabIndex = 33;
            this.CorrectaMult.Visible = false;
            // 
            // check0
            // 
            this.check0.AutoSize = true;
            this.check0.Location = new System.Drawing.Point(16, 15);
            this.check0.Name = "check0";
            this.check0.Size = new System.Drawing.Size(15, 14);
            this.check0.TabIndex = 0;
            this.check0.UseVisualStyleBackColor = true;
            this.check0.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(16, 62);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(15, 14);
            this.check1.TabIndex = 1;
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(16, 110);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(15, 14);
            this.check2.TabIndex = 2;
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(16, 159);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(15, 14);
            this.check3.TabIndex = 3;
            this.check3.UseVisualStyleBackColor = true;
            this.check3.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(16, 207);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(15, 14);
            this.check4.TabIndex = 4;
            this.check4.UseVisualStyleBackColor = true;
            this.check4.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // CrearPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.CorrectaMult);
            this.Controls.Add(this.crear);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enunciado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RespuestaTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button button1;
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
    }
}