namespace QuizifyIU
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numBonos = new System.Windows.Forms.ComboBox();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.baplicarDescuento = new System.Windows.Forms.Button();
            this.notificacionDescuento = new System.Windows.Forms.Label();
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
            this.codSegBox.Location = new System.Drawing.Point(244, 265);
            this.codSegBox.Name = "codSegBox";
            this.codSegBox.Size = new System.Drawing.Size(181, 23);
            this.codSegBox.TabIndex = 3;
            this.codSegBox.TextChanged += new System.EventHandler(this.codSegBox_TextChanged);
            // 
            // descuentoBox
            // 
            this.descuentoBox.Location = new System.Drawing.Point(244, 332);
            this.descuentoBox.Name = "descuentoBox";
            this.descuentoBox.Size = new System.Drawing.Size(181, 23);
            this.descuentoBox.TabIndex = 4;
            this.descuentoBox.TextChanged += new System.EventHandler(this.descuentoBox_TextChanged);
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
            this.label3.Location = new System.Drawing.Point(58, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código de seguridad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 335);
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
            // numBonos
            // 
            this.numBonos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numBonos.FormattingEnabled = true;
            this.numBonos.Items.AddRange(new object[] {
            "10",
            "50",
            "100"});
            this.numBonos.Location = new System.Drawing.Point(330, 66);
            this.numBonos.Name = "numBonos";
            this.numBonos.Size = new System.Drawing.Size(95, 23);
            this.numBonos.TabIndex = 11;
            this.numBonos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Location = new System.Drawing.Point(454, 69);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(121, 15);
            this.labelDescuento.TabIndex = 12;
            this.labelDescuento.Text = "hola soy el descuento";
            // 
            // baplicarDescuento
            // 
            this.baplicarDescuento.Location = new System.Drawing.Point(476, 331);
            this.baplicarDescuento.Name = "baplicarDescuento";
            this.baplicarDescuento.Size = new System.Drawing.Size(115, 23);
            this.baplicarDescuento.TabIndex = 13;
            this.baplicarDescuento.Text = "Aplicar descuento";
            this.baplicarDescuento.UseVisualStyleBackColor = true;
            this.baplicarDescuento.Click += new System.EventHandler(this.aplicarDescuento_Click);
            // 
            // notificacionDescuento
            // 
            this.notificacionDescuento.AutoSize = true;
            this.notificacionDescuento.Location = new System.Drawing.Point(476, 378);
            this.notificacionDescuento.Name = "notificacionDescuento";
            this.notificacionDescuento.Size = new System.Drawing.Size(38, 15);
            this.notificacionDescuento.TabIndex = 14;
            this.notificacionDescuento.Text = "label6";
            // 
            // ComprarBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.notificacionDescuento);
            this.Controls.Add(this.baplicarDescuento);
            this.Controls.Add(this.labelDescuento);
            this.Controls.Add(this.numBonos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox numBonos;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.Button baplicarDescuento;
        private System.Windows.Forms.Label notificacionDescuento;
    }
}