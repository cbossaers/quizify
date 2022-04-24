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
            this.bCambiar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.panelGestionarCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGestionarCurso
            // 
            this.panelGestionarCurso.Controls.Add(this.bVolver);
            this.panelGestionarCurso.Controls.Add(this.bCambiar);
            this.panelGestionarCurso.Location = new System.Drawing.Point(-2, -1);
            this.panelGestionarCurso.Name = "panelGestionarCurso";
            this.panelGestionarCurso.Size = new System.Drawing.Size(657, 452);
            this.panelGestionarCurso.TabIndex = 0;
            // 
            // bCambiar
            // 
            this.bCambiar.Location = new System.Drawing.Point(475, 331);
            this.bCambiar.Name = "bCambiar";
            this.bCambiar.Size = new System.Drawing.Size(75, 23);
            this.bCambiar.TabIndex = 0;
            this.bCambiar.Text = "Cambiar";
            this.bCambiar.UseVisualStyleBackColor = true;
            this.bCambiar.Click += new System.EventHandler(this.bCambiar_Click);
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(348, 331);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGestionarCurso;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bCambiar;
    }
}