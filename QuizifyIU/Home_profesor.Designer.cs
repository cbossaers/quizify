namespace QuizifyIU
{
    partial class Home_profesor
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
            this.mensaje = new QuizifyIU.Controles_extra.label();
            this.enviar = new QuizifyIU.Controles_extra.Botones_fancy();
            this.nombre_quiz = new System.Windows.Forms.Label();
            this.cursos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mensaje
            // 
            this.mensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mensaje.BackColor = System.Drawing.SystemColors.Window;
            this.mensaje.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.mensaje.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.mensaje.BorderRadius = 12;
            this.mensaje.BorderSize = 2;
            this.mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mensaje.Location = new System.Drawing.Point(145, 175);
            this.mensaje.Margin = new System.Windows.Forms.Padding(4);
            this.mensaje.Multiline = true;
            this.mensaje.Name = "mensaje";
            this.mensaje.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.mensaje.PasswordChar = false;
            this.mensaje.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.mensaje.PlaceholderText = "";
            this.mensaje.Size = new System.Drawing.Size(420, 135);
            this.mensaje.TabIndex = 0;
            this.mensaje.Texts = "";
            this.mensaje.UnderlinedStyle = false;
            // 
            // enviar
            // 
            this.enviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enviar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.enviar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.enviar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.enviar.BorderRadius = 20;
            this.enviar.BorderSize = 0;
            this.enviar.FlatAppearance.BorderSize = 0;
            this.enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviar.ForeColor = System.Drawing.Color.White;
            this.enviar.Location = new System.Drawing.Point(415, 317);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(150, 40);
            this.enviar.TabIndex = 1;
            this.enviar.Text = "Enviar Mensaje";
            this.enviar.TextColor = System.Drawing.Color.White;
            this.enviar.UseVisualStyleBackColor = false;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // nombre_quiz
            // 
            this.nombre_quiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombre_quiz.AutoSize = true;
            this.nombre_quiz.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombre_quiz.Location = new System.Drawing.Point(115, 120);
            this.nombre_quiz.Name = "nombre_quiz";
            this.nombre_quiz.Size = new System.Drawing.Size(330, 24);
            this.nombre_quiz.TabIndex = 6;
            this.nombre_quiz.Text = "Mensaje para los alumnos del curso ";
            // 
            // cursos
            // 
            this.cursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cursos.FormattingEnabled = true;
            this.cursos.Location = new System.Drawing.Point(444, 124);
            this.cursos.Name = "cursos";
            this.cursos.Size = new System.Drawing.Size(121, 23);
            this.cursos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Bienvenido, ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "La hora actual es ";
            // 
            // lbTiempo
            // 
            this.lbTiempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTiempo.Location = new System.Drawing.Point(150, 57);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(99, 20);
            this.lbTiempo.TabIndex = 31;
            this.lbTiempo.Text = "Bienvenido, ";
            // 
            // Home_profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(714, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cursos);
            this.Controls.Add(this.nombre_quiz);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.mensaje);
            this.Name = "Home_profesor";
            this.Text = "Home_profesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_extra.label mensaje;
        private Controles_extra.Botones_fancy enviar;
        private System.Windows.Forms.Label nombre_quiz;
        private System.Windows.Forms.ComboBox cursos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTiempo;
    }
}