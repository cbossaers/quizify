namespace QuizifyIU
{
    partial class HacerExamen2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.correctaVF = new System.Windows.Forms.Panel();
            this.falso1 = new System.Windows.Forms.RadioButton();
            this.verdadero0 = new System.Windows.Forms.RadioButton();
            this.letraE = new System.Windows.Forms.Label();
            this.letraD = new System.Windows.Forms.Label();
            this.letraC = new System.Windows.Forms.Label();
            this.letraB = new System.Windows.Forms.Label();
            this.letraA = new System.Windows.Forms.Label();
            this.enunciado = new System.Windows.Forms.Label();
            this.opc0 = new System.Windows.Forms.Label();
            this.opc1 = new System.Windows.Forms.Label();
            this.opc2 = new System.Windows.Forms.Label();
            this.opc3 = new System.Windows.Forms.Label();
            this.opc4 = new System.Windows.Forms.Label();
            this.correcta0 = new System.Windows.Forms.RadioButton();
            this.correcta1 = new System.Windows.Forms.RadioButton();
            this.correcta2 = new System.Windows.Forms.RadioButton();
            this.correcta3 = new System.Windows.Forms.RadioButton();
            this.correcta4 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new QuizifyIU.Controles_extra.Botones_fancy();
            this.button1 = new QuizifyIU.Controles_extra.Botones_fancy();
            this.siguiente = new QuizifyIU.Controles_extra.Botones_fancy();
            this.anterior = new QuizifyIU.Controles_extra.Botones_fancy();
            this.CorrectaMult = new System.Windows.Forms.Panel();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check0 = new System.Windows.Forms.CheckBox();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.RespuestaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fondo = new System.Windows.Forms.PictureBox();
            this.borrar_seleccion = new QuizifyIU.Controles_extra.Botones_fancy();
            this.correctaVF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.CorrectaMult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // correctaVF
            // 
            this.correctaVF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.correctaVF.Controls.Add(this.falso1);
            this.correctaVF.Controls.Add(this.verdadero0);
            this.correctaVF.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctaVF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.correctaVF.Location = new System.Drawing.Point(1, 27);
            this.correctaVF.Name = "correctaVF";
            this.correctaVF.Size = new System.Drawing.Size(165, 140);
            this.correctaVF.TabIndex = 49;
            this.correctaVF.Visible = false;
            // 
            // falso1
            // 
            this.falso1.AutoSize = true;
            this.falso1.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.falso1.Location = new System.Drawing.Point(14, 78);
            this.falso1.Name = "falso1";
            this.falso1.Size = new System.Drawing.Size(60, 20);
            this.falso1.TabIndex = 1;
            this.falso1.TabStop = true;
            this.falso1.Text = " Falso";
            this.falso1.UseVisualStyleBackColor = true;
            this.falso1.CheckedChanged += new System.EventHandler(this.correct);
            // 
            // verdadero0
            // 
            this.verdadero0.AutoSize = true;
            this.verdadero0.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verdadero0.Location = new System.Drawing.Point(14, 32);
            this.verdadero0.Name = "verdadero0";
            this.verdadero0.Size = new System.Drawing.Size(93, 20);
            this.verdadero0.TabIndex = 0;
            this.verdadero0.TabStop = true;
            this.verdadero0.Text = " Verdadero";
            this.verdadero0.UseVisualStyleBackColor = true;
            this.verdadero0.CheckedChanged += new System.EventHandler(this.correct);
            // 
            // letraE
            // 
            this.letraE.AutoSize = true;
            this.letraE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.letraE.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.letraE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.letraE.Location = new System.Drawing.Point(25, 323);
            this.letraE.Name = "letraE";
            this.letraE.Size = new System.Drawing.Size(16, 16);
            this.letraE.TabIndex = 45;
            this.letraE.Text = "E";
            this.letraE.Visible = false;
            // 
            // letraD
            // 
            this.letraD.AutoSize = true;
            this.letraD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.letraD.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.letraD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.letraD.Location = new System.Drawing.Point(25, 275);
            this.letraD.Name = "letraD";
            this.letraD.Size = new System.Drawing.Size(17, 16);
            this.letraD.TabIndex = 44;
            this.letraD.Text = "D";
            this.letraD.Visible = false;
            // 
            // letraC
            // 
            this.letraC.AutoSize = true;
            this.letraC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.letraC.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.letraC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.letraC.Location = new System.Drawing.Point(25, 226);
            this.letraC.Name = "letraC";
            this.letraC.Size = new System.Drawing.Size(17, 16);
            this.letraC.TabIndex = 43;
            this.letraC.Text = "C";
            this.letraC.Visible = false;
            // 
            // letraB
            // 
            this.letraB.AutoSize = true;
            this.letraB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.letraB.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.letraB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.letraB.Location = new System.Drawing.Point(25, 177);
            this.letraB.Name = "letraB";
            this.letraB.Size = new System.Drawing.Size(16, 16);
            this.letraB.TabIndex = 42;
            this.letraB.Text = "B";
            this.letraB.Visible = false;
            // 
            // letraA
            // 
            this.letraA.AutoSize = true;
            this.letraA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.letraA.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.letraA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.letraA.Location = new System.Drawing.Point(25, 132);
            this.letraA.Name = "letraA";
            this.letraA.Size = new System.Drawing.Size(16, 16);
            this.letraA.TabIndex = 41;
            this.letraA.Text = "A";
            this.letraA.Visible = false;
            // 
            // enunciado
            // 
            this.enunciado.AutoSize = true;
            this.enunciado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enunciado.Location = new System.Drawing.Point(21, 57);
            this.enunciado.Name = "enunciado";
            this.enunciado.Size = new System.Drawing.Size(115, 30);
            this.enunciado.TabIndex = 32;
            this.enunciado.Text = "Enunciado:";
            // 
            // opc0
            // 
            this.opc0.AutoSize = true;
            this.opc0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.opc0.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opc0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opc0.Location = new System.Drawing.Point(72, 131);
            this.opc0.Name = "opc0";
            this.opc0.Size = new System.Drawing.Size(44, 16);
            this.opc0.TabIndex = 52;
            this.opc0.Text = "label2";
            // 
            // opc1
            // 
            this.opc1.AutoSize = true;
            this.opc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.opc1.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opc1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opc1.Location = new System.Drawing.Point(72, 176);
            this.opc1.Name = "opc1";
            this.opc1.Size = new System.Drawing.Size(44, 16);
            this.opc1.TabIndex = 53;
            this.opc1.Text = "label2";
            // 
            // opc2
            // 
            this.opc2.AutoSize = true;
            this.opc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.opc2.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opc2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opc2.Location = new System.Drawing.Point(72, 225);
            this.opc2.Name = "opc2";
            this.opc2.Size = new System.Drawing.Size(44, 16);
            this.opc2.TabIndex = 54;
            this.opc2.Text = "label2";
            // 
            // opc3
            // 
            this.opc3.AutoSize = true;
            this.opc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.opc3.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opc3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opc3.Location = new System.Drawing.Point(72, 274);
            this.opc3.Name = "opc3";
            this.opc3.Size = new System.Drawing.Size(44, 16);
            this.opc3.TabIndex = 55;
            this.opc3.Text = "label3";
            // 
            // opc4
            // 
            this.opc4.AutoSize = true;
            this.opc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.opc4.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opc4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opc4.Location = new System.Drawing.Point(72, 322);
            this.opc4.Name = "opc4";
            this.opc4.Size = new System.Drawing.Size(44, 16);
            this.opc4.TabIndex = 56;
            this.opc4.Text = "label4";
            this.opc4.Visible = false;
            // 
            // correcta0
            // 
            this.correcta0.AutoSize = true;
            this.correcta0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.correcta0.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correcta0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.correcta0.Location = new System.Drawing.Point(46, 133);
            this.correcta0.Name = "correcta0";
            this.correcta0.Size = new System.Drawing.Size(14, 13);
            this.correcta0.TabIndex = 19;
            this.correcta0.UseVisualStyleBackColor = false;
            this.correcta0.CheckedChanged += new System.EventHandler(this.correct);
            // 
            // correcta1
            // 
            this.correcta1.AutoSize = true;
            this.correcta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.correcta1.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correcta1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.correcta1.Location = new System.Drawing.Point(45, 178);
            this.correcta1.Name = "correcta1";
            this.correcta1.Size = new System.Drawing.Size(14, 13);
            this.correcta1.TabIndex = 21;
            this.correcta1.UseVisualStyleBackColor = false;
            this.correcta1.CheckedChanged += new System.EventHandler(this.correct);
            // 
            // correcta2
            // 
            this.correcta2.AutoSize = true;
            this.correcta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.correcta2.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correcta2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.correcta2.Location = new System.Drawing.Point(45, 226);
            this.correcta2.Name = "correcta2";
            this.correcta2.Size = new System.Drawing.Size(14, 13);
            this.correcta2.TabIndex = 22;
            this.correcta2.UseVisualStyleBackColor = false;
            this.correcta2.CheckedChanged += new System.EventHandler(this.correct);
            // 
            // correcta3
            // 
            this.correcta3.AutoSize = true;
            this.correcta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.correcta3.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correcta3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.correcta3.Location = new System.Drawing.Point(45, 277);
            this.correcta3.Name = "correcta3";
            this.correcta3.Size = new System.Drawing.Size(14, 13);
            this.correcta3.TabIndex = 23;
            this.correcta3.UseVisualStyleBackColor = false;
            this.correcta3.Visible = false;
            this.correcta3.CheckedChanged += new System.EventHandler(this.correct);
            // 
            // correcta4
            // 
            this.correcta4.AutoSize = true;
            this.correcta4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.correcta4.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correcta4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.correcta4.Location = new System.Drawing.Point(44, 324);
            this.correcta4.Name = "correcta4";
            this.correcta4.Size = new System.Drawing.Size(14, 13);
            this.correcta4.TabIndex = 24;
            this.correcta4.UseVisualStyleBackColor = false;
            this.correcta4.Visible = false;
            this.correcta4.CheckedChanged += new System.EventHandler(this.correct);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(232, 23);
            this.progressBar1.TabIndex = 64;
            this.progressBar1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 26;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(45, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(198, 364);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 68;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 69;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.siguiente);
            this.panel1.Controls.Add(this.anterior);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(425, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 452);
            this.panel1.TabIndex = 70;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.button3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.button3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button3.BorderRadius = 8;
            this.button3.BorderSize = 0;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(181, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 79;
            this.button3.Text = "Guardar";
            this.button3.TextColor = System.Drawing.Color.White;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button1.BorderRadius = 13;
            this.button1.BorderSize = 0;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(54, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 32);
            this.button1.TabIndex = 68;
            this.button1.Text = "Ocultar indice";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // siguiente
            // 
            this.siguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.siguiente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.siguiente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siguiente.BorderRadius = 8;
            this.siguiente.BorderSize = 0;
            this.siguiente.FlatAppearance.BorderSize = 0;
            this.siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siguiente.ForeColor = System.Drawing.Color.White;
            this.siguiente.Location = new System.Drawing.Point(102, 416);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(75, 28);
            this.siguiente.TabIndex = 78;
            this.siguiente.Text = "Siguiente";
            this.siguiente.TextColor = System.Drawing.Color.White;
            this.siguiente.UseVisualStyleBackColor = false;
            this.siguiente.Click += new System.EventHandler(this.siguiete_Click);
            // 
            // anterior
            // 
            this.anterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.anterior.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.anterior.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.anterior.BorderRadius = 8;
            this.anterior.BorderSize = 0;
            this.anterior.FlatAppearance.BorderSize = 0;
            this.anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anterior.ForeColor = System.Drawing.Color.White;
            this.anterior.Location = new System.Drawing.Point(22, 416);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(75, 28);
            this.anterior.TabIndex = 77;
            this.anterior.Text = "Anterior";
            this.anterior.TextColor = System.Drawing.Color.White;
            this.anterior.UseVisualStyleBackColor = false;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // CorrectaMult
            // 
            this.CorrectaMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.CorrectaMult.Controls.Add(this.check3);
            this.CorrectaMult.Controls.Add(this.check2);
            this.CorrectaMult.Controls.Add(this.check1);
            this.CorrectaMult.Controls.Add(this.check0);
            this.CorrectaMult.Controls.Add(this.check4);
            this.CorrectaMult.Controls.Add(this.correctaVF);
            this.CorrectaMult.Location = new System.Drawing.Point(30, 117);
            this.CorrectaMult.Name = "CorrectaMult";
            this.CorrectaMult.Size = new System.Drawing.Size(45, 245);
            this.CorrectaMult.TabIndex = 71;
            this.CorrectaMult.Visible = false;
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(16, 159);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(15, 14);
            this.check3.TabIndex = 3;
            this.check3.UseVisualStyleBackColor = true;
            this.check3.Visible = false;
            this.check3.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(16, 110);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(15, 14);
            this.check2.TabIndex = 2;
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(16, 62);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(15, 14);
            this.check1.TabIndex = 1;
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check0
            // 
            this.check0.AutoSize = true;
            this.check0.Location = new System.Drawing.Point(16, 15);
            this.check0.Name = "check0";
            this.check0.Size = new System.Drawing.Size(15, 14);
            this.check0.TabIndex = 0;
            this.check0.UseVisualStyleBackColor = true;
            this.check0.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(16, 207);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(15, 14);
            this.check4.TabIndex = 4;
            this.check4.UseVisualStyleBackColor = true;
            this.check4.Visible = false;
            this.check4.CheckedChanged += new System.EventHandler(this.EvMarcarCorrectaM);
            // 
            // RespuestaTxt
            // 
            this.RespuestaTxt.BackColor = System.Drawing.Color.White;
            this.RespuestaTxt.Location = new System.Drawing.Point(19, 117);
            this.RespuestaTxt.Multiline = true;
            this.RespuestaTxt.Name = "RespuestaTxt";
            this.RespuestaTxt.Size = new System.Drawing.Size(376, 245);
            this.RespuestaTxt.TabIndex = 72;
            this.RespuestaTxt.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 15);
            this.label4.TabIndex = 73;
            this.label4.Text = "——————————————————————————————";
            // 
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.fondo.Location = new System.Drawing.Point(12, 104);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(407, 264);
            this.fondo.TabIndex = 76;
            this.fondo.TabStop = false;
            // 
            // borrar_seleccion
            // 
            this.borrar_seleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.borrar_seleccion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.borrar_seleccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(143)))), ((int)(((byte)(245)))));
            this.borrar_seleccion.BorderRadius = 10;
            this.borrar_seleccion.BorderSize = 0;
            this.borrar_seleccion.FlatAppearance.BorderSize = 0;
            this.borrar_seleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar_seleccion.ForeColor = System.Drawing.Color.Transparent;
            this.borrar_seleccion.Location = new System.Drawing.Point(14, 438);
            this.borrar_seleccion.Name = "borrar_seleccion";
            this.borrar_seleccion.Size = new System.Drawing.Size(129, 28);
            this.borrar_seleccion.TabIndex = 69;
            this.borrar_seleccion.Text = "Borrar selección";
            this.borrar_seleccion.TextColor = System.Drawing.Color.Transparent;
            this.borrar_seleccion.UseVisualStyleBackColor = false;
            this.borrar_seleccion.Click += new System.EventHandler(this.borrar_seleccion_Click);
            // 
            // HacerExamen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(714, 492);
            this.Controls.Add(this.borrar_seleccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enunciado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.correcta4);
            this.Controls.Add(this.correcta3);
            this.Controls.Add(this.correcta0);
            this.Controls.Add(this.correcta2);
            this.Controls.Add(this.correcta1);
            this.Controls.Add(this.opc1);
            this.Controls.Add(this.opc4);
            this.Controls.Add(this.opc3);
            this.Controls.Add(this.opc0);
            this.Controls.Add(this.letraE);
            this.Controls.Add(this.letraD);
            this.Controls.Add(this.letraC);
            this.Controls.Add(this.opc2);
            this.Controls.Add(this.letraB);
            this.Controls.Add(this.letraA);
            this.Controls.Add(this.CorrectaMult);
            this.Controls.Add(this.RespuestaTxt);
            this.Controls.Add(this.fondo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HacerExamen2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.correctaVF.ResumeLayout(false);
            this.correctaVF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.CorrectaMult.ResumeLayout(false);
            this.CorrectaMult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel correctaVF;
        private System.Windows.Forms.RadioButton falso1;
        private System.Windows.Forms.RadioButton verdadero0;
        private System.Windows.Forms.Label letraE;
        private System.Windows.Forms.Label letraD;
        private System.Windows.Forms.Label letraC;
        private System.Windows.Forms.Label letraB;
        private System.Windows.Forms.Label letraA;
        private System.Windows.Forms.Label enunciado;
        private System.Windows.Forms.Label opc0;
        private System.Windows.Forms.Label opc1;
        private System.Windows.Forms.Label opc2;
        private System.Windows.Forms.Label opc3;
        private System.Windows.Forms.Label opc4;
        private System.Windows.Forms.RadioButton correcta0;
        private System.Windows.Forms.RadioButton correcta1;
        private System.Windows.Forms.RadioButton correcta2;
        private System.Windows.Forms.RadioButton correcta3;
        private System.Windows.Forms.RadioButton correcta4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel CorrectaMult;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check0;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.TextBox RespuestaTxt;
        private System.Windows.Forms.Label label4;
        private Controles_extra.Botones_fancy button1;
        private System.Windows.Forms.PictureBox fondo;
        private Controles_extra.Botones_fancy borrar_seleccion;
        private Controles_extra.Botones_fancy anterior;
        private Controles_extra.Botones_fancy siguiente;
        private Controles_extra.Botones_fancy button3;
        private System.Windows.Forms.Label label6;
    }
}