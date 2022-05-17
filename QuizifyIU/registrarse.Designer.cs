namespace QuizifyIU
{
    partial class registrarse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tipoUsuario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bVolver = new FontAwesome.Sharp.IconButton();
            this.bConfirmar = new QuizifyIU.Controles_extra.Botones_fancy();
            this.nombreBox = new QuizifyIU.Controles_extra.label();
            this.apellidosBox = new QuizifyIU.Controles_extra.label();
            this.emailBox = new QuizifyIU.Controles_extra.label();
            this.contraBox = new QuizifyIU.Controles_extra.label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(71, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(71, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de usuario";
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.FormattingEnabled = true;
            this.tipoUsuario.Items.AddRange(new object[] {
            "Alumno",
            "Profesor",
            "Institucion"});
            this.tipoUsuario.Location = new System.Drawing.Point(221, 287);
            this.tipoUsuario.Name = "tipoUsuario";
            this.tipoUsuario.Size = new System.Drawing.Size(182, 23);
            this.tipoUsuario.TabIndex = 14;
            this.tipoUsuario.Text = "Elige un tipo de usuario.";
            this.tipoUsuario.SelectedIndexChanged += new System.EventHandler(this.tipoUsuario_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(189, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Registro";
            // 
            // bVolver
            // 
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.bVolver.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.bVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVolver.IconSize = 30;
            this.bVolver.Location = new System.Drawing.Point(-1, 16);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(78, 38);
            this.bVolver.TabIndex = 16;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bConfirmar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bConfirmar.BorderRadius = 15;
            this.bConfirmar.BorderSize = 0;
            this.bConfirmar.FlatAppearance.BorderSize = 0;
            this.bConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfirmar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bConfirmar.ForeColor = System.Drawing.Color.White;
            this.bConfirmar.Location = new System.Drawing.Point(237, 336);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(149, 32);
            this.bConfirmar.TabIndex = 17;
            this.bConfirmar.Text = "Registrarse";
            this.bConfirmar.TextColor = System.Drawing.Color.White;
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            this.bConfirmar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bConfirmar_KeyPress);
            // 
            // nombreBox
            // 
            this.nombreBox.BackColor = System.Drawing.SystemColors.Window;
            this.nombreBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nombreBox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.nombreBox.BorderRadius = 12;
            this.nombreBox.BorderSize = 2;
            this.nombreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombreBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nombreBox.Location = new System.Drawing.Point(221, 67);
            this.nombreBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreBox.Multiline = false;
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nombreBox.PasswordChar = false;
            this.nombreBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nombreBox.PlaceholderText = "";
            this.nombreBox.Size = new System.Drawing.Size(182, 31);
            this.nombreBox.TabIndex = 18;
            this.nombreBox.Text = "";
            this.nombreBox.UnderlinedStyle = false;
            this.nombreBox._TextChanged += new System.EventHandler(this.nombreBox_TextChanged);
            // 
            // apellidosBox
            // 
            this.apellidosBox.BackColor = System.Drawing.SystemColors.Window;
            this.apellidosBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.apellidosBox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.apellidosBox.BorderRadius = 12;
            this.apellidosBox.BorderSize = 2;
            this.apellidosBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apellidosBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.apellidosBox.Location = new System.Drawing.Point(221, 124);
            this.apellidosBox.Margin = new System.Windows.Forms.Padding(4);
            this.apellidosBox.Multiline = false;
            this.apellidosBox.Name = "apellidosBox";
            this.apellidosBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.apellidosBox.PasswordChar = false;
            this.apellidosBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.apellidosBox.PlaceholderText = "";
            this.apellidosBox.Size = new System.Drawing.Size(182, 31);
            this.apellidosBox.TabIndex = 19;
            this.apellidosBox.Texts = "";
            this.apellidosBox.UnderlinedStyle = false;
            this.apellidosBox._TextChanged += new System.EventHandler(this.apellidosBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.emailBox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.emailBox.BorderRadius = 12;
            this.emailBox.BorderSize = 2;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailBox.Location = new System.Drawing.Point(221, 174);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailBox.Multiline = false;
            this.emailBox.Name = "emailBox";
            this.emailBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.emailBox.PasswordChar = false;
            this.emailBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.emailBox.PlaceholderText = "";
            this.emailBox.Size = new System.Drawing.Size(182, 31);
            this.emailBox.TabIndex = 20;
            this.emailBox.Texts = "";
            this.emailBox.UnderlinedStyle = false;
            this.emailBox._TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // contraBox
            // 
            this.contraBox.BackColor = System.Drawing.SystemColors.Window;
            this.contraBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.contraBox.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.contraBox.BorderRadius = 12;
            this.contraBox.BorderSize = 2;
            this.contraBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contraBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contraBox.Location = new System.Drawing.Point(221, 230);
            this.contraBox.Margin = new System.Windows.Forms.Padding(4);
            this.contraBox.Multiline = false;
            this.contraBox.Name = "contraBox";
            this.contraBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.contraBox.PasswordChar = false;
            this.contraBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.contraBox.PlaceholderText = "";
            this.contraBox.Size = new System.Drawing.Size(182, 31);
            this.contraBox.TabIndex = 21;
            this.contraBox.Texts = "";
            this.contraBox.UnderlinedStyle = false;
            this.contraBox._TextChanged += new System.EventHandler(this.contraBox_TextChanged);
            // 
            // registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(483, 395);
            this.Controls.Add(this.contraBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.apellidosBox);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tipoUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "registrarse";
            this.Text = "registrarse";
            this.Load += new System.EventHandler(this.registrarse_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bConfirmar_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipoUsuario;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton bVolver;
        private Controles_extra.Botones_fancy bConfirmar;
        private Controles_extra.label nombreBox;
        private Controles_extra.label apellidosBox;
        private Controles_extra.label emailBox;
        private Controles_extra.label contraBox;
    }
}