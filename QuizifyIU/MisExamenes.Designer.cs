namespace QuizifyIU
{
    partial class MisExamenes
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
            this.tablaExamenDisponible = new System.Windows.Forms.DataGridView();
            this.examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tablaExamenResuelto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenResuelto)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaExamenDisponible
            // 
            this.tablaExamenDisponible.AllowUserToAddRows = false;
            this.tablaExamenDisponible.AllowUserToDeleteRows = false;
            this.tablaExamenDisponible.AllowUserToResizeColumns = false;
            this.tablaExamenDisponible.AllowUserToResizeRows = false;
            this.tablaExamenDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaExamenDisponible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examen,
            this.asignatura,
            this.tiempo,
            this.inicio,
            this.fin});
            this.tablaExamenDisponible.Location = new System.Drawing.Point(12, 71);
            this.tablaExamenDisponible.MultiSelect = false;
            this.tablaExamenDisponible.Name = "tablaExamenDisponible";
            this.tablaExamenDisponible.ReadOnly = true;
            this.tablaExamenDisponible.RowTemplate.Height = 25;
            this.tablaExamenDisponible.Size = new System.Drawing.Size(543, 167);
            this.tablaExamenDisponible.TabIndex = 0;
            this.tablaExamenDisponible.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaExamenDisponible_CellContentClick);
            // 
            // examen
            // 
            this.examen.DataPropertyName = "examen";
            this.examen.HeaderText = "Examen";
            this.examen.Name = "examen";
            this.examen.ReadOnly = true;
            // 
            // asignatura
            // 
            this.asignatura.DataPropertyName = "asignatura";
            this.asignatura.HeaderText = "Asignatura";
            this.asignatura.Name = "asignatura";
            this.asignatura.ReadOnly = true;
            // 
            // tiempo
            // 
            this.tiempo.DataPropertyName = "tiempo";
            this.tiempo.HeaderText = "Tiempo";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            // 
            // inicio
            // 
            this.inicio.DataPropertyName = "inicio";
            this.inicio.HeaderText = "Inicio";
            this.inicio.Name = "inicio";
            this.inicio.ReadOnly = true;
            // 
            // fin
            // 
            this.fin.DataPropertyName = "fin";
            this.fin.HeaderText = "Fin";
            this.fin.Name = "fin";
            this.fin.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mis Exámenes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exámenes disponibles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exámenes resueltos:";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // tablaExamenResuelto
            // 
            this.tablaExamenResuelto.AllowUserToAddRows = false;
            this.tablaExamenResuelto.AllowUserToDeleteRows = false;
            this.tablaExamenResuelto.AllowUserToResizeColumns = false;
            this.tablaExamenResuelto.AllowUserToResizeRows = false;
            this.tablaExamenResuelto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaExamenResuelto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tablaExamenResuelto.Location = new System.Drawing.Point(9, 271);
            this.tablaExamenResuelto.MultiSelect = false;
            this.tablaExamenResuelto.Name = "tablaExamenResuelto";
            this.tablaExamenResuelto.ReadOnly = true;
            this.tablaExamenResuelto.RowTemplate.Height = 25;
            this.tablaExamenResuelto.Size = new System.Drawing.Size(543, 167);
            this.tablaExamenResuelto.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "examen";
            this.dataGridViewTextBoxColumn1.HeaderText = "Examen";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "asignatura";
            this.dataGridViewTextBoxColumn2.HeaderText = "Asignatura";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tiempo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tiempo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "inicio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Inicio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fin";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fin";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // MisExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.tablaExamenResuelto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaExamenDisponible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisExamenes";
            this.Text = "MisExamenes";
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenResuelto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaExamenDisponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridViewTextBoxColumn examen;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin;
        private System.Windows.Forms.DataGridView tablaExamenResuelto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}