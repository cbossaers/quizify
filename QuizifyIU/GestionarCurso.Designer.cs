namespace QuizifyIU
{
    partial class GestionarCurso
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
            this.panelGestionarCurso = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bAñadir = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.alumnoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cursoBox = new System.Windows.Forms.TextBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.panelGestionarCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGestionarCurso
            // 
            this.panelGestionarCurso.Controls.Add(this.button1);
            this.panelGestionarCurso.Controls.Add(this.bAñadir);
            this.panelGestionarCurso.Controls.Add(this.bEliminar);
            this.panelGestionarCurso.Controls.Add(this.alumnoBox);
            this.panelGestionarCurso.Controls.Add(this.label2);
            this.panelGestionarCurso.Controls.Add(this.label1);
            this.panelGestionarCurso.Controls.Add(this.cursoBox);
            this.panelGestionarCurso.Controls.Add(this.bVolver);
            this.panelGestionarCurso.Location = new System.Drawing.Point(-2, -1);
            this.panelGestionarCurso.Name = "panelGestionarCurso";
            this.panelGestionarCurso.Size = new System.Drawing.Size(657, 452);
            this.panelGestionarCurso.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bAñadir
            // 
            this.bAñadir.Location = new System.Drawing.Point(222, 368);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(75, 23);
            this.bAñadir.TabIndex = 7;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(339, 368);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 6;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // alumnoBox
            // 
            this.alumnoBox.Location = new System.Drawing.Point(257, 195);
            this.alumnoBox.Name = "alumnoBox";
            this.alumnoBox.Size = new System.Drawing.Size(157, 23);
            this.alumnoBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo del alumno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código del curso:";
            // 
            // cursoBox
            // 
            this.cursoBox.Location = new System.Drawing.Point(257, 140);
            this.cursoBox.Name = "cursoBox";
            this.cursoBox.Size = new System.Drawing.Size(157, 23);
            this.cursoBox.TabIndex = 2;
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(48, 368);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(75, 23);
            this.bVolver.TabIndex = 1;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // GestionarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.panelGestionarCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarCurso";
            this.Text = "GestionarCurso";
            this.panelGestionarCurso.ResumeLayout(false);
            this.panelGestionarCurso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGestionarCurso;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.TextBox alumnoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cursoBox;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bAñadir;
        private System.Windows.Forms.Button button1;
    }
}