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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.tipo_txt = new System.Windows.Forms.ComboBox();
            this.dificultad_txt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tablaPreguntas = new System.Windows.Forms.DataGridView();
            this.tema_txt = new System.Windows.Forms.ComboBox();
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
            this.bBuscar.Location = new System.Drawing.Point(576, 92);
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
            "Mult",
            "Des"});
            this.tipo_txt.Location = new System.Drawing.Point(65, 95);
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
            this.dificultad_txt.Location = new System.Drawing.Point(260, 95);
            this.dificultad_txt.Name = "dificultad_txt";
            this.dificultad_txt.Size = new System.Drawing.Size(121, 23);
            this.dificultad_txt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(192, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dificultad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(389, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Curso";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // tablaPreguntas
            // 
            this.tablaPreguntas.AllowUserToAddRows = false;
            this.tablaPreguntas.AllowUserToDeleteRows = false;
            this.tablaPreguntas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaPreguntas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaPreguntas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.tablaPreguntas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaPreguntas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaPreguntas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaPreguntas.ColumnHeadersHeight = 26;
            this.tablaPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaPreguntas.EnableHeadersVisualStyles = false;
            this.tablaPreguntas.GridColor = System.Drawing.Color.White;
            this.tablaPreguntas.Location = new System.Drawing.Point(6, 139);
            this.tablaPreguntas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablaPreguntas.Name = "tablaPreguntas";
            this.tablaPreguntas.ReadOnly = true;
            this.tablaPreguntas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaPreguntas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPreguntas.Size = new System.Drawing.Size(711, 380);
            this.tablaPreguntas.TabIndex = 15;
            this.tablaPreguntas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaPreguntas_CellMouseDoubleClick);
            // 
            // tema_txt
            // 
            this.tema_txt.FormattingEnabled = true;
            this.tema_txt.Location = new System.Drawing.Point(434, 93);
            this.tema_txt.Name = "tema_txt";
            this.tema_txt.Size = new System.Drawing.Size(121, 23);
            this.tema_txt.TabIndex = 16;
            // 
            // MisPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(730, 531);
            this.Controls.Add(this.tema_txt);
            this.Controls.Add(this.tablaPreguntas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dificultad_txt);
            this.Controls.Add(this.tipo_txt);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MisPreguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridView tablaPreguntas;
        private System.Windows.Forms.ComboBox tema_txt;
    }
}