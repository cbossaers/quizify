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
            this.botones_fancy1 = new QuizifyIU.Controles_extra.Botones_fancy();
            this.botones_fancy2 = new QuizifyIU.Controles_extra.Botones_fancy();
            this.SuspendLayout();
            // 
            // preguntas
            // 
            this.preguntas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preguntas.BackColor = System.Drawing.SystemColors.Window;
            this.preguntas.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.preguntas.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.preguntas.BorderRadius = 0;
            this.preguntas.BorderSize = 2;
            this.preguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.preguntas.Location = new System.Drawing.Point(35, 81);
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
            // botones_fancy1
            // 
            this.botones_fancy1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botones_fancy1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botones_fancy1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botones_fancy1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botones_fancy1.BorderRadius = 20;
            this.botones_fancy1.BorderSize = 0;
            this.botones_fancy1.FlatAppearance.BorderSize = 0;
            this.botones_fancy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones_fancy1.ForeColor = System.Drawing.Color.White;
            this.botones_fancy1.Location = new System.Drawing.Point(163, 119);
            this.botones_fancy1.Name = "botones_fancy1";
            this.botones_fancy1.Size = new System.Drawing.Size(122, 40);
            this.botones_fancy1.TabIndex = 7;
            this.botones_fancy1.Text = "Crear examen";
            this.botones_fancy1.TextColor = System.Drawing.Color.White;
            this.botones_fancy1.UseVisualStyleBackColor = false;
            this.botones_fancy1.Click += new System.EventHandler(this.botones_fancy1_Click);
            // 
            // botones_fancy2
            // 
            this.botones_fancy2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botones_fancy2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.botones_fancy2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.botones_fancy2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botones_fancy2.BorderRadius = 20;
            this.botones_fancy2.BorderSize = 0;
            this.botones_fancy2.FlatAppearance.BorderSize = 0;
            this.botones_fancy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones_fancy2.ForeColor = System.Drawing.Color.White;
            this.botones_fancy2.Location = new System.Drawing.Point(35, 119);
            this.botones_fancy2.Name = "botones_fancy2";
            this.botones_fancy2.Size = new System.Drawing.Size(122, 40);
            this.botones_fancy2.TabIndex = 8;
            this.botones_fancy2.Text = "Cancelar y volver";
            this.botones_fancy2.TextColor = System.Drawing.Color.White;
            this.botones_fancy2.UseVisualStyleBackColor = false;
            this.botones_fancy2.Click += new System.EventHandler(this.botones_fancy2_Click);
            // 
            // num_preg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 174);
            this.ControlBox = false;
            this.Controls.Add(this.botones_fancy2);
            this.Controls.Add(this.botones_fancy1);
            this.Controls.Add(this.nombre_quiz);
            this.Controls.Add(this.preguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "num_preg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Numero_preguntas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_extra.label preguntas;
        private System.Windows.Forms.Label nombre_quiz;
        private Controles_extra.Botones_fancy botones_fancy1;
        private Controles_extra.Botones_fancy botones_fancy2;
    }
}