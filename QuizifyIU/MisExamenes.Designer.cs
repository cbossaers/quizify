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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.calificar = new System.Windows.Forms.Button();
            this.tablaExamenesProfesor = new System.Windows.Forms.DataGridView();
            this.tablaExamenDisponible = new System.Windows.Forms.DataGridView();
            this.tablaExamenFinalizado = new System.Windows.Forms.DataGridView();
            this.dificultadBox = new System.Windows.Forms.ComboBox();
            this.puntuar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.finalizar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenesProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenFinalizado)).BeginInit();
            this.SuspendLayout();
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
            this.label3.Location = new System.Drawing.Point(9, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quiz finalizados:";
            // 
            // calificar
            // 
            this.calificar.Location = new System.Drawing.Point(473, 14);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaExamenesProfesor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tablaExamenesProfesor.ColumnHeadersHeight = 26;
            this.tablaExamenesProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaExamenesProfesor.EnableHeadersVisualStyles = false;
            this.tablaExamenesProfesor.GridColor = System.Drawing.Color.White;
            this.tablaExamenesProfesor.Location = new System.Drawing.Point(10, 48);
            this.tablaExamenesProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaExamenesProfesor.Name = "tablaExamenesProfesor";
            this.tablaExamenesProfesor.ReadOnly = true;
            this.tablaExamenesProfesor.RowHeadersVisible = false;
            this.tablaExamenesProfesor.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.tablaExamenesProfesor.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tablaExamenesProfesor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaExamenesProfesor.Size = new System.Drawing.Size(687, 460);
            this.tablaExamenesProfesor.TabIndex = 9;
            this.tablaExamenesProfesor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaExamenesProfesor_CellMouseDoubleClick);
            // 
            // tablaExamenDisponible
            // 
            this.tablaExamenDisponible.AllowUserToAddRows = false;
            this.tablaExamenDisponible.AllowUserToDeleteRows = false;
            this.tablaExamenDisponible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaExamenDisponible.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaExamenDisponible.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.tablaExamenDisponible.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaExamenDisponible.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaExamenDisponible.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaExamenDisponible.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tablaExamenDisponible.ColumnHeadersHeight = 26;
            this.tablaExamenDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaExamenDisponible.EnableHeadersVisualStyles = false;
            this.tablaExamenDisponible.GridColor = System.Drawing.Color.White;
            this.tablaExamenDisponible.Location = new System.Drawing.Point(10, 71);
            this.tablaExamenDisponible.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaExamenDisponible.Name = "tablaExamenDisponible";
            this.tablaExamenDisponible.ReadOnly = true;
            this.tablaExamenDisponible.RowHeadersVisible = false;
            this.tablaExamenDisponible.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.tablaExamenDisponible.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tablaExamenDisponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaExamenDisponible.Size = new System.Drawing.Size(707, 185);
            this.tablaExamenDisponible.TabIndex = 10;
            this.tablaExamenDisponible.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaExamenDisponible_CellMouseDoubleClick);
            // 
            // tablaExamenFinalizado
            // 
            this.tablaExamenFinalizado.AllowUserToAddRows = false;
            this.tablaExamenFinalizado.AllowUserToDeleteRows = false;
            this.tablaExamenFinalizado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaExamenFinalizado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaExamenFinalizado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.tablaExamenFinalizado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaExamenFinalizado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaExamenFinalizado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaExamenFinalizado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tablaExamenFinalizado.ColumnHeadersHeight = 26;
            this.tablaExamenFinalizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaExamenFinalizado.EnableHeadersVisualStyles = false;
            this.tablaExamenFinalizado.GridColor = System.Drawing.Color.White;
            this.tablaExamenFinalizado.Location = new System.Drawing.Point(13, 294);
            this.tablaExamenFinalizado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaExamenFinalizado.Name = "tablaExamenFinalizado";
            this.tablaExamenFinalizado.ReadOnly = true;
            this.tablaExamenFinalizado.RowHeadersVisible = false;
            this.tablaExamenFinalizado.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.tablaExamenFinalizado.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tablaExamenFinalizado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaExamenFinalizado.Size = new System.Drawing.Size(684, 199);
            this.tablaExamenFinalizado.TabIndex = 11;
            // 
            // dificultadBox
            // 
            this.dificultadBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dificultadBox.FormattingEnabled = true;
            this.dificultadBox.Items.AddRange(new object[] {
            "Fácil",
            "Normal",
            "Difícil",
            "Todos"});
            this.dificultadBox.Location = new System.Drawing.Point(170, 14);
            this.dificultadBox.Name = "dificultadBox";
            this.dificultadBox.Size = new System.Drawing.Size(121, 23);
            this.dificultadBox.TabIndex = 12;
            this.dificultadBox.SelectedIndexChanged += new System.EventHandler(this.dificultadBox_SelectedIndexChanged);
            // 
            // puntuar
            // 
            this.puntuar.Location = new System.Drawing.Point(392, 14);
            this.puntuar.Name = "puntuar";
            this.puntuar.Size = new System.Drawing.Size(75, 23);
            this.puntuar.TabIndex = 13;
            this.puntuar.Text = "Puntuar";
            this.puntuar.UseVisualStyleBackColor = true;
            this.puntuar.Click += new System.EventHandler(this.EvPonerNota);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Filtrar por dificultad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Estadisticas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalizar
            // 
            this.finalizar.Location = new System.Drawing.Point(554, 14);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(75, 23);
            this.finalizar.TabIndex = 16;
            this.finalizar.Text = "Finalizar";
            this.finalizar.UseVisualStyleBackColor = true;
            this.finalizar.Visible = false;
            this.finalizar.Click += new System.EventHandler(this.EvFinalizar);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(635, 14);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 17;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.EvCancelar);
            // 
            // MisExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(730, 531);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.puntuar);
            this.Controls.Add(this.dificultadBox);
            this.Controls.Add(this.calificar);
            this.Controls.Add(this.tablaExamenFinalizado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaExamenDisponible);
            this.Controls.Add(this.tablaExamenesProfesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisExamenes";
            this.Text = "MisExamenes";
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenesProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenFinalizado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calificar;
        private System.Windows.Forms.DataGridView tablaExamenesProfesor;
        private System.Windows.Forms.DataGridView tablaExamenDisponible;
        private System.Windows.Forms.DataGridView tablaExamenFinalizado;
        private System.Windows.Forms.ComboBox dificultadBox;
        private System.Windows.Forms.Button puntuar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button finalizar;
        private System.Windows.Forms.Button cancelar;
    }
}