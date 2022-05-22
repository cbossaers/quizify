
namespace QuizifyIU
{
    partial class CalificarPregunta
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
            this.tablaExamenesProfesor = new System.Windows.Forms.DataGridView();
            this.respuesta = new System.Windows.Forms.Label();
            this.nota = new System.Windows.Forms.Label();
            this.respuestabox = new System.Windows.Forms.TextBox();
            this.notabox = new System.Windows.Forms.TextBox();
            this.PonerNota = new System.Windows.Forms.Button();
            this.notaMax = new System.Windows.Forms.Label();
            this.button1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenesProfesor)).BeginInit();
            this.SuspendLayout();
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
            this.tablaExamenesProfesor.Location = new System.Drawing.Point(8, 52);
            this.tablaExamenesProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.tablaExamenesProfesor.Size = new System.Drawing.Size(687, 394);
            this.tablaExamenesProfesor.TabIndex = 10;
            this.tablaExamenesProfesor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EvPonerNota);
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Location = new System.Drawing.Point(30, 80);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(60, 15);
            this.respuesta.TabIndex = 12;
            this.respuesta.Text = "Respuesta";
            this.respuesta.Visible = false;
            // 
            // nota
            // 
            this.nota.AutoSize = true;
            this.nota.Location = new System.Drawing.Point(62, 229);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(31, 15);
            this.nota.TabIndex = 13;
            this.nota.Text = "nota";
            this.nota.Visible = false;
            // 
            // respuestabox
            // 
            this.respuestabox.Location = new System.Drawing.Point(135, 70);
            this.respuestabox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.respuestabox.Multiline = true;
            this.respuestabox.Name = "respuestabox";
            this.respuestabox.Size = new System.Drawing.Size(524, 126);
            this.respuestabox.TabIndex = 14;
            this.respuestabox.Visible = false;
            // 
            // notabox
            // 
            this.notabox.Location = new System.Drawing.Point(127, 226);
            this.notabox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notabox.Name = "notabox";
            this.notabox.Size = new System.Drawing.Size(65, 23);
            this.notabox.TabIndex = 15;
            this.notabox.Visible = false;
            // 
            // PonerNota
            // 
            this.PonerNota.Location = new System.Drawing.Point(557, 222);
            this.PonerNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PonerNota.Name = "PonerNota";
            this.PonerNota.Size = new System.Drawing.Size(82, 22);
            this.PonerNota.TabIndex = 16;
            this.PonerNota.Text = "Poner Nota";
            this.PonerNota.UseVisualStyleBackColor = true;
            this.PonerNota.Visible = false;
            this.PonerNota.Click += new System.EventHandler(this.EvPonerNota);
            // 
            // notaMax
            // 
            this.notaMax.AutoSize = true;
            this.notaMax.Location = new System.Drawing.Point(215, 229);
            this.notaMax.Name = "notaMax";
            this.notaMax.Size = new System.Drawing.Size(0, 15);
            this.notaMax.TabIndex = 17;
            this.notaMax.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.button1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.button1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button1.IconSize = 30;
            this.button1.Location = new System.Drawing.Point(2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 38);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EvAtras);
            // 
            // CalificarPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(703, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notaMax);
            this.Controls.Add(this.PonerNota);
            this.Controls.Add(this.notabox);
            this.Controls.Add(this.respuestabox);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.tablaExamenesProfesor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CalificarPregunta";
            this.Text = "CalificarPregunta";
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenesProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaExamenesProfesor;
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.Label nota;
        private System.Windows.Forms.TextBox respuestabox;
        private System.Windows.Forms.TextBox notabox;
        private System.Windows.Forms.Button PonerNota;
        private System.Windows.Forms.Label notaMax;
        private FontAwesome.Sharp.IconButton button1;
    }
}