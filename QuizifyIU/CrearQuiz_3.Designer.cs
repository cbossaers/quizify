namespace QuizifyIU
{
    partial class CrearQuiz_3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enunciado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dificultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tema_txt = new System.Windows.Forms.TextBox();
            this.dificultad_txt = new System.Windows.Forms.ComboBox();
            this.tipo_txt = new System.Windows.Forms.ComboBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bVolver = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.enunciado,
            this.Tipo,
            this.Version,
            this.Dificultad,
            this.Materia,
            this.Autor});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.Location = new System.Drawing.Point(3, 107);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(797, 289);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
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
            // Tipo
            // 
            this.Tipo.DataPropertyName = "ds_tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Version
            // 
            this.Version.DataPropertyName = "ds_version";
            this.Version.HeaderText = "Versión";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            // 
            // Dificultad
            // 
            this.Dificultad.DataPropertyName = "ds_dificultad";
            this.Dificultad.HeaderText = "Dificultad";
            this.Dificultad.Name = "Dificultad";
            this.Dificultad.ReadOnly = true;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Agregar pregunta seleccionada";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(400, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tema";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(186, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dificultad";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo";
            this.label3.Visible = false;
            // 
            // tema_txt
            // 
            this.tema_txt.Location = new System.Drawing.Point(451, 64);
            this.tema_txt.Name = "tema_txt";
            this.tema_txt.Size = new System.Drawing.Size(100, 23);
            this.tema_txt.TabIndex = 18;
            this.tema_txt.Visible = false;
            // 
            // dificultad_txt
            // 
            this.dificultad_txt.FormattingEnabled = true;
            this.dificultad_txt.Items.AddRange(new object[] {
            "Fácil",
            "Medio",
            "Difícil"});
            this.dificultad_txt.Location = new System.Drawing.Point(257, 64);
            this.dificultad_txt.Name = "dificultad_txt";
            this.dificultad_txt.Size = new System.Drawing.Size(121, 23);
            this.dificultad_txt.TabIndex = 17;
            this.dificultad_txt.Visible = false;
            // 
            // tipo_txt
            // 
            this.tipo_txt.FormattingEnabled = true;
            this.tipo_txt.Items.AddRange(new object[] {
            "Test",
            "VF"});
            this.tipo_txt.Location = new System.Drawing.Point(48, 65);
            this.tipo_txt.Name = "tipo_txt";
            this.tipo_txt.Size = new System.Drawing.Size(121, 23);
            this.tipo_txt.TabIndex = 16;
            this.tipo_txt.Visible = false;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(451, 24);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 15;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Visible = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bVolver
            // 
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.bVolver.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.bVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVolver.IconSize = 30;
            this.bVolver.Location = new System.Drawing.Point(2, 2);
            this.bVolver.Name = "bVolver";
            this.bVolver.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bVolver.Size = new System.Drawing.Size(78, 38);
            this.bVolver.TabIndex = 23;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // CrearQuiz_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tema_txt);
            this.Controls.Add(this.dificultad_txt);
            this.Controls.Add(this.tipo_txt);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CrearQuiz_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn enunciado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dificultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tema_txt;
        private System.Windows.Forms.ComboBox dificultad_txt;
        private System.Windows.Forms.ComboBox tipo_txt;
        private System.Windows.Forms.Button bBuscar;
        private FontAwesome.Sharp.IconButton bVolver;
    }
}