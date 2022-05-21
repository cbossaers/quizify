
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
            this.button1 = new System.Windows.Forms.Button();
            this.respuesta = new System.Windows.Forms.Label();
            this.nota = new System.Windows.Forms.Label();
            this.respuestabox = new System.Windows.Forms.TextBox();
            this.notabox = new System.Windows.Forms.TextBox();
            this.PonerNota = new System.Windows.Forms.Button();
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
            this.tablaExamenesProfesor.Location = new System.Drawing.Point(9, 70);
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
            this.tablaExamenesProfesor.Size = new System.Drawing.Size(785, 526);
            this.tablaExamenesProfesor.TabIndex = 10;
            this.tablaExamenesProfesor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EvPonerNota);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EvAtras);
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Location = new System.Drawing.Point(34, 107);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(76, 20);
            this.respuesta.TabIndex = 12;
            this.respuesta.Text = "Respuesta";
            this.respuesta.Visible = false;
            // 
            // nota
            // 
            this.nota.AutoSize = true;
            this.nota.Location = new System.Drawing.Point(71, 305);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(39, 20);
            this.nota.TabIndex = 13;
            this.nota.Text = "nota";
            this.nota.Visible = false;
            // 
            // respuestabox
            // 
            this.respuestabox.Location = new System.Drawing.Point(154, 93);
            this.respuestabox.Multiline = true;
            this.respuestabox.Name = "respuestabox";
            this.respuestabox.Size = new System.Drawing.Size(598, 167);
            this.respuestabox.TabIndex = 14;
            this.respuestabox.Visible = false;
            // 
            // notabox
            // 
            this.notabox.Location = new System.Drawing.Point(145, 302);
            this.notabox.Name = "notabox";
            this.notabox.Size = new System.Drawing.Size(125, 27);
            this.notabox.TabIndex = 15;
            this.notabox.Visible = false;
            // 
            // PonerNota
            // 
            this.PonerNota.Location = new System.Drawing.Point(637, 296);
            this.PonerNota.Name = "PonerNota";
            this.PonerNota.Size = new System.Drawing.Size(94, 29);
            this.PonerNota.TabIndex = 16;
            this.PonerNota.Text = "Poner Nota";
            this.PonerNota.UseVisualStyleBackColor = true;
            this.PonerNota.Visible = false;
            this.PonerNota.Click += new System.EventHandler(this.EvPonerNota);
            // 
            // CalificarPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 609);
            this.Controls.Add(this.PonerNota);
            this.Controls.Add(this.notabox);
            this.Controls.Add(this.respuestabox);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tablaExamenesProfesor);
            this.Name = "CalificarPregunta";
            this.Text = "CalificarPregunta";
            ((System.ComponentModel.ISupportInitialize)(this.tablaExamenesProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaExamenesProfesor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.Label nota;
        private System.Windows.Forms.TextBox respuestabox;
        private System.Windows.Forms.TextBox notabox;
        private System.Windows.Forms.Button PonerNota;
    }
}