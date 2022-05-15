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
            this.panelGestionarCurso = new System.Windows.Forms.Panel();
            this.tablaDatoCurso = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxAl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAñadir = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.alumnoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.panelGestionarCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatoCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGestionarCurso
            // 
            this.panelGestionarCurso.Controls.Add(this.tablaDatoCurso);
            this.panelGestionarCurso.Controls.Add(this.bAñadir);
            this.panelGestionarCurso.Controls.Add(this.bEliminar);
            this.panelGestionarCurso.Controls.Add(this.alumnoBox);
            this.panelGestionarCurso.Controls.Add(this.label2);
            this.panelGestionarCurso.Controls.Add(this.bVolver);
            this.panelGestionarCurso.Location = new System.Drawing.Point(-2, -1);
            this.panelGestionarCurso.Name = "panelGestionarCurso";
            this.panelGestionarCurso.Size = new System.Drawing.Size(657, 452);
            this.panelGestionarCurso.TabIndex = 0;
            // 
            // tablaDatoCurso
            // 
            this.tablaDatoCurso.AllowUserToAddRows = false;
            this.tablaDatoCurso.AllowUserToResizeColumns = false;
            this.tablaDatoCurso.AllowUserToResizeRows = false;
            this.tablaDatoCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatoCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.numAl,
            this.fechaCreado,
            this.MaxAl});
            this.tablaDatoCurso.Location = new System.Drawing.Point(40, 65);
            this.tablaDatoCurso.MultiSelect = false;
            this.tablaDatoCurso.Name = "tablaDatoCurso";
            this.tablaDatoCurso.RowHeadersVisible = false;
            this.tablaDatoCurso.RowHeadersWidth = 62;
            this.tablaDatoCurso.RowTemplate.Height = 25;
            this.tablaDatoCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDatoCurso.Size = new System.Drawing.Size(605, 273);
            this.tablaDatoCurso.TabIndex = 9;
            this.tablaDatoCurso.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCurso_doble_click);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "cod";
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            this.codigo.Width = 150;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // numAl
            // 
            this.numAl.DataPropertyName = "numAl";
            this.numAl.HeaderText = "Número alumnos";
            this.numAl.MinimumWidth = 8;
            this.numAl.Name = "numAl";
            this.numAl.Width = 150;
            // 
            // fechaCreado
            // 
            this.fechaCreado.DataPropertyName = "fechaCreacion";
            this.fechaCreado.HeaderText = "Fecha creación";
            this.fechaCreado.MinimumWidth = 8;
            this.fechaCreado.Name = "fechaCreado";
            this.fechaCreado.Width = 150;
            // 
            // MaxAl
            // 
            this.MaxAl.DataPropertyName = "maxAl";
            this.MaxAl.HeaderText = "Nº Máximo Alumnos";
            this.MaxAl.MinimumWidth = 8;
            this.MaxAl.Name = "MaxAl";
            this.MaxAl.Width = 150;
            // 
            // bAñadir
            // 
            this.bAñadir.Location = new System.Drawing.Point(341, 21);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(75, 23);
            this.bAñadir.TabIndex = 7;
            this.bAñadir.Text = "Añadir";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(245, 368);
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
            this.alumnoBox.Location = new System.Drawing.Point(163, 21);
            this.alumnoBox.Name = "alumnoBox";
            this.alumnoBox.Size = new System.Drawing.Size(157, 23);
            this.alumnoBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo del alumno:";
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(40, 368);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(75, 23);
            this.bVolver.TabIndex = 1;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // GestionarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(655, 450);
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
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.TextBox alumnoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bAñadir;
        private System.Windows.Forms.DataGridView tablaDatoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreado;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxAl;
    }
}