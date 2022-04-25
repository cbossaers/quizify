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
            this.bBuscar = new System.Windows.Forms.Button();
            this.tipo_txt = new System.Windows.Forms.ComboBox();
            this.dificultad_txt = new System.Windows.Forms.ComboBox();
            this.tema_txt = new System.Windows.Forms.TextBox();
            this.tablaPreguntas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enunciado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mis Preguntas";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(656, 93);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 7;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click_1);
            // 
            // tipo_txt
            // 
            this.tipo_txt.FormattingEnabled = true;
            this.tipo_txt.Items.AddRange(new object[] {
            "Test",
            "VF",
            "Desarrollo"});
            this.tipo_txt.Location = new System.Drawing.Point(98, 94);
            this.tipo_txt.Name = "tipo_txt";
            this.tipo_txt.Size = new System.Drawing.Size(121, 23);
            this.tipo_txt.TabIndex = 8;
            // 
            // dificultad_txt
            // 
            this.dificultad_txt.FormattingEnabled = true;
            this.dificultad_txt.Items.AddRange(new object[] {
            "Fácil",
            "Medio",
            "Difícil"});
            this.dificultad_txt.Location = new System.Drawing.Point(318, 93);
            this.dificultad_txt.Name = "dificultad_txt";
            this.dificultad_txt.Size = new System.Drawing.Size(121, 23);
            this.dificultad_txt.TabIndex = 9;
            // 
            // tema_txt
            // 
            this.tema_txt.Location = new System.Drawing.Point(507, 93);
            this.tema_txt.Name = "tema_txt";
            this.tema_txt.Size = new System.Drawing.Size(100, 23);
            this.tema_txt.TabIndex = 10;
            // 
            // tablaPreguntas
            // 
            this.tablaPreguntas.AllowUserToAddRows = false;
            this.tablaPreguntas.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.tablaPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.enunciado,
            this.dataGridViewTextBoxColumn1,
            this.Version,
            this.dataGridViewTextBoxColumn2,
            this.Materia,
            this.Autor});
            this.tablaPreguntas.GridColor = System.Drawing.SystemColors.MenuBar;
            this.tablaPreguntas.Location = new System.Drawing.Point(-1, 145);
            this.tablaPreguntas.MultiSelect = false;
            this.tablaPreguntas.Name = "tablaPreguntas";
            this.tablaPreguntas.ReadOnly = true;
            this.tablaPreguntas.RowTemplate.Height = 25;
            this.tablaPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPreguntas.Size = new System.Drawing.Size(798, 243);
            this.tablaPreguntas.TabIndex = 11;
            this.tablaPreguntas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPreguntas_CellContentDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ds_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // enunciado
            // 
            this.enunciado.DataPropertyName = "ds_enunciado";
            this.enunciado.HeaderText = "Enunciado";
            this.enunciado.Name = "enunciado";
            this.enunciado.ReadOnly = true;
            this.enunciado.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ds_tipo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Version
            // 
            this.Version.DataPropertyName = "ds_version";
            this.Version.HeaderText = "Versión";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ds_dificultad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dificultad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "ds_materia";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "ds_autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(250, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dificultad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(462, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tema";
            // 
            // MisPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaPreguntas);
            this.Controls.Add(this.tema_txt);
            this.Controls.Add(this.dificultad_txt);
            this.Controls.Add(this.tipo_txt);
            this.Controls.Add(this.bBuscar);
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
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.ComboBox tipo_txt;
        private System.Windows.Forms.ComboBox dificultad_txt;
        private System.Windows.Forms.TextBox tema_txt;
        private System.Windows.Forms.DataGridView tablaPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn enunciado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}