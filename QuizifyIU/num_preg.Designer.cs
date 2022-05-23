namespace QuizifyIU
{
    partial class num_preg
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
            this.preguntas = new QuizifyIU.Controles_extra.label();
            this.nombre_quiz = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botones_fancy2 = new System.Windows.Forms.Button();
            this.botones_fancy1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // preguntas
            // 
            this.preguntas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preguntas.BackColor = System.Drawing.SystemColors.Window;
            this.preguntas.BorderColor = System.Drawing.Color.Navy;
            this.preguntas.BorderFocusColor = System.Drawing.Color.Navy;
            this.preguntas.BorderRadius = 0;
            this.preguntas.BorderSize = 2;
            this.preguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.preguntas.Location = new System.Drawing.Point(35, 80);
            this.preguntas.Margin = new System.Windows.Forms.Padding(4);
            this.preguntas.Multiline = false;
            this.preguntas.Name = "preguntas";
            this.preguntas.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.preguntas.PasswordChar = false;
            this.preguntas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.preguntas.PlaceholderText = "";
            this.preguntas.Size = new System.Drawing.Size(250, 31);
            this.preguntas.TabIndex = 0;
            this.preguntas.Texts = "";
            this.preguntas.UnderlinedStyle = false;
            // 
            // nombre_quiz
            // 
            this.nombre_quiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombre_quiz.AutoSize = true;
            this.nombre_quiz.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombre_quiz.Location = new System.Drawing.Point(35, 45);
            this.nombre_quiz.Name = "nombre_quiz";
            this.nombre_quiz.Size = new System.Drawing.Size(234, 20);
            this.nombre_quiz.TabIndex = 6;
            this.nombre_quiz.Text = "Numero de preguntas del quiz";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.botones_fancy1);
            this.panel1.Controls.Add(this.botones_fancy2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 174);
            this.panel1.TabIndex = 9;
            // 
            // botones_fancy2
            // 
            this.botones_fancy2.Location = new System.Drawing.Point(35, 120);
            this.botones_fancy2.Name = "botones_fancy2";
            this.botones_fancy2.Size = new System.Drawing.Size(122, 31);
            this.botones_fancy2.TabIndex = 0;
            this.botones_fancy2.Text = "Cancelar y volver";
            this.botones_fancy2.UseVisualStyleBackColor = true;
            this.botones_fancy2.Click += new System.EventHandler(this.botones_fancy2_Click);
            // 
            // botones_fancy1
            // 
            this.botones_fancy1.Location = new System.Drawing.Point(163, 119);
            this.botones_fancy1.Name = "botones_fancy1";
            this.botones_fancy1.Size = new System.Drawing.Size(120, 32);
            this.botones_fancy1.TabIndex = 1;
            this.botones_fancy1.Text = "Crear examen";
            this.botones_fancy1.UseVisualStyleBackColor = true;
            this.botones_fancy1.Click += new System.EventHandler(this.botones_fancy1_Click);
            // 
            // num_preg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(331, 174);
            this.ControlBox = false;
            this.Controls.Add(this.nombre_quiz);
            this.Controls.Add(this.preguntas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "num_preg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Numero_preguntas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_extra.label preguntas;
        private System.Windows.Forms.Label nombre_quiz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botones_fancy1;
        private System.Windows.Forms.Button botones_fancy2;
    }
}