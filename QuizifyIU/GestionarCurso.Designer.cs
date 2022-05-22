namespace QuizifyIU
{
    partial class GestionarCurso
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
            this.panelGestionarCurso = new System.Windows.Forms.Panel();
            this.tablaDatoCurso = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxAl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bVolver = new FontAwesome.Sharp.IconButton();
            this.bAñadir = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.alumnoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelGestionarCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatoCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGestionarCurso
            // 
            this.panelGestionarCurso.Controls.Add(this.tablaDatoCurso);
            this.panelGestionarCurso.Controls.Add(this.bVolver);
            this.panelGestionarCurso.Controls.Add(this.bAñadir);
            this.panelGestionarCurso.Controls.Add(this.bEliminar);
            this.panelGestionarCurso.Controls.Add(this.alumnoBox);
            this.panelGestionarCurso.Controls.Add(this.label2);
            this.panelGestionarCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGestionarCurso.Location = new System.Drawing.Point(0, 0);
            this.panelGestionarCurso.Name = "panelGestionarCurso";
            this.panelGestionarCurso.Size = new System.Drawing.Size(730, 531);
            this.panelGestionarCurso.TabIndex = 0;
            // 
            // tablaDatoCurso
            // 
            this.tablaDatoCurso.AllowUserToAddRows = false;
            this.tablaDatoCurso.AllowUserToDeleteRows = false;
            this.tablaDatoCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaDatoCurso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDatoCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.tablaDatoCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDatoCurso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaDatoCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDatoCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDatoCurso.ColumnHeadersHeight = 26;
            this.tablaDatoCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaDatoCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.numAl,
            this.fechaCreado,
            this.MaxAl});
            this.tablaDatoCurso.EnableHeadersVisualStyles = false;
            this.tablaDatoCurso.GridColor = System.Drawing.Color.White;
            this.tablaDatoCurso.Location = new System.Drawing.Point(68, 103);
            this.tablaDatoCurso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaDatoCurso.Name = "tablaDatoCurso";
            this.tablaDatoCurso.ReadOnly = true;
            this.tablaDatoCurso.RowHeadersVisible = false;
            this.tablaDatoCurso.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaDatoCurso.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDatoCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatoCurso.Size = new System.Drawing.Size(658, 273);
            this.tablaDatoCurso.TabIndex = 20;
            this.tablaDatoCurso.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCurso_doble_click);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "cod";
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 79;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 85;
            // 
            // numAl
            // 
            this.numAl.DataPropertyName = "numAl";
            this.numAl.HeaderText = "Número alumnos";
            this.numAl.MinimumWidth = 8;
            this.numAl.Name = "numAl";
            this.numAl.ReadOnly = true;
            this.numAl.Width = 146;
            // 
            // fechaCreado
            // 
            this.fechaCreado.DataPropertyName = "fechaCreacion";
            this.fechaCreado.HeaderText = "Fecha creación";
            this.fechaCreado.MinimumWidth = 8;
            this.fechaCreado.Name = "fechaCreado";
            this.fechaCreado.ReadOnly = true;
            this.fechaCreado.Width = 133;
            // 
            // MaxAl
            // 
            this.MaxAl.DataPropertyName = "maxAl";
            this.MaxAl.HeaderText = "Nº Máximo Alumnos";
            this.MaxAl.MinimumWidth = 8;
            this.MaxAl.Name = "MaxAl";
            this.MaxAl.ReadOnly = true;
            this.MaxAl.Width = 166;
            // 
            // bVolver
            // 
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.bVolver.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.bVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVolver.IconSize = 30;
            this.bVolver.Location = new System.Drawing.Point(3, 13);
            this.bVolver.Name = "bVolver";
            this.bVolver.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bVolver.Size = new System.Drawing.Size(78, 38);
            this.bVolver.TabIndex = 19;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bAñadir
            // 
            this.bAñadir.Location = new System.Drawing.Point(369, 59);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(75, 23);
            this.bAñadir.TabIndex = 7;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(68, 392);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 6;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Visible = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // alumnoBox
            // 
            this.alumnoBox.Location = new System.Drawing.Point(191, 59);
            this.alumnoBox.Name = "alumnoBox";
            this.alumnoBox.Size = new System.Drawing.Size(157, 23);
            this.alumnoBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo del alumno:";
            // 
            // GestionarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(730, 531);
            this.Controls.Add(this.panelGestionarCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionarCurso";
            this.Text = "GestionarCurso";
            this.panelGestionarCurso.ResumeLayout(false);
            this.panelGestionarCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatoCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGestionarCurso;
        private System.Windows.Forms.TextBox alumnoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreado;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxAl;
        private FontAwesome.Sharp.IconButton bVolver;
        private System.Windows.Forms.DataGridView tablaDatoCurso;
    }
}