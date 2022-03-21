namespace QuizifyIU
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.emailField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contraField = new System.Windows.Forms.TextBox();
            this.biniciarS = new System.Windows.Forms.Button();
            this.bregistrarse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a QUIZIFY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(274, 155);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(176, 23);
            this.emailField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // contraField
            // 
            this.contraField.Location = new System.Drawing.Point(274, 227);
            this.contraField.Name = "contraField";
            this.contraField.PasswordChar = '*';
            this.contraField.Size = new System.Drawing.Size(176, 23);
            this.contraField.TabIndex = 4;
            // 
            // biniciarS
            // 
            this.biniciarS.Location = new System.Drawing.Point(354, 292);
            this.biniciarS.Name = "biniciarS";
            this.biniciarS.Size = new System.Drawing.Size(96, 23);
            this.biniciarS.TabIndex = 5;
            this.biniciarS.Text = "Iniciar sesión";
            this.biniciarS.UseVisualStyleBackColor = true;
            this.biniciarS.Click += new System.EventHandler(this.biniciarS_Click);
            // 
            // bregistrarse
            // 
            this.bregistrarse.Location = new System.Drawing.Point(354, 340);
            this.bregistrarse.Name = "bregistrarse";
            this.bregistrarse.Size = new System.Drawing.Size(96, 23);
            this.bregistrarse.TabIndex = 6;
            this.bregistrarse.Text = "Registrarse";
            this.bregistrarse.UseVisualStyleBackColor = true;
            this.bregistrarse.Click += new System.EventHandler(this.bregistrarse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "¿No tienes cuenta todavía?";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bregistrarse);
            this.Controls.Add(this.biniciarS);
            this.Controls.Add(this.contraField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contraField;
        private System.Windows.Forms.Button biniciarS;
        private System.Windows.Forms.Button bregistrarse;
        private System.Windows.Forms.Label label4;
    }
}
