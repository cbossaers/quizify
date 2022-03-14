namespace QuizifyIU
{
    partial class MisPreguntas
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
            this.label1 = new System.Windows.Forms.Label();
            this.preguntaBox = new System.Windows.Forms.TextBox();
            this.bBuscarPreg = new System.Windows.Forms.Button();
            this.tablaPreguntas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mis Preguntas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por id, asignatura o autor:";
            // 
            // preguntaBox
            // 
            this.preguntaBox.Location = new System.Drawing.Point(275, 89);
            this.preguntaBox.Name = "preguntaBox";
            this.preguntaBox.Size = new System.Drawing.Size(141, 23);
            this.preguntaBox.TabIndex = 5;
            // 
            // bBuscarPreg
            // 
            this.bBuscarPreg.Location = new System.Drawing.Point(341, 357);
            this.bBuscarPreg.Name = "bBuscarPreg";
            this.bBuscarPreg.Size = new System.Drawing.Size(75, 23);
            this.bBuscarPreg.TabIndex = 6;
            this.bBuscarPreg.Text = "Buscar";
            this.bBuscarPreg.UseVisualStyleBackColor = true;
            this.bBuscarPreg.Click += new System.EventHandler(this.bBuscarPreg_Click);
            // 
            // tablaPreguntas
            // 
            this.tablaPreguntas.AllowUserToAddRows = false;
            this.tablaPreguntas.AllowUserToDeleteRows = false;
            this.tablaPreguntas.AllowUserToResizeColumns = false;
            this.tablaPreguntas.AllowUserToResizeRows = false;
            this.tablaPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.asignatura,
            this.autor});
            this.tablaPreguntas.Location = new System.Drawing.Point(73, 143);
            this.tablaPreguntas.MultiSelect = false;
            this.tablaPreguntas.Name = "tablaPreguntas";
            this.tablaPreguntas.ReadOnly = true;
            this.tablaPreguntas.RowTemplate.Height = 25;
            this.tablaPreguntas.Size = new System.Drawing.Size(343, 192);
            this.tablaPreguntas.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // asignatura
            // 
            this.asignatura.DataPropertyName = "asignatura";
            this.asignatura.HeaderText = "Asignatura";
            this.asignatura.Name = "asignatura";
            this.asignatura.ReadOnly = true;
            // 
            // autor
            // 
            this.autor.DataPropertyName = "autor";
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            // 
            // MisPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.tablaPreguntas);
            this.Controls.Add(this.bBuscarPreg);
            this.Controls.Add(this.preguntaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisPreguntas";
            this.Text = "MisPreguntas";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox preguntaBox;
        private System.Windows.Forms.Button bBuscarPreg;
        private System.Windows.Forms.DataGridView tablaPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
    }
}