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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.apellidosBox = new System.Windows.Forms.TextBox();
            this.contraBox = new System.Windows.Forms.TextBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.tipoUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para crear una cuenta en QUIZIFY, debe completar los siguientes campos de texto c" +
    "orrectamente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(42, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de usuario";
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(192, 113);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(182, 23);
            this.nombreBox.TabIndex = 6;
            this.nombreBox.TextChanged += new System.EventHandler(this.nombreBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(192, 210);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(182, 23);
            this.emailBox.TabIndex = 7;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // apellidosBox
            // 
            this.apellidosBox.Location = new System.Drawing.Point(192, 162);
            this.apellidosBox.Name = "apellidosBox";
            this.apellidosBox.Size = new System.Drawing.Size(182, 23);
            this.apellidosBox.TabIndex = 9;
            this.apellidosBox.TextChanged += new System.EventHandler(this.apellidosBox_TextChanged);
            // 
            // contraBox
            // 
            this.contraBox.Location = new System.Drawing.Point(192, 265);
            this.contraBox.Name = "contraBox";
            this.contraBox.PasswordChar = '*';
            this.contraBox.Size = new System.Drawing.Size(182, 23);
            this.contraBox.TabIndex = 10;
            this.contraBox.TextChanged += new System.EventHandler(this.contraBox_TextChanged);
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(192, 373);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(75, 23);
            this.bVolver.TabIndex = 12;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bConfirmar
            // 
            this.bConfirmar.Enabled = false;
            this.bConfirmar.Location = new System.Drawing.Point(299, 373);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(75, 23);
            this.bConfirmar.TabIndex = 13;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.FormattingEnabled = true;
            this.tipoUsuario.Items.AddRange(new object[] {
            "Alumno",
            "Profesor",
            "Institucion"});
            this.tipoUsuario.Location = new System.Drawing.Point(192, 315);
            this.tipoUsuario.Name = "tipoUsuario";
            this.tipoUsuario.Size = new System.Drawing.Size(182, 23);
            this.tipoUsuario.TabIndex = 14;
            this.tipoUsuario.Text = "Elige un tipo de usuario.";
            this.tipoUsuario.SelectedIndexChanged += new System.EventHandler(this.tipoUsuario_SelectedIndexChanged_1);
            // 
            // registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 418);
            this.Controls.Add(this.tipoUsuario);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.contraBox);
            this.Controls.Add(this.apellidosBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "registrarse";
            this.Text = "registrarse";
            this.Load += new System.EventHandler(this.registrarse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox apellidosBox;
        private System.Windows.Forms.TextBox contraBox;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.ComboBox tipoUsuario;
    }
}