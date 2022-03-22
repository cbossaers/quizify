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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ini2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_fin2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenDisponible)).BeginInit();
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
            this.ID,
            this.titulo2,
            this.descripcion2,
            this.curso2,
            this.tiempo2,
            this.fecha_ini2,
            this.fecha_fin2});
            this.tablaExamenDisponible.Location = new System.Drawing.Point(12, 71);
            this.tablaExamenDisponible.MultiSelect = false;
            this.tablaExamenDisponible.Name = "tablaExamenDisponible";
            this.tablaExamenDisponible.ReadOnly = true;
            this.tablaExamenDisponible.RowHeadersVisible = false;
            this.tablaExamenDisponible.RowTemplate.Height = 25;
            this.tablaExamenDisponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaExamenDisponible.Size = new System.Drawing.Size(631, 351);
            this.tablaExamenDisponible.TabIndex = 0;
            this.tablaExamenDisponible.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaExamenDisponible_CellContentClick);
            this.tablaExamenDisponible.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaExamenDisponible_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // titulo2
            // 
            this.titulo2.DataPropertyName = "titulo";
            this.titulo2.HeaderText = "Título";
            this.titulo2.Name = "titulo2";
            this.titulo2.ReadOnly = true;
            // 
            // descripcion2
            // 
            this.descripcion2.DataPropertyName = "descripcion";
            this.descripcion2.HeaderText = "Descripción";
            this.descripcion2.Name = "descripcion2";
            this.descripcion2.ReadOnly = true;
            // 
            // curso2
            // 
            this.curso2.DataPropertyName = "curso";
            this.curso2.HeaderText = "Curso";
            this.curso2.Name = "curso2";
            this.curso2.ReadOnly = true;
            // 
            // tiempo2
            // 
            this.tiempo2.DataPropertyName = "tiempo";
            this.tiempo2.HeaderText = "Tiempo";
            this.tiempo2.Name = "tiempo2";
            this.tiempo2.ReadOnly = true;
            // 
            // fecha_ini2
            // 
            this.fecha_ini2.DataPropertyName = "fecha_ini";
            this.fecha_ini2.HeaderText = "Fecha Ini";
            this.fecha_ini2.Name = "fecha_ini2";
            this.fecha_ini2.ReadOnly = true;
            // 
            // fecha_fin2
            // 
            this.fecha_fin2.DataPropertyName = "fecha_fin";
            this.fecha_fin2.HeaderText = "Fecha Fin";
            this.fecha_fin2.Name = "fecha_fin2";
            this.fecha_fin2.ReadOnly = true;
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
            // MisExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaExamenDisponible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisExamenes";
            this.Text = "MisExamenes";
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenDisponible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaExamenDisponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ini2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_fin2;
    }
}