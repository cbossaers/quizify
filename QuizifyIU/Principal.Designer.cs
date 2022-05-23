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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idioma = new QuizifyIU.Controles_extra.Toggle_button();
            this.emailField = new QuizifyIU.Controles_extra.label();
            this.contraField = new QuizifyIU.Controles_extra.label();
            this.bregistrarse = new System.Windows.Forms.Label();
            this.biniciarS = new QuizifyIU.Controles_extra.Botones_fancy();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(87)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(126, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a QUIZIFY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 45);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(411, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinimize.Size = new System.Drawing.Size(28, 20);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 25;
            this.btnMaximize.Location = new System.Drawing.Point(439, 2);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnMaximize.Size = new System.Drawing.Size(30, 20);
            this.btnMaximize.TabIndex = 8;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(469, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(4, 6, 4, 3);
            this.btnClose.Size = new System.Drawing.Size(28, 20);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.idioma);
            this.panelDesktop.Controls.Add(this.emailField);
            this.panelDesktop.Controls.Add(this.contraField);
            this.panelDesktop.Controls.Add(this.bregistrarse);
            this.panelDesktop.Controls.Add(this.biniciarS);
            this.panelDesktop.Controls.Add(this.label7);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label8);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 45);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(499, 389);
            this.panelDesktop.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 79;
            this.label3.Text = "EN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "ES";
            // 
            // idioma
            // 
            this.idioma.AutoSize = true;
            this.idioma.Location = new System.Drawing.Point(226, 330);
            this.idioma.MinimumSize = new System.Drawing.Size(45, 22);
            this.idioma.Name = "idioma";
            this.idioma.OffBackColor = System.Drawing.Color.Gray;
            this.idioma.OffToggleColor = System.Drawing.Color.White;
            this.idioma.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.idioma.OnToggleColor = System.Drawing.Color.White;
            this.idioma.Size = new System.Drawing.Size(45, 22);
            this.idioma.TabIndex = 77;
            this.idioma.UseVisualStyleBackColor = true;
            this.idioma.CheckedChanged += new System.EventHandler(this.EvCambiarIdioma);
            // 
            // emailField
            // 
            this.emailField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            this.emailField.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.emailField.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.emailField.BorderRadius = 12;
            this.emailField.BorderSize = 2;
            this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailField.Location = new System.Drawing.Point(150, 96);
            this.emailField.Margin = new System.Windows.Forms.Padding(4);
            this.emailField.Multiline = false;
            this.emailField.Name = "emailField";
            this.emailField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.emailField.PasswordChar = false;
            this.emailField.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.emailField.PlaceholderText = "Email";
            this.emailField.Size = new System.Drawing.Size(204, 31);
            this.emailField.TabIndex = 1;
            this.emailField.Texts = "";
            this.emailField.UnderlinedStyle = false;
            // 
            // contraField
            // 
            this.contraField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            this.contraField.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.contraField.BorderFocusColor = System.Drawing.Color.DarkSlateBlue;
            this.contraField.BorderRadius = 12;
            this.contraField.BorderSize = 2;
            this.contraField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contraField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contraField.Location = new System.Drawing.Point(150, 161);
            this.contraField.Margin = new System.Windows.Forms.Padding(4);
            this.contraField.Multiline = false;
            this.contraField.Name = "contraField";
            this.contraField.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.contraField.PasswordChar = true;
            this.contraField.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.contraField.PlaceholderText = "Contraseña";
            this.contraField.Size = new System.Drawing.Size(204, 31);
            this.contraField.TabIndex = 2;
            this.contraField.Texts = "";
            this.contraField.UnderlinedStyle = false;
            this.contraField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.biniciarS_KeyPress);
            // 
            // bregistrarse
            // 
            this.bregistrarse.AutoSize = true;
            this.bregistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bregistrarse.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.bregistrarse.Location = new System.Drawing.Point(293, 277);
            this.bregistrarse.Name = "bregistrarse";
            this.bregistrarse.Size = new System.Drawing.Size(70, 15);
            this.bregistrarse.TabIndex = 4;
            this.bregistrarse.Text = "Registrarse";
            this.bregistrarse.Click += new System.EventHandler(this.bregistrarse_Click);
            // 
            // biniciarS
            // 
            this.biniciarS.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.biniciarS.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.biniciarS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.biniciarS.BorderRadius = 12;
            this.biniciarS.BorderSize = 0;
            this.biniciarS.FlatAppearance.BorderSize = 0;
            this.biniciarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.biniciarS.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.biniciarS.ForeColor = System.Drawing.Color.White;
            this.biniciarS.Location = new System.Drawing.Point(172, 221);
            this.biniciarS.Name = "biniciarS";
            this.biniciarS.Size = new System.Drawing.Size(157, 30);
            this.biniciarS.TabIndex = 3;
            this.biniciarS.Text = "Iniciar sesión";
            this.biniciarS.TextColor = System.Drawing.Color.White;
            this.biniciarS.UseVisualStyleBackColor = false;
            this.biniciarS.Click += new System.EventHandler(this.biniciarS_Click);
            this.biniciarS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.biniciarS_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(189, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Iniciar sesión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(131, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "¿No tienes cuenta todavía?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label8.Location = new System.Drawing.Point(289, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "——————";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(499, 434);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(499, 434);
            this.Name = "Principal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Resize += new System.EventHandler(this.Form3_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label bregistrarse;
        private Controles_extra.Botones_fancy biniciarS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Controles_extra.label contraField;
        private Controles_extra.label emailField;
        private Controles_extra.Toggle_button idioma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
