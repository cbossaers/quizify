﻿namespace QuizifyIU
{
    partial class ComprarBono
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
            this.tarjetaBox = new System.Windows.Forms.TextBox();
            this.titularBox = new System.Windows.Forms.TextBox();
            this.codSegBox = new System.Windows.Forms.TextBox();
            this.descuentoBox = new System.Windows.Forms.TextBox();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.bVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de tarjeta:";
            // 
            // tarjetaBox
            // 
            this.tarjetaBox.Location = new System.Drawing.Point(244, 138);
            this.tarjetaBox.Name = "tarjetaBox";
            this.tarjetaBox.Size = new System.Drawing.Size(181, 23);
            this.tarjetaBox.TabIndex = 1;
            this.tarjetaBox.TextChanged += new System.EventHandler(this.tarjetaBox_TextChanged);
            // 
            // titularBox
            // 
            this.titularBox.Location = new System.Drawing.Point(244, 204);
            this.titularBox.Name = "titularBox";
            this.titularBox.Size = new System.Drawing.Size(181, 23);
            this.titularBox.TabIndex = 2;
            this.titularBox.TextChanged += new System.EventHandler(this.titularBox_TextChanged);
            // 
            // codSegBox
            // 
            this.codSegBox.Location = new System.Drawing.Point(244, 277);
            this.codSegBox.Name = "codSegBox";
            this.codSegBox.Size = new System.Drawing.Size(181, 23);
            this.codSegBox.TabIndex = 3;
            // 
            // descuentoBox
            // 
            this.descuentoBox.Location = new System.Drawing.Point(244, 340);
            this.descuentoBox.Name = "descuentoBox";
            this.descuentoBox.Size = new System.Drawing.Size(181, 23);
            this.descuentoBox.TabIndex = 4;
            // 
            // bConfirmar
            // 
            this.bConfirmar.Location = new System.Drawing.Point(358, 390);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(67, 23);
            this.bConfirmar.TabIndex = 5;
            this.bConfirmar.Text = "Comprar";
            this.bConfirmar.UseVisualStyleBackColor = true;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(244, 390);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(55, 23);
            this.bVolver.TabIndex = 6;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titular de la tarjeta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código de seguridad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código de descuento (opcional):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Elige el número de bonos que quieres comprar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "10",
            "50",
            "100"});
            this.comboBox1.Location = new System.Drawing.Point(330, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 23);
            this.comboBox1.TabIndex = 11;
            // 
            // ComprarBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(710, 490);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bConfirmar);
            this.Controls.Add(this.descuentoBox);
            this.Controls.Add(this.codSegBox);
            this.Controls.Add(this.titularBox);
            this.Controls.Add(this.tarjetaBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprarBono";
            this.Text = "ComprarBono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tarjetaBox;
        private System.Windows.Forms.TextBox titularBox;
        private System.Windows.Forms.TextBox codSegBox;
        private System.Windows.Forms.TextBox descuentoBox;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}