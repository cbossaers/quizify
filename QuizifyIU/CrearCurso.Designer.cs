namespace QuizifyIU
{
    partial class CrearCurso
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
            this.panelCrearCurso = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.boxContraseña = new System.Windows.Forms.TextBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.bCrearCurso = new System.Windows.Forms.Button();
            this.maxAlumnos = new System.Windows.Forms.NumericUpDown();
            this.codCursoBox = new System.Windows.Forms.TextBox();
            this.nombreCursoBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCrearCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearCurso
            // 
            this.panelCrearCurso.Controls.Add(this.label5);
            this.panelCrearCurso.Controls.Add(this.boxContraseña);
            this.panelCrearCurso.Controls.Add(this.bVolver);
            this.panelCrearCurso.Controls.Add(this.bCrearCurso);
            this.panelCrearCurso.Controls.Add(this.maxAlumnos);
            this.panelCrearCurso.Controls.Add(this.codCursoBox);
            this.panelCrearCurso.Controls.Add(this.nombreCursoBox);
            this.panelCrearCurso.Controls.Add(this.label4);
            this.panelCrearCurso.Controls.Add(this.label3);
            this.panelCrearCurso.Controls.Add(this.label2);
            this.panelCrearCurso.Controls.Add(this.label1);
            this.panelCrearCurso.Location = new System.Drawing.Point(0, 0);
            this.panelCrearCurso.Name = "panelCrearCurso";
            this.panelCrearCurso.Size = new System.Drawing.Size(655, 450);
            this.panelCrearCurso.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña";
            // 
            // boxContraseña
            // 
            this.boxContraseña.Location = new System.Drawing.Point(291, 245);
            this.boxContraseña.Name = "boxContraseña";
            this.boxContraseña.Size = new System.Drawing.Size(160, 23);
            this.boxContraseña.TabIndex = 10;
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(291, 308);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(75, 23);
            this.bVolver.TabIndex = 9;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bCrearCurso
            // 
            this.bCrearCurso.Location = new System.Drawing.Point(376, 304);
            this.bCrearCurso.Name = "bCrearCurso";
            this.bCrearCurso.Size = new System.Drawing.Size(75, 27);
            this.bCrearCurso.TabIndex = 8;
            this.bCrearCurso.Text = "Crear";
            this.bCrearCurso.UseVisualStyleBackColor = true;
            this.bCrearCurso.Click += new System.EventHandler(this.bCrearCurso_Click);
            // 
            // maxAlumnos
            // 
            this.maxAlumnos.InterceptArrowKeys = false;
            this.maxAlumnos.Location = new System.Drawing.Point(367, 185);
            this.maxAlumnos.Name = "maxAlumnos";
            this.maxAlumnos.Size = new System.Drawing.Size(84, 23);
            this.maxAlumnos.TabIndex = 30;
            // 
            // codCursoBox
            // 
            this.codCursoBox.Location = new System.Drawing.Point(291, 137);
            this.codCursoBox.Name = "codCursoBox";
            this.codCursoBox.Size = new System.Drawing.Size(160, 23);
            this.codCursoBox.TabIndex = 5;
            // 
            // nombreCursoBox
            // 
            this.nombreCursoBox.Location = new System.Drawing.Point(291, 89);
            this.nombreCursoBox.Name = "nombreCursoBox";
            this.nombreCursoBox.Size = new System.Drawing.Size(160, 23);
            this.nombreCursoBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número máximo de alumnos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // CrearCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.panelCrearCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearCurso";
            this.Text = "CrearCurso";
            this.panelCrearCurso.ResumeLayout(false);
            this.panelCrearCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearCurso;
        private System.Windows.Forms.Button bCrearCurso;
        private System.Windows.Forms.NumericUpDown maxAlumnos;
        private System.Windows.Forms.TextBox codCursoBox;
        private System.Windows.Forms.TextBox nombreCursoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxContraseña;
    }
}