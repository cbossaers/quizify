﻿namespace QuizifyIU
{
    partial class ApuntarseCurso
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
            this.codBox = new System.Windows.Forms.TextBox();
            this.contraBox = new System.Windows.Forms.TextBox();
            this.bApuntarse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.correoProfeBox = new System.Windows.Forms.TextBox();
            this.bVolver = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // codBox
            // 
            this.codBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codBox.Location = new System.Drawing.Point(291, 126);
            this.codBox.Name = "codBox";
            this.codBox.Size = new System.Drawing.Size(153, 23);
            this.codBox.TabIndex = 2;
            this.codBox.TextChanged += new System.EventHandler(this.codBox_TextChanged);
            // 
            // contraBox
            // 
            this.contraBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contraBox.Location = new System.Drawing.Point(291, 238);
            this.contraBox.Name = "contraBox";
            this.contraBox.Size = new System.Drawing.Size(153, 23);
            this.contraBox.TabIndex = 3;
            this.contraBox.TextChanged += new System.EventHandler(this.contraBox_TextChanged);
            // 
            // bApuntarse
            // 
            this.bApuntarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bApuntarse.Location = new System.Drawing.Point(389, 311);
            this.bApuntarse.Name = "bApuntarse";
            this.bApuntarse.Size = new System.Drawing.Size(75, 23);
            this.bApuntarse.TabIndex = 4;
            this.bApuntarse.Text = "Confirmar";
            this.bApuntarse.UseVisualStyleBackColor = true;
            this.bApuntarse.Click += new System.EventHandler(this.bApuntarse_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Correo del profesor:";
            // 
            // correoProfeBox
            // 
            this.correoProfeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.correoProfeBox.Location = new System.Drawing.Point(291, 190);
            this.correoProfeBox.Name = "correoProfeBox";
            this.correoProfeBox.Size = new System.Drawing.Size(153, 23);
            this.correoProfeBox.TabIndex = 6;
            this.correoProfeBox.TextChanged += new System.EventHandler(this.correoProfeBox_TextChanged);
            // 
            // bVolver
            // 
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.bVolver.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.bVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVolver.IconSize = 30;
            this.bVolver.Location = new System.Drawing.Point(4, 12);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(78, 38);
            this.bVolver.TabIndex = 17;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // ApuntarseCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(714, 492);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.correoProfeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bApuntarse);
            this.Controls.Add(this.contraBox);
            this.Controls.Add(this.codBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ApuntarseCurso";
            this.Text = "ApuntarseCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codBox;
        private System.Windows.Forms.TextBox contraBox;
        private System.Windows.Forms.Button bApuntarse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox correoProfeBox;
        private FontAwesome.Sharp.IconButton bVolver;
    }
}