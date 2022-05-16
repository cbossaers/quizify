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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaExamenDisponible = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ini2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_fin2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competenciaTransversal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaExamenFinalizado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calificar = new System.Windows.Forms.Button();
            this.tablaExamenesProfesor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenFinalizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenesProfesor)).BeginInit();
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
            this.dataGridViewTextBoxColumn17,
            this.titulo2,
            this.descripcion2,
            this.estado,
            this.tiempo2,
            this.fecha_ini2,
            this.fecha_fin2,
            this.curso2,
            this.competenciaTransversal});
            this.tablaExamenDisponible.Location = new System.Drawing.Point(10, 71);
            this.tablaExamenDisponible.MultiSelect = false;
            this.tablaExamenDisponible.Name = "tablaExamenDisponible";
            this.tablaExamenDisponible.ReadOnly = true;
            this.tablaExamenDisponible.RowHeadersVisible = false;
            this.tablaExamenDisponible.RowHeadersWidth = 62;
            this.tablaExamenDisponible.RowTemplate.Height = 25;
            this.tablaExamenDisponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaExamenDisponible.Size = new System.Drawing.Size(584, 164);
            this.tablaExamenDisponible.TabIndex = 0;
            this.tablaExamenDisponible.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaExamenDisponible_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn17.HeaderText = "Id";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // titulo2
            // 
            this.titulo2.DataPropertyName = "titulo";
            this.titulo2.HeaderText = "Título";
            this.titulo2.MinimumWidth = 8;
            this.titulo2.Name = "titulo2";
            this.titulo2.ReadOnly = true;
            this.titulo2.Width = 90;
            // 
            // descripcion2
            // 
            this.descripcion2.DataPropertyName = "descripcion";
            this.descripcion2.HeaderText = "Descripción";
            this.descripcion2.MinimumWidth = 8;
            this.descripcion2.Name = "descripcion2";
            this.descripcion2.ReadOnly = true;
            this.descripcion2.Width = 150;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 8;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 90;
            // 
            // tiempo2
            // 
            this.tiempo2.DataPropertyName = "tiempo";
            this.tiempo2.HeaderText = "Tiempo";
            this.tiempo2.MinimumWidth = 8;
            this.tiempo2.Name = "tiempo2";
            this.tiempo2.ReadOnly = true;
            this.tiempo2.Width = 55;
            // 
            // fecha_ini2
            // 
            this.fecha_ini2.DataPropertyName = "fecha_ini";
            this.fecha_ini2.HeaderText = "Fecha Ini";
            this.fecha_ini2.MinimumWidth = 8;
            this.fecha_ini2.Name = "fecha_ini2";
            this.fecha_ini2.ReadOnly = true;
            this.fecha_ini2.Width = 80;
            // 
            // fecha_fin2
            // 
            this.fecha_fin2.DataPropertyName = "fecha_fin";
            this.fecha_fin2.HeaderText = "Fecha Fin";
            this.fecha_fin2.MinimumWidth = 8;
            this.fecha_fin2.Name = "fecha_fin2";
            this.fecha_fin2.ReadOnly = true;
            this.fecha_fin2.Width = 80;
            // 
            // curso2
            // 
            this.curso2.DataPropertyName = "curso";
            this.curso2.HeaderText = "Curso";
            this.curso2.MinimumWidth = 8;
            this.curso2.Name = "curso2";
            this.curso2.ReadOnly = true;
            this.curso2.Width = 60;
            // 
            // competenciaTransversal
            // 
            this.competenciaTransversal.DataPropertyName = "ct";
            this.competenciaTransversal.HeaderText = "CT";
            this.competenciaTransversal.MinimumWidth = 8;
            this.competenciaTransversal.Name = "competenciaTransversal";
            this.competenciaTransversal.ReadOnly = true;
            this.competenciaTransversal.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mis Quiz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quiz disponibles:";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quiz finalizados:";
            // 
            // tablaExamenFinalizado
            // 
            this.tablaExamenFinalizado.AllowUserToAddRows = false;
            this.tablaExamenFinalizado.AllowUserToDeleteRows = false;
            this.tablaExamenFinalizado.AllowUserToResizeColumns = false;
            this.tablaExamenFinalizado.AllowUserToResizeRows = false;
            this.tablaExamenFinalizado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaExamenFinalizado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaExamenFinalizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaExamenFinalizado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn18,
            this.Nota});
            this.tablaExamenFinalizado.Location = new System.Drawing.Point(9, 262);
            this.tablaExamenFinalizado.MultiSelect = false;
            this.tablaExamenFinalizado.Name = "tablaExamenFinalizado";
            this.tablaExamenFinalizado.ReadOnly = true;
            this.tablaExamenFinalizado.RowHeadersVisible = false;
            this.tablaExamenFinalizado.RowHeadersWidth = 62;
            this.tablaExamenFinalizado.RowTemplate.Height = 25;
            this.tablaExamenFinalizado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaExamenFinalizado.Size = new System.Drawing.Size(634, 176);
            this.tablaExamenFinalizado.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 42;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Título";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 62;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 94;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 67;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tiempo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tiempo";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 72;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha_ini";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha Ini";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 79;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_fin";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha Fin";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 82;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "curso";
            this.dataGridViewTextBoxColumn8.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 63;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ct";
            this.dataGridViewTextBoxColumn18.HeaderText = "CT";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 46;
            // 
            // Nota
            // 
            this.Nota.DataPropertyName = "nota";
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 8;
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            this.Nota.Width = 58;
            // 
            // calificar
            // 
            this.calificar.Location = new System.Drawing.Point(518, 16);
            this.calificar.Name = "calificar";
            this.calificar.Size = new System.Drawing.Size(75, 23);
            this.calificar.TabIndex = 8;
            this.calificar.Text = "Calificar";
            this.calificar.UseVisualStyleBackColor = true;
            this.calificar.Visible = false;
            this.calificar.Click += new System.EventHandler(this.EvCalificar);
            // 
            // tablaExamenesProfesor
            // 
            this.tablaExamenesProfesor.AllowUserToAddRows = false;
            this.tablaExamenesProfesor.AllowUserToDeleteRows = false;
            this.tablaExamenesProfesor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaExamenesProfesor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaExamenesProfesor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.tablaExamenesProfesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaExamenesProfesor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaExamenesProfesor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaExamenesProfesor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaExamenesProfesor.ColumnHeadersHeight = 26;
            this.tablaExamenesProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaExamenesProfesor.EnableHeadersVisualStyles = false;
            this.tablaExamenesProfesor.GridColor = System.Drawing.Color.White;
            this.tablaExamenesProfesor.Location = new System.Drawing.Point(10, 48);
            this.tablaExamenesProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaExamenesProfesor.Name = "tablaExamenesProfesor";
            this.tablaExamenesProfesor.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaExamenesProfesor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaExamenesProfesor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaExamenesProfesor.Size = new System.Drawing.Size(644, 390);
            this.tablaExamenesProfesor.TabIndex = 9;
            this.tablaExamenesProfesor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaExamenesProfesor_CellMouseDoubleClick);
            // 
            // MisExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.calificar);
            this.Controls.Add(this.tablaExamenFinalizado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaExamenDisponible);
            this.Controls.Add(this.tablaExamenesProfesor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisExamenes";
            this.Text = "MisExamenes";
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenFinalizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenesProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaExamenDisponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tablaExamenFinalizado;
        private System.Windows.Forms.Button calificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ini2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_fin2;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso2;
        private System.Windows.Forms.DataGridViewTextBoxColumn competenciaTransversal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridView tablaExamenesProfesor;
    }
}