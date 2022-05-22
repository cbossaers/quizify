namespace QuizifyIU
{
    partial class CursoForm
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
            this.bCrearCurso = new System.Windows.Forms.Button();
            this.bGestionarCurso = new System.Windows.Forms.Button();
            this.panelCurso = new System.Windows.Forms.Panel();
            this.bVolver = new FontAwesome.Sharp.IconButton();
            this.bApuntarse = new System.Windows.Forms.Button();
            this.dataGridview1 = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.miscursos = new System.Windows.Forms.Label();
            this.panelCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // bCrearCurso
            // 
            this.bCrearCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bCrearCurso.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCrearCurso.Location = new System.Drawing.Point(241, 82);
            this.bCrearCurso.Name = "bCrearCurso";
            this.bCrearCurso.Size = new System.Drawing.Size(196, 53);
            this.bCrearCurso.TabIndex = 4;
            this.bCrearCurso.Text = "Crear curso";
            this.bCrearCurso.UseVisualStyleBackColor = true;
            this.bCrearCurso.Click += new System.EventHandler(this.bCrearCurso_Click);
            // 
            // bGestionarCurso
            // 
            this.bGestionarCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bGestionarCurso.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bGestionarCurso.Location = new System.Drawing.Point(241, 193);
            this.bGestionarCurso.Name = "bGestionarCurso";
            this.bGestionarCurso.Size = new System.Drawing.Size(196, 52);
            this.bGestionarCurso.TabIndex = 5;
            this.bGestionarCurso.Text = "Gestionar curso";
            this.bGestionarCurso.UseVisualStyleBackColor = true;
            this.bGestionarCurso.Click += new System.EventHandler(this.bGestionarCurso_Click);
            // 
            // panelCurso
            // 
            this.panelCurso.Controls.Add(this.miscursos);
            this.panelCurso.Controls.Add(this.bVolver);
            this.panelCurso.Controls.Add(this.bApuntarse);
            this.panelCurso.Controls.Add(this.bCrearCurso);
            this.panelCurso.Controls.Add(this.bGestionarCurso);
            this.panelCurso.Controls.Add(this.dataGridview1);
            this.panelCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCurso.Location = new System.Drawing.Point(0, 0);
            this.panelCurso.Name = "panelCurso";
            this.panelCurso.Size = new System.Drawing.Size(710, 490);
            this.panelCurso.TabIndex = 6;
            // 
            // bVolver
            // 
            this.bVolver.FlatAppearance.BorderSize = 0;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.bVolver.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.bVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bVolver.IconSize = 30;
            this.bVolver.Location = new System.Drawing.Point(12, 12);
            this.bVolver.Name = "bVolver";
            this.bVolver.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bVolver.Size = new System.Drawing.Size(78, 38);
            this.bVolver.TabIndex = 19;
            this.bVolver.UseVisualStyleBackColor = true;
            // 
            // bApuntarse
            // 
            this.bApuntarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bApuntarse.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bApuntarse.Location = new System.Drawing.Point(241, 299);
            this.bApuntarse.Name = "bApuntarse";
            this.bApuntarse.Size = new System.Drawing.Size(196, 51);
            this.bApuntarse.TabIndex = 6;
            this.bApuntarse.Text = "Apuntarse curso";
            this.bApuntarse.UseVisualStyleBackColor = true;
            this.bApuntarse.Click += new System.EventHandler(this.bApuntarse_Click);
            // 
            // dataGridview1
            // 
            this.dataGridview1.AllowUserToAddRows = false;
            this.dataGridview1.AllowUserToDeleteRows = false;
            this.dataGridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridview1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridview1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dataGridview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridview1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridview1.ColumnHeadersHeight = 26;
            this.dataGridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridview1.EnableHeadersVisualStyles = false;
            this.dataGridview1.GridColor = System.Drawing.Color.White;
            this.dataGridview1.Location = new System.Drawing.Point(280, 82);
            this.dataGridview1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridview1.MultiSelect = false;
            this.dataGridview1.Name = "dataGridview1";
            this.dataGridview1.ReadOnly = true;
            this.dataGridview1.RowHeadersVisible = false;
            this.dataGridview1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridview1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridview1.Size = new System.Drawing.Size(121, 202);
            this.dataGridview1.TabIndex = 11;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // miscursos
            // 
            this.miscursos.AutoSize = true;
            this.miscursos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miscursos.Location = new System.Drawing.Point(282, 20);
            this.miscursos.Name = "miscursos";
            this.miscursos.Size = new System.Drawing.Size(119, 30);
            this.miscursos.TabIndex = 33;
            this.miscursos.Text = "Mis Cursos:";
            // 
            // CursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(710, 490);
            this.Controls.Add(this.panelCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CursoForm";
            this.Text = "Curso";
            this.panelCurso.ResumeLayout(false);
            this.panelCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bCrearCurso;
        private System.Windows.Forms.Button bGestionarCurso;
        private System.Windows.Forms.Panel panelCurso;
        private System.Windows.Forms.Button bApuntarse;
        private FontAwesome.Sharp.IconButton bVolver;
        private System.Windows.Forms.DataGridView dataGridview1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label miscursos;
    }
}