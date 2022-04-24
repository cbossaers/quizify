namespace QuizifyIU
{
    partial class CursoForm
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
            this.bCrearCurso = new System.Windows.Forms.Button();
            this.bGestionarCurso = new System.Windows.Forms.Button();
            this.panelCurso = new System.Windows.Forms.Panel();
            this.panelCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCrearCurso
            // 
            this.bCrearCurso.Location = new System.Drawing.Point(452, 330);
            this.bCrearCurso.Name = "bCrearCurso";
            this.bCrearCurso.Size = new System.Drawing.Size(75, 23);
            this.bCrearCurso.TabIndex = 4;
            this.bCrearCurso.Text = "Crear curso";
            this.bCrearCurso.UseVisualStyleBackColor = true;
            this.bCrearCurso.Click += new System.EventHandler(this.bCrearCurso_Click);
            // 
            // bGestionarCurso
            // 
            this.bGestionarCurso.Location = new System.Drawing.Point(289, 330);
            this.bGestionarCurso.Name = "bGestionarCurso";
            this.bGestionarCurso.Size = new System.Drawing.Size(121, 23);
            this.bGestionarCurso.TabIndex = 5;
            this.bGestionarCurso.Text = "Gestionar curso";
            this.bGestionarCurso.UseVisualStyleBackColor = true;
            // 
            // panelCurso
            // 
            this.panelCurso.Controls.Add(this.bCrearCurso);
            this.panelCurso.Controls.Add(this.bGestionarCurso);
            this.panelCurso.Location = new System.Drawing.Point(0, 0);
            this.panelCurso.Name = "panelCurso";
            this.panelCurso.Size = new System.Drawing.Size(653, 450);
            this.panelCurso.TabIndex = 6;
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.panelCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Curso";
            this.Text = "Curso";
            this.panelCurso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bCrearCurso;
        private System.Windows.Forms.Button bGestionarCurso;
        private System.Windows.Forms.Panel panelCurso;
    }
}