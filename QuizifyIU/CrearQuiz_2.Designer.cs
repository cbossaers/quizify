namespace QuizifyIU
{
    partial class CrearQuiz_2
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
            this.crear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dificultad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.editar = new System.Windows.Forms.Button();
            this.anular = new System.Windows.Forms.Button();
            this.bVolver = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(645, 415);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(123, 23);
            this.crear.TabIndex = 11;
            this.crear.Text = "Confirmar y Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Pregunta,
            this.Dificultad,
            this.Tipo,
            this.Autor,
            this.Materia,
            this.Puntuacion});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(702, 334);
            this.dataGridView1.TabIndex = 10;
            // 
            // id
            // 
            this.id.DataPropertyName = "ds_ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Pregunta
            // 
            this.Pregunta.DataPropertyName = "ds_enunciado";
            this.Pregunta.HeaderText = "Enunciado";
            this.Pregunta.Name = "Pregunta";
            // 
            // Dificultad
            // 
            this.Dificultad.DataPropertyName = "ds_dificultad";
            this.Dificultad.HeaderText = "Dificultad";
            this.Dificultad.Name = "Dificultad";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "ds_tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "ds_autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "ds_materia";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            // 
            // Puntuacion
            // 
            this.Puntuacion.DataPropertyName = "ds_puntuacion";
            this.Puntuacion.HeaderText = "Puntuación";
            this.Puntuacion.Name = "Puntuacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Añadir pregunta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre del quiz";
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(720, 361);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 42);
            this.editar.TabIndex = 13;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Visible = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // anular
            // 
            this.anular.Location = new System.Drawing.Point(720, 200);
            this.anular.Name = "anular";
            this.anular.Size = new System.Drawing.Size(75, 46);
            this.anular.TabIndex = 14;
            this.anular.Text = "Anular";
            this.anular.UseVisualStyleBackColor = true;
            this.anular.Click += new System.EventHandler(this.anular_Click);
            // 
            // bVolver
            // 
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.bVolver.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.bVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVolver.IconSize = 30;
            this.bVolver.Location = new System.Drawing.Point(1, 3);
            this.bVolver.Name = "bVolver";
            this.bVolver.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bVolver.Size = new System.Drawing.Size(78, 38);
            this.bVolver.TabIndex = 18;
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.button3_Click);
            // 
            // CrearQuiz_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(813, 451);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.anular);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "CrearQuiz_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dificultad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntuacion;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button anular;
        private FontAwesome.Sharp.IconButton bVolver;
    }
}