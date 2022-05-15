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
            this.bApuntarse = new System.Windows.Forms.Button();
            this.panelCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCrearCurso
            // 
            this.bCrearCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bCrearCurso.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCrearCurso.Location = new System.Drawing.Point(235, 288);
            this.bCrearCurso.Name = "bCrearCurso";
            this.bCrearCurso.Size = new System.Drawing.Size(196, 53);
            this.bCrearCurso.TabIndex = 4;
            this.bCrearCurso.Text = "Crear curso";
            this.bCrearCurso.UseVisualStyleBackColor = true;
            this.bCrearCurso.Click += new System.EventHandler(this.bCrearCurso_Click);
            // 
            // bGestionarCurso
            // 
            this.bGestionarCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bGestionarCurso.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bGestionarCurso.Location = new System.Drawing.Point(235, 177);
            this.bGestionarCurso.Name = "bGestionarCurso";
            this.bGestionarCurso.Size = new System.Drawing.Size(196, 52);
            this.bGestionarCurso.TabIndex = 5;
            this.bGestionarCurso.Text = "Gestionar curso";
            this.bGestionarCurso.UseVisualStyleBackColor = true;
            this.bGestionarCurso.Click += new System.EventHandler(this.bGestionarCurso_Click);
            // 
            // panelCurso
            // 
            this.panelCurso.Controls.Add(this.bApuntarse);
            this.panelCurso.Controls.Add(this.bCrearCurso);
            this.panelCurso.Controls.Add(this.bGestionarCurso);
            this.panelCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurso.Location = new System.Drawing.Point(0, 0);
            this.panelCurso.Name = "panelCurso";
            this.panelCurso.Size = new System.Drawing.Size(710, 490);
            this.panelCurso.TabIndex = 6;
            // 
            // bApuntarse
            // 
            this.bApuntarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bApuntarse.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bApuntarse.Location = new System.Drawing.Point(235, 66);
            this.bApuntarse.Name = "bApuntarse";
            this.bApuntarse.Size = new System.Drawing.Size(196, 51);
            this.bApuntarse.TabIndex = 6;
            this.bApuntarse.Text = "Apuntarse curso";
            this.bApuntarse.UseVisualStyleBackColor = true;
            this.bApuntarse.Click += new System.EventHandler(this.bApuntarse_Click);
            // 
            // CursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(710, 490);
            this.Controls.Add(this.panelCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CursoForm";
            this.Text = "Curso";
            this.panelCurso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bCrearCurso;
        private System.Windows.Forms.Button bGestionarCurso;
        private System.Windows.Forms.Panel panelCurso;
        private System.Windows.Forms.Button bApuntarse;
    }
}