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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.calificar = new System.Windows.Forms.Button();
            this.tablaExamenesProfesor = new System.Windows.Forms.DataGridView();
            this.tablaExamenDisponible = new System.Windows.Forms.DataGridView();
            this.tablaExamenFinalizado = new System.Windows.Forms.DataGridView();
            this.tunometecabra = new System.Windows.Forms.ComboBox();
            this.puntuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenesProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenFinalizado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mis Quiz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
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
            this.label3.Location = new System.Drawing.Point(10, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quiz finalizados:";
            // 
            // calificar
            // 
            this.calificar.Location = new System.Drawing.Point(592, 21);
            this.calificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calificar.Name = "calificar";
            this.calificar.Size = new System.Drawing.Size(86, 31);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaExamenesProfesor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaExamenesProfesor.ColumnHeadersHeight = 26;
            this.tablaExamenesProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaExamenesProfesor.EnableHeadersVisualStyles = false;
            this.tablaExamenesProfesor.GridColor = System.Drawing.Color.White;
            this.tablaExamenesProfesor.Location = new System.Drawing.Point(11, 64);
            this.tablaExamenesProfesor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tablaExamenesProfesor.Name = "tablaExamenesProfesor";
            this.tablaExamenesProfesor.ReadOnly = true;
            this.tablaExamenesProfesor.RowHeadersVisible = false;
            this.tablaExamenesProfesor.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaExamenesProfesor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaExamenesProfesor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaExamenesProfesor.Size = new System.Drawing.Size(785, 613);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaExamenDisponible.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaExamenDisponible.ColumnHeadersHeight = 26;
            this.tablaExamenDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaExamenDisponible.EnableHeadersVisualStyles = false;
            this.tablaExamenDisponible.GridColor = System.Drawing.Color.White;
            this.tablaExamenDisponible.Location = new System.Drawing.Point(11, 95);
            this.tablaExamenDisponible.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tablaExamenDisponible.Name = "tablaExamenDisponible";
            this.tablaExamenDisponible.ReadOnly = true;
            this.tablaExamenDisponible.RowHeadersVisible = false;
            this.tablaExamenDisponible.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.tablaExamenDisponible.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaExamenDisponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaExamenDisponible.Size = new System.Drawing.Size(808, 247);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaExamenFinalizado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaExamenFinalizado.ColumnHeadersHeight = 26;
            this.tablaExamenFinalizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaExamenFinalizado.EnableHeadersVisualStyles = false;
            this.tablaExamenFinalizado.GridColor = System.Drawing.Color.White;
            this.tablaExamenFinalizado.Location = new System.Drawing.Point(15, 392);
            this.tablaExamenFinalizado.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tablaExamenFinalizado.Name = "tablaExamenFinalizado";
            this.tablaExamenFinalizado.ReadOnly = true;
            this.tablaExamenFinalizado.RowHeadersVisible = false;
            this.tablaExamenFinalizado.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.tablaExamenFinalizado.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaExamenFinalizado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaExamenFinalizado.Size = new System.Drawing.Size(782, 265);
            this.tablaExamenFinalizado.TabIndex = 11;
            // 
            // tunometecabra
            // 
            this.tunometecabra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tunometecabra.FormattingEnabled = true;
            this.tunometecabra.Items.AddRange(new object[] {
            "Fácil",
            "Normal",
            "Difícil"});
            this.tunometecabra.Location = new System.Drawing.Point(190, 16);
            this.tunometecabra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tunometecabra.Name = "tunometecabra";
            this.tunometecabra.Size = new System.Drawing.Size(138, 28);
            this.tunometecabra.TabIndex = 12;
            this.tunometecabra.SelectedIndexChanged += new System.EventHandler(this.tunometecabra_SelectedIndexChanged);
            // 
            // puntuar
            // 
            this.puntuar.Location = new System.Drawing.Point(701, 21);
            this.puntuar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.puntuar.Name = "puntuar";
            this.puntuar.Size = new System.Drawing.Size(86, 31);
            this.puntuar.TabIndex = 13;
            this.puntuar.Text = "Puntuar";
            this.puntuar.UseVisualStyleBackColor = true;
            this.puntuar.Click += new System.EventHandler(this.EvPonerNota);
            // 
            // MisExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(834, 708);
            this.Controls.Add(this.puntuar);
            this.Controls.Add(this.tunometecabra);
            this.Controls.Add(this.calificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaExamenFinalizado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaExamenDisponible);
            this.Controls.Add(this.tablaExamenesProfesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MisExamenes";
            this.Text = "MisExamenes";
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenesProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenFinalizado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calificar;
        private System.Windows.Forms.DataGridView tablaExamenesProfesor;
        private System.Windows.Forms.DataGridView tablaExamenDisponible;
        private System.Windows.Forms.DataGridView tablaExamenFinalizado;
        private System.Windows.Forms.ComboBox tunometecabra;
        private System.Windows.Forms.Button puntuar;
    }
}