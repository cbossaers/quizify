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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // codBox
            // 
            this.codBox.Location = new System.Drawing.Point(166, 44);
            this.codBox.Name = "codBox";
            this.codBox.Size = new System.Drawing.Size(153, 23);
            this.codBox.TabIndex = 2;
            // 
            // contraBox
            // 
            this.contraBox.Location = new System.Drawing.Point(166, 98);
            this.contraBox.Name = "contraBox";
            this.contraBox.Size = new System.Drawing.Size(153, 23);
            this.contraBox.TabIndex = 3;
            // 
            // bApuntarse
            // 
            this.bApuntarse.Location = new System.Drawing.Point(244, 176);
            this.bApuntarse.Name = "bApuntarse";
            this.bApuntarse.Size = new System.Drawing.Size(75, 23);
            this.bApuntarse.TabIndex = 4;
            this.bApuntarse.Text = "Confirmar";
            this.bApuntarse.UseVisualStyleBackColor = true;
            this.bApuntarse.Click += new System.EventHandler(this.bApuntarse_Click);
            // 
            // ApuntarseCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
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
    }
}