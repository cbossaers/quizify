namespace QuizifyIU
{
    partial class Estadisticas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progress_bar_fancy1 = new QuizifyIU.Controles_extra.Progress_bar_fancy();
            this.progress_bar_fancy2 = new QuizifyIU.Controles_extra.Progress_bar_fancy();
            this.progress_bar_fancy3 = new QuizifyIU.Controles_extra.Progress_bar_fancy();
            this.progress_bar_fancy4 = new QuizifyIU.Controles_extra.Progress_bar_fancy();
            this.progress_bar_fancy5 = new QuizifyIU.Controles_extra.Progress_bar_fancy();
            this.progress_bar_fancy6 = new QuizifyIU.Controles_extra.Progress_bar_fancy();
            this.progress_bar_fancy7 = new QuizifyIU.Controles_extra.Progress_bar_fancy();
            this.progress_bar_fancy8 = new QuizifyIU.Controles_extra.Progress_bar_fancy();
            this.progress_bar_fancy9 = new QuizifyIU.Controles_extra.Progress_bar_fancy();
            this.progress_bar_fancy10 = new QuizifyIU.Controles_extra.Progress_bar_fancy();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rango = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 274);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(166)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(707, 206);
            this.dataGridView1.TabIndex = 11;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(142, 66);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(121, 24);
            this.label.TabIndex = 12;
            this.label.Text = "Nombre quiz";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre quiz";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(142, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre quiz";
            // 
            // progress_bar_fancy1
            // 
            this.progress_bar_fancy1.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progress_bar_fancy1.ChannelHeight = 6;
            this.progress_bar_fancy1.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy1.ForeColor = System.Drawing.Color.White;
            this.progress_bar_fancy1.Location = new System.Drawing.Point(455, 58);
            this.progress_bar_fancy1.Maximum = 10;
            this.progress_bar_fancy1.Name = "progress_bar_fancy1";
            this.progress_bar_fancy1.ShowMaximun = true;
            this.progress_bar_fancy1.ShowValue = QuizifyIU.Controles_extra.TextPosition.Right;
            this.progress_bar_fancy1.Size = new System.Drawing.Size(161, 15);
            this.progress_bar_fancy1.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy1.SliderHeight = 6;
            this.progress_bar_fancy1.SymbolAfter = "";
            this.progress_bar_fancy1.SymbolBefore = "";
            this.progress_bar_fancy1.TabIndex = 15;
            this.progress_bar_fancy1.Value = 8;
            this.progress_bar_fancy1.Visible = false;
            // 
            // progress_bar_fancy2
            // 
            this.progress_bar_fancy2.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progress_bar_fancy2.ChannelHeight = 6;
            this.progress_bar_fancy2.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy2.ForeColor = System.Drawing.Color.White;
            this.progress_bar_fancy2.Location = new System.Drawing.Point(455, 74);
            this.progress_bar_fancy2.Maximum = 10;
            this.progress_bar_fancy2.Name = "progress_bar_fancy2";
            this.progress_bar_fancy2.ShowMaximun = false;
            this.progress_bar_fancy2.ShowValue = QuizifyIU.Controles_extra.TextPosition.Right;
            this.progress_bar_fancy2.Size = new System.Drawing.Size(161, 15);
            this.progress_bar_fancy2.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy2.SliderHeight = 6;
            this.progress_bar_fancy2.SymbolAfter = "";
            this.progress_bar_fancy2.SymbolBefore = "";
            this.progress_bar_fancy2.TabIndex = 16;
            this.progress_bar_fancy2.Value = 8;
            this.progress_bar_fancy2.Visible = false;
            // 
            // progress_bar_fancy3
            // 
            this.progress_bar_fancy3.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progress_bar_fancy3.ChannelHeight = 6;
            this.progress_bar_fancy3.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy3.ForeColor = System.Drawing.Color.White;
            this.progress_bar_fancy3.Location = new System.Drawing.Point(455, 90);
            this.progress_bar_fancy3.Maximum = 10;
            this.progress_bar_fancy3.Name = "progress_bar_fancy3";
            this.progress_bar_fancy3.ShowMaximun = false;
            this.progress_bar_fancy3.ShowValue = QuizifyIU.Controles_extra.TextPosition.Right;
            this.progress_bar_fancy3.Size = new System.Drawing.Size(161, 15);
            this.progress_bar_fancy3.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy3.SliderHeight = 6;
            this.progress_bar_fancy3.SymbolAfter = "";
            this.progress_bar_fancy3.SymbolBefore = "";
            this.progress_bar_fancy3.TabIndex = 17;
            this.progress_bar_fancy3.Value = 8;
            this.progress_bar_fancy3.Visible = false;
            // 
            // progress_bar_fancy4
            // 
            this.progress_bar_fancy4.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progress_bar_fancy4.ChannelHeight = 6;
            this.progress_bar_fancy4.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy4.ForeColor = System.Drawing.Color.White;
            this.progress_bar_fancy4.Location = new System.Drawing.Point(455, 107);
            this.progress_bar_fancy4.Maximum = 10;
            this.progress_bar_fancy4.Name = "progress_bar_fancy4";
            this.progress_bar_fancy4.ShowMaximun = true;
            this.progress_bar_fancy4.ShowValue = QuizifyIU.Controles_extra.TextPosition.Right;
            this.progress_bar_fancy4.Size = new System.Drawing.Size(161, 15);
            this.progress_bar_fancy4.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy4.SliderHeight = 6;
            this.progress_bar_fancy4.SymbolAfter = "";
            this.progress_bar_fancy4.SymbolBefore = "";
            this.progress_bar_fancy4.TabIndex = 18;
            this.progress_bar_fancy4.Value = 8;
            this.progress_bar_fancy4.Visible = false;
            // 
            // progress_bar_fancy5
            // 
            this.progress_bar_fancy5.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progress_bar_fancy5.ChannelHeight = 6;
            this.progress_bar_fancy5.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy5.ForeColor = System.Drawing.Color.White;
            this.progress_bar_fancy5.Location = new System.Drawing.Point(455, 124);
            this.progress_bar_fancy5.Maximum = 10;
            this.progress_bar_fancy5.Name = "progress_bar_fancy5";
            this.progress_bar_fancy5.ShowMaximun = false;
            this.progress_bar_fancy5.ShowValue = QuizifyIU.Controles_extra.TextPosition.Right;
            this.progress_bar_fancy5.Size = new System.Drawing.Size(161, 15);
            this.progress_bar_fancy5.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy5.SliderHeight = 6;
            this.progress_bar_fancy5.SymbolAfter = "";
            this.progress_bar_fancy5.SymbolBefore = "";
            this.progress_bar_fancy5.TabIndex = 19;
            this.progress_bar_fancy5.Value = 8;
            this.progress_bar_fancy5.Visible = false;
            // 
            // progress_bar_fancy6
            // 
            this.progress_bar_fancy6.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progress_bar_fancy6.ChannelHeight = 6;
            this.progress_bar_fancy6.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy6.ForeColor = System.Drawing.Color.White;
            this.progress_bar_fancy6.Location = new System.Drawing.Point(455, 140);
            this.progress_bar_fancy6.Maximum = 10;
            this.progress_bar_fancy6.Name = "progress_bar_fancy6";
            this.progress_bar_fancy6.ShowMaximun = false;
            this.progress_bar_fancy6.ShowValue = QuizifyIU.Controles_extra.TextPosition.Right;
            this.progress_bar_fancy6.Size = new System.Drawing.Size(161, 15);
            this.progress_bar_fancy6.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy6.SliderHeight = 6;
            this.progress_bar_fancy6.SymbolAfter = "";
            this.progress_bar_fancy6.SymbolBefore = "";
            this.progress_bar_fancy6.TabIndex = 20;
            this.progress_bar_fancy6.Value = 8;
            this.progress_bar_fancy6.Visible = false;
            // 
            // progress_bar_fancy7
            // 
            this.progress_bar_fancy7.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progress_bar_fancy7.ChannelHeight = 6;
            this.progress_bar_fancy7.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy7.ForeColor = System.Drawing.Color.White;
            this.progress_bar_fancy7.Location = new System.Drawing.Point(455, 156);
            this.progress_bar_fancy7.Maximum = 10;
            this.progress_bar_fancy7.Name = "progress_bar_fancy7";
            this.progress_bar_fancy7.ShowMaximun = false;
            this.progress_bar_fancy7.ShowValue = QuizifyIU.Controles_extra.TextPosition.Right;
            this.progress_bar_fancy7.Size = new System.Drawing.Size(161, 15);
            this.progress_bar_fancy7.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy7.SliderHeight = 6;
            this.progress_bar_fancy7.SymbolAfter = "";
            this.progress_bar_fancy7.SymbolBefore = "";
            this.progress_bar_fancy7.TabIndex = 21;
            this.progress_bar_fancy7.Value = 8;
            this.progress_bar_fancy7.Visible = false;
            // 
            // progress_bar_fancy8
            // 
            this.progress_bar_fancy8.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progress_bar_fancy8.ChannelHeight = 6;
            this.progress_bar_fancy8.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy8.ForeColor = System.Drawing.Color.White;
            this.progress_bar_fancy8.Location = new System.Drawing.Point(455, 172);
            this.progress_bar_fancy8.Maximum = 10;
            this.progress_bar_fancy8.Name = "progress_bar_fancy8";
            this.progress_bar_fancy8.ShowMaximun = false;
            this.progress_bar_fancy8.ShowValue = QuizifyIU.Controles_extra.TextPosition.Right;
            this.progress_bar_fancy8.Size = new System.Drawing.Size(161, 15);
            this.progress_bar_fancy8.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy8.SliderHeight = 6;
            this.progress_bar_fancy8.SymbolAfter = "";
            this.progress_bar_fancy8.SymbolBefore = "";
            this.progress_bar_fancy8.TabIndex = 22;
            this.progress_bar_fancy8.Value = 8;
            this.progress_bar_fancy8.Visible = false;
            // 
            // progress_bar_fancy9
            // 
            this.progress_bar_fancy9.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progress_bar_fancy9.ChannelHeight = 6;
            this.progress_bar_fancy9.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy9.ForeColor = System.Drawing.Color.White;
            this.progress_bar_fancy9.Location = new System.Drawing.Point(455, 188);
            this.progress_bar_fancy9.Maximum = 10;
            this.progress_bar_fancy9.Name = "progress_bar_fancy9";
            this.progress_bar_fancy9.ShowMaximun = false;
            this.progress_bar_fancy9.ShowValue = QuizifyIU.Controles_extra.TextPosition.Right;
            this.progress_bar_fancy9.Size = new System.Drawing.Size(161, 15);
            this.progress_bar_fancy9.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy9.SliderHeight = 6;
            this.progress_bar_fancy9.SymbolAfter = "";
            this.progress_bar_fancy9.SymbolBefore = "";
            this.progress_bar_fancy9.TabIndex = 23;
            this.progress_bar_fancy9.Value = 8;
            this.progress_bar_fancy9.Visible = false;
            // 
            // progress_bar_fancy10
            // 
            this.progress_bar_fancy10.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.progress_bar_fancy10.ChannelHeight = 6;
            this.progress_bar_fancy10.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy10.ForeColor = System.Drawing.Color.White;
            this.progress_bar_fancy10.Location = new System.Drawing.Point(455, 204);
            this.progress_bar_fancy10.Maximum = 10;
            this.progress_bar_fancy10.Name = "progress_bar_fancy10";
            this.progress_bar_fancy10.ShowMaximun = false;
            this.progress_bar_fancy10.ShowValue = QuizifyIU.Controles_extra.TextPosition.Right;
            this.progress_bar_fancy10.Size = new System.Drawing.Size(161, 15);
            this.progress_bar_fancy10.SliderColor = System.Drawing.Color.RoyalBlue;
            this.progress_bar_fancy10.SliderHeight = 6;
            this.progress_bar_fancy10.SymbolAfter = "";
            this.progress_bar_fancy10.SymbolBefore = "";
            this.progress_bar_fancy10.TabIndex = 24;
            this.progress_bar_fancy10.Value = 8;
            this.progress_bar_fancy10.Visible = false;
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
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Envios ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Desv.Típica";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nota Media";
            // 
            // rango
            // 
            this.rango.AutoSize = true;
            this.rango.Location = new System.Drawing.Point(430, 61);
            this.rango.Name = "rango";
            this.rango.Size = new System.Drawing.Size(13, 15);
            this.rango.TabIndex = 28;
            this.rango.Text = "0";
            this.rango.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "1+";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "2+";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "3+";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "4+";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 33;
            this.label10.Text = "5+";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(430, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "6+";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(430, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 35;
            this.label12.Text = "7+";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(430, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 15);
            this.label13.TabIndex = 36;
            this.label13.Text = "8+";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(430, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 15);
            this.label14.TabIndex = 37;
            this.label14.Text = "9+";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(12, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 24);
            this.label15.TabIndex = 39;
            this.label15.Text = "Examen sobre";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Neue Haas Grotesk Text Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(156, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 24);
            this.label16.TabIndex = 38;
            this.label16.Text = "0";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(714, 492);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rango);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.progress_bar_fancy10);
            this.Controls.Add(this.progress_bar_fancy9);
            this.Controls.Add(this.progress_bar_fancy8);
            this.Controls.Add(this.progress_bar_fancy7);
            this.Controls.Add(this.progress_bar_fancy6);
            this.Controls.Add(this.progress_bar_fancy5);
            this.Controls.Add(this.progress_bar_fancy4);
            this.Controls.Add(this.progress_bar_fancy3);
            this.Controls.Add(this.progress_bar_fancy2);
            this.Controls.Add(this.progress_bar_fancy1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Estadisticas";
            this.Text = "Estadísticas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controles_extra.Progress_bar_fancy progress_bar_fancy1;
        private Controles_extra.Progress_bar_fancy progress_bar_fancy2;
        private Controles_extra.Progress_bar_fancy progress_bar_fancy3;
        private Controles_extra.Progress_bar_fancy progress_bar_fancy4;
        private Controles_extra.Progress_bar_fancy progress_bar_fancy5;
        private Controles_extra.Progress_bar_fancy progress_bar_fancy6;
        private Controles_extra.Progress_bar_fancy progress_bar_fancy7;
        private Controles_extra.Progress_bar_fancy progress_bar_fancy8;
        private Controles_extra.Progress_bar_fancy progress_bar_fancy9;
        private Controles_extra.Progress_bar_fancy progress_bar_fancy10;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rango;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}