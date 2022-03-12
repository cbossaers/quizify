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
            this.opcA = new System.Windows.Forms.TextBox();
            this.opcB = new System.Windows.Forms.TextBox();
            this.opcC = new System.Windows.Forms.TextBox();
            this.opcD = new System.Windows.Forms.TextBox();
            this.opcE = new System.Windows.Forms.TextBox();
            this.letraA = new System.Windows.Forms.Label();
            this.letraB = new System.Windows.Forms.Label();
            this.letraC = new System.Windows.Forms.Label();
            this.letraD = new System.Windows.Forms.Label();
            this.letraE = new System.Windows.Forms.Label();
            this.botonAdd = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.correctaA = new System.Windows.Forms.RadioButton();
            this.correctaB = new System.Windows.Forms.RadioButton();
            this.correctaC = new System.Windows.Forms.RadioButton();
            this.correctaD = new System.Windows.Forms.RadioButton();
            this.correctaE = new System.Windows.Forms.RadioButton();
            this.correcta = new System.Windows.Forms.Panel();
            this.correcta.SuspendLayout();
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
            "Verdadero Falso"});
            this.tipoPregunta.Location = new System.Drawing.Point(12, 151);
            this.tipoPregunta.Name = "tipoPregunta";
            this.tipoPregunta.Size = new System.Drawing.Size(121, 23);
            this.tipoPregunta.TabIndex = 6;
            this.tipoPregunta.Text = "Tipo de pregunta";
            this.tipoPregunta.SelectedIndexChanged += new System.EventHandler(this.CambiaTipoPregunta);
            // 
            // opcA
            // 
            this.opcA.Location = new System.Drawing.Point(46, 194);
            this.opcA.Name = "opcA";
            this.opcA.Size = new System.Drawing.Size(486, 23);
            this.opcA.TabIndex = 7;
            this.opcA.Visible = false;
            // 
            // opcB
            // 
            this.opcB.Location = new System.Drawing.Point(46, 240);
            this.opcB.Name = "opcB";
            this.opcB.Size = new System.Drawing.Size(486, 23);
            this.opcB.TabIndex = 8;
            this.opcB.Visible = false;
            // 
            // opcC
            // 
            this.opcC.Location = new System.Drawing.Point(46, 289);
            this.opcC.Name = "opcC";
            this.opcC.Size = new System.Drawing.Size(486, 23);
            this.opcC.TabIndex = 9;
            this.opcC.Visible = false;
            // 
            // opcD
            // 
            this.opcD.Location = new System.Drawing.Point(46, 337);
            this.opcD.Name = "opcD";
            this.opcD.Size = new System.Drawing.Size(486, 23);
            this.opcD.TabIndex = 10;
            this.opcD.Visible = false;
            // 
            // opcE
            // 
            this.opcE.Location = new System.Drawing.Point(46, 386);
            this.opcE.Name = "opcE";
            this.opcE.Size = new System.Drawing.Size(486, 23);
            this.opcE.TabIndex = 11;
            this.opcE.Visible = false;
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
            // correctaA
            // 
            this.correctaA.AutoSize = true;
            this.correctaA.Location = new System.Drawing.Point(19, 16);
            this.correctaA.Name = "correctaA";
            this.correctaA.Size = new System.Drawing.Size(14, 13);
            this.correctaA.TabIndex = 19;
            this.correctaA.TabStop = true;
            this.correctaA.UseVisualStyleBackColor = true;
            // 
            // correctaB
            // 
            this.correctaB.AutoSize = true;
            this.correctaB.Location = new System.Drawing.Point(19, 63);
            this.correctaB.Name = "correctaB";
            this.correctaB.Size = new System.Drawing.Size(14, 13);
            this.correctaB.TabIndex = 21;
            this.correctaB.TabStop = true;
            this.correctaB.UseVisualStyleBackColor = true;
            // 
            // correctaC
            // 
            this.correctaC.AutoSize = true;
            this.correctaC.Location = new System.Drawing.Point(19, 110);
            this.correctaC.Name = "correctaC";
            this.correctaC.Size = new System.Drawing.Size(14, 13);
            this.correctaC.TabIndex = 22;
            this.correctaC.TabStop = true;
            this.correctaC.UseVisualStyleBackColor = true;
            // 
            // correctaD
            // 
            this.correctaD.AutoSize = true;
            this.correctaD.Location = new System.Drawing.Point(19, 158);
            this.correctaD.Name = "correctaD";
            this.correctaD.Size = new System.Drawing.Size(14, 13);
            this.correctaD.TabIndex = 23;
            this.correctaD.TabStop = true;
            this.correctaD.UseVisualStyleBackColor = true;
            this.correctaD.Visible = false;
            // 
            // correctaE
            // 
            this.correctaE.AutoSize = true;
            this.correctaE.Location = new System.Drawing.Point(19, 206);
            this.correctaE.Name = "correctaE";
            this.correctaE.Size = new System.Drawing.Size(14, 13);
            this.correctaE.TabIndex = 24;
            this.correctaE.TabStop = true;
            this.correctaE.UseVisualStyleBackColor = true;
            this.correctaE.Visible = false;
            // 
            // correcta
            // 
            this.correcta.Controls.Add(this.correctaE);
            this.correcta.Controls.Add(this.correctaA);
            this.correcta.Controls.Add(this.correctaD);
            this.correcta.Controls.Add(this.correctaB);
            this.correcta.Controls.Add(this.correctaC);
            this.correcta.Location = new System.Drawing.Point(549, 183);
            this.correcta.Name = "correcta";
            this.correcta.Size = new System.Drawing.Size(67, 245);
            this.correcta.TabIndex = 26;
            this.correcta.Visible = false;
            // 
            // CrearPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.correcta);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonAdd);
            this.Controls.Add(this.letraE);
            this.Controls.Add(this.letraD);
            this.Controls.Add(this.letraC);
            this.Controls.Add(this.letraB);
            this.Controls.Add(this.letraA);
            this.Controls.Add(this.opcE);
            this.Controls.Add(this.opcD);
            this.Controls.Add(this.opcC);
            this.Controls.Add(this.opcB);
            this.Controls.Add(this.opcA);
            this.Controls.Add(this.tipoPregunta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enunciado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearPregunta";
            this.correcta.ResumeLayout(false);
            this.correcta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enunciado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tipoPregunta;
        private System.Windows.Forms.TextBox opcA;
        private System.Windows.Forms.TextBox opcB;
        private System.Windows.Forms.TextBox opcC;
        private System.Windows.Forms.TextBox opcD;
        private System.Windows.Forms.TextBox opcE;
        private System.Windows.Forms.Label letraA;
        private System.Windows.Forms.Label letraB;
        private System.Windows.Forms.Label letraC;
        private System.Windows.Forms.Label letraD;
        private System.Windows.Forms.Label letraE;
        private System.Windows.Forms.Button botonAdd;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.RadioButton correctaA;
        private System.Windows.Forms.RadioButton correctaB;
        private System.Windows.Forms.RadioButton correctaC;
        private System.Windows.Forms.RadioButton correctaD;
        private System.Windows.Forms.RadioButton correctaE;
        private System.Windows.Forms.Panel correcta;
    }
}