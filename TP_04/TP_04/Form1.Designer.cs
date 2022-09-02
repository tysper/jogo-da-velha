namespace TP_04
{
    partial class FRM_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.GRP_Partida = new System.Windows.Forms.GroupBox();
            this.GRP_Placar = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_Venceu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TXT_Nome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LBL_Perdeu = new System.Windows.Forms.Label();
            this.LBL_Empatou = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTN_Reiniciar = new System.Windows.Forms.Button();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ESP_0 = new System.Windows.Forms.PictureBox();
            this.ESP_1 = new System.Windows.Forms.PictureBox();
            this.ESP_2 = new System.Windows.Forms.PictureBox();
            this.ESP_3 = new System.Windows.Forms.PictureBox();
            this.ESP_4 = new System.Windows.Forms.PictureBox();
            this.ESP_5 = new System.Windows.Forms.PictureBox();
            this.ESP_8 = new System.Windows.Forms.PictureBox();
            this.ESP_7 = new System.Windows.Forms.PictureBox();
            this.ESP_6 = new System.Windows.Forms.PictureBox();
            this.GRP_Partida.SuspendLayout();
            this.GRP_Placar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_6)).BeginInit();
            this.SuspendLayout();
            // 
            // GRP_Partida
            // 
            this.GRP_Partida.Controls.Add(this.tableLayoutPanel1);
            this.GRP_Partida.Location = new System.Drawing.Point(12, 155);
            this.GRP_Partida.Name = "GRP_Partida";
            this.GRP_Partida.Size = new System.Drawing.Size(383, 331);
            this.GRP_Partida.TabIndex = 1;
            this.GRP_Partida.TabStop = false;
            this.GRP_Partida.Text = "Partida <numero> - <Jogador>";
            // 
            // GRP_Placar
            // 
            this.GRP_Placar.Controls.Add(this.panel1);
            this.GRP_Placar.Location = new System.Drawing.Point(13, 493);
            this.GRP_Placar.Name = "GRP_Placar";
            this.GRP_Placar.Size = new System.Drawing.Size(382, 48);
            this.GRP_Placar.TabIndex = 2;
            this.GRP_Placar.TabStop = false;
            this.GRP_Placar.Text = "Placar de <Nome>";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBL_Empatou);
            this.panel1.Controls.Add(this.LBL_Perdeu);
            this.panel1.Controls.Add(this.LBL_Venceu);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 15);
            this.panel1.TabIndex = 0;
            // 
            // LBL_Venceu
            // 
            this.LBL_Venceu.AutoSize = true;
            this.LBL_Venceu.Location = new System.Drawing.Point(3, 2);
            this.LBL_Venceu.Name = "LBL_Venceu";
            this.LBL_Venceu.Size = new System.Drawing.Size(64, 13);
            this.LBL_Venceu.TabIndex = 0;
            this.LBL_Venceu.Text = "Venceu: XX";
            this.LBL_Venceu.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite seu nome ou apelido:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TXT_Nome);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(100, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 73);
            this.panel2.TabIndex = 5;
            // 
            // TXT_Nome
            // 
            this.TXT_Nome.Location = new System.Drawing.Point(3, 41);
            this.TXT_Nome.Name = "TXT_Nome";
            this.TXT_Nome.Size = new System.Drawing.Size(277, 20);
            this.TXT_Nome.TabIndex = 5;
            this.TXT_Nome.TextChanged += new System.EventHandler(this.TXT_Nome_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 98);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Identificação do Jogador";
            // 
            // LBL_Perdeu
            // 
            this.LBL_Perdeu.AutoSize = true;
            this.LBL_Perdeu.Location = new System.Drawing.Point(152, 2);
            this.LBL_Perdeu.Name = "LBL_Perdeu";
            this.LBL_Perdeu.Size = new System.Drawing.Size(61, 13);
            this.LBL_Perdeu.TabIndex = 1;
            this.LBL_Perdeu.Text = "Perdeu: XX";
            // 
            // LBL_Empatou
            // 
            this.LBL_Empatou.AutoSize = true;
            this.LBL_Empatou.Location = new System.Drawing.Point(298, 2);
            this.LBL_Empatou.Name = "LBL_Empatou";
            this.LBL_Empatou.Size = new System.Drawing.Size(69, 13);
            this.LBL_Empatou.TabIndex = 2;
            this.LBL_Empatou.Text = "Empatou: XX";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BTN_Sair);
            this.panel3.Controls.Add(this.BTN_Reiniciar);
            this.panel3.Location = new System.Drawing.Point(12, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 32);
            this.panel3.TabIndex = 8;
            // 
            // BTN_Reiniciar
            // 
            this.BTN_Reiniciar.Location = new System.Drawing.Point(7, 3);
            this.BTN_Reiniciar.Name = "BTN_Reiniciar";
            this.BTN_Reiniciar.Size = new System.Drawing.Size(153, 26);
            this.BTN_Reiniciar.TabIndex = 0;
            this.BTN_Reiniciar.Text = "Reiniciar o Jogo";
            this.BTN_Reiniciar.UseVisualStyleBackColor = true;
            this.BTN_Reiniciar.Click += new System.EventHandler(this.BTN_Reiniciar_Click);
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.Location = new System.Drawing.Point(227, 3);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(153, 26);
            this.BTN_Sair.TabIndex = 1;
            this.BTN_Sair.Text = "Sair do Jogo";
            this.BTN_Sair.UseVisualStyleBackColor = true;
            this.BTN_Sair.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.ESP_0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ESP_1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ESP_2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ESP_3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ESP_4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ESP_5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ESP_8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ESP_7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ESP_6, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(371, 306);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ESP_0
            // 
            this.ESP_0.BackColor = System.Drawing.Color.AliceBlue;
            this.ESP_0.Location = new System.Drawing.Point(3, 3);
            this.ESP_0.Name = "ESP_0";
            this.ESP_0.Size = new System.Drawing.Size(117, 96);
            this.ESP_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESP_0.TabIndex = 0;
            this.ESP_0.TabStop = false;
            this.ESP_0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ESP_0_MouseClick);
            // 
            // ESP_1
            // 
            this.ESP_1.BackColor = System.Drawing.Color.AliceBlue;
            this.ESP_1.Location = new System.Drawing.Point(126, 3);
            this.ESP_1.Name = "ESP_1";
            this.ESP_1.Size = new System.Drawing.Size(117, 96);
            this.ESP_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESP_1.TabIndex = 0;
            this.ESP_1.TabStop = false;
            this.ESP_1.Click += new System.EventHandler(this.ESP_1_Click);
            // 
            // ESP_2
            // 
            this.ESP_2.BackColor = System.Drawing.Color.AliceBlue;
            this.ESP_2.Location = new System.Drawing.Point(249, 3);
            this.ESP_2.Name = "ESP_2";
            this.ESP_2.Size = new System.Drawing.Size(117, 96);
            this.ESP_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESP_2.TabIndex = 0;
            this.ESP_2.TabStop = false;
            this.ESP_2.Click += new System.EventHandler(this.ESP_2_Click);
            // 
            // ESP_3
            // 
            this.ESP_3.BackColor = System.Drawing.Color.AliceBlue;
            this.ESP_3.Location = new System.Drawing.Point(3, 105);
            this.ESP_3.Name = "ESP_3";
            this.ESP_3.Size = new System.Drawing.Size(117, 96);
            this.ESP_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESP_3.TabIndex = 0;
            this.ESP_3.TabStop = false;
            this.ESP_3.Click += new System.EventHandler(this.ESP_3_Click);
            // 
            // ESP_4
            // 
            this.ESP_4.BackColor = System.Drawing.Color.AliceBlue;
            this.ESP_4.Location = new System.Drawing.Point(126, 105);
            this.ESP_4.Name = "ESP_4";
            this.ESP_4.Size = new System.Drawing.Size(117, 96);
            this.ESP_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESP_4.TabIndex = 0;
            this.ESP_4.TabStop = false;
            this.ESP_4.Click += new System.EventHandler(this.ESP_4_Click);
            // 
            // ESP_5
            // 
            this.ESP_5.BackColor = System.Drawing.Color.AliceBlue;
            this.ESP_5.Location = new System.Drawing.Point(249, 105);
            this.ESP_5.Name = "ESP_5";
            this.ESP_5.Size = new System.Drawing.Size(117, 96);
            this.ESP_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESP_5.TabIndex = 0;
            this.ESP_5.TabStop = false;
            this.ESP_5.Click += new System.EventHandler(this.ESP_5_Click);
            // 
            // ESP_8
            // 
            this.ESP_8.BackColor = System.Drawing.Color.AliceBlue;
            this.ESP_8.Location = new System.Drawing.Point(249, 207);
            this.ESP_8.Name = "ESP_8";
            this.ESP_8.Size = new System.Drawing.Size(117, 96);
            this.ESP_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESP_8.TabIndex = 0;
            this.ESP_8.TabStop = false;
            this.ESP_8.Click += new System.EventHandler(this.ESP_8_Click);
            // 
            // ESP_7
            // 
            this.ESP_7.BackColor = System.Drawing.Color.AliceBlue;
            this.ESP_7.Location = new System.Drawing.Point(126, 207);
            this.ESP_7.Name = "ESP_7";
            this.ESP_7.Size = new System.Drawing.Size(117, 96);
            this.ESP_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESP_7.TabIndex = 0;
            this.ESP_7.TabStop = false;
            this.ESP_7.Click += new System.EventHandler(this.ESP_7_Click);
            // 
            // ESP_6
            // 
            this.ESP_6.BackColor = System.Drawing.Color.AliceBlue;
            this.ESP_6.Location = new System.Drawing.Point(3, 207);
            this.ESP_6.Name = "ESP_6";
            this.ESP_6.Size = new System.Drawing.Size(117, 96);
            this.ESP_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ESP_6.TabIndex = 0;
            this.ESP_6.TabStop = false;
            this.ESP_6.Click += new System.EventHandler(this.ESP_6_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(407, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GRP_Placar);
            this.Controls.Add(this.GRP_Partida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.Load += new System.EventHandler(this.FRM_Main_Load);
            this.GRP_Partida.ResumeLayout(false);
            this.GRP_Placar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ESP_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ESP_6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GRP_Partida;
        private System.Windows.Forms.GroupBox GRP_Placar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_Venceu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TXT_Nome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LBL_Empatou;
        private System.Windows.Forms.Label LBL_Perdeu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BTN_Reiniciar;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox ESP_0;
        private System.Windows.Forms.PictureBox ESP_1;
        private System.Windows.Forms.PictureBox ESP_2;
        private System.Windows.Forms.PictureBox ESP_3;
        private System.Windows.Forms.PictureBox ESP_4;
        private System.Windows.Forms.PictureBox ESP_5;
        private System.Windows.Forms.PictureBox ESP_8;
        private System.Windows.Forms.PictureBox ESP_7;
        private System.Windows.Forms.PictureBox ESP_6;
    }
}

