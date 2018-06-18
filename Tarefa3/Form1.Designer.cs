namespace Tarefa3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.musicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandaArtistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ouvirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAjudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsbFaixas = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnPlay = new System.Windows.Forms.ToolStripButton();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            this.btnAvancar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbxBanda = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblFaixas = new System.Windows.Forms.Label();
            this.lblNomeAlbum = new System.Windows.Forms.Label();
            this.picCapa = new System.Windows.Forms.PictureBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.cadastrarToolStripMenuItem,
            this.ouvirToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicoToolStripMenuItem,
            this.bandaArtistaToolStripMenuItem,
            this.musicasToolStripMenuItem,
            this.albumToolStripMenuItem2});
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem1.Text = "&Cadastrar";
            // 
            // musicoToolStripMenuItem
            // 
            this.musicoToolStripMenuItem.Image = global::Tarefa3.Properties.Resources.icon_musico;
            this.musicoToolStripMenuItem.Name = "musicoToolStripMenuItem";
            this.musicoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.musicoToolStripMenuItem.Text = "Musico";
            this.musicoToolStripMenuItem.Click += new System.EventHandler(this.musicoToolStripMenuItem_Click);
            // 
            // bandaArtistaToolStripMenuItem
            // 
            this.bandaArtistaToolStripMenuItem.Image = global::Tarefa3.Properties.Resources.icon_garageband;
            this.bandaArtistaToolStripMenuItem.Name = "bandaArtistaToolStripMenuItem";
            this.bandaArtistaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.bandaArtistaToolStripMenuItem.Text = "Banda/Artista";
            this.bandaArtistaToolStripMenuItem.Click += new System.EventHandler(this.bandaArtistaToolStripMenuItem_Click);
            // 
            // musicasToolStripMenuItem
            // 
            this.musicasToolStripMenuItem.Image = global::Tarefa3.Properties.Resources.icon_music;
            this.musicasToolStripMenuItem.Name = "musicasToolStripMenuItem";
            this.musicasToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.musicasToolStripMenuItem.Text = "Musicas";
            this.musicasToolStripMenuItem.Click += new System.EventHandler(this.musicasToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem2
            // 
            this.albumToolStripMenuItem2.Image = global::Tarefa3.Properties.Resources.icon_cd;
            this.albumToolStripMenuItem2.Name = "albumToolStripMenuItem2";
            this.albumToolStripMenuItem2.Size = new System.Drawing.Size(146, 22);
            this.albumToolStripMenuItem2.Text = "Album";
            this.albumToolStripMenuItem2.Click += new System.EventHandler(this.albumToolStripMenuItem2_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistaToolStripMenuItem,
            this.bandaToolStripMenuItem,
            this.musicaToolStripMenuItem,
            this.albumToolStripMenuItem1,
            this.toolStripSeparator1});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "&Gerenciar";
            // 
            // artistaToolStripMenuItem
            // 
            this.artistaToolStripMenuItem.Image = global::Tarefa3.Properties.Resources.icon_musico;
            this.artistaToolStripMenuItem.Name = "artistaToolStripMenuItem";
            this.artistaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.artistaToolStripMenuItem.Text = "Musico";
            this.artistaToolStripMenuItem.Click += new System.EventHandler(this.artistaToolStripMenuItem_Click);
            // 
            // bandaToolStripMenuItem
            // 
            this.bandaToolStripMenuItem.Image = global::Tarefa3.Properties.Resources.icon_garageband;
            this.bandaToolStripMenuItem.Name = "bandaToolStripMenuItem";
            this.bandaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.bandaToolStripMenuItem.Text = "Banda/Artista";
            this.bandaToolStripMenuItem.Click += new System.EventHandler(this.bandaToolStripMenuItem_Click);
            // 
            // musicaToolStripMenuItem
            // 
            this.musicaToolStripMenuItem.Image = global::Tarefa3.Properties.Resources.icon_music;
            this.musicaToolStripMenuItem.Name = "musicaToolStripMenuItem";
            this.musicaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.musicaToolStripMenuItem.Text = "Musicas";
            this.musicaToolStripMenuItem.Click += new System.EventHandler(this.musicaToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem1
            // 
            this.albumToolStripMenuItem1.Image = global::Tarefa3.Properties.Resources.icon_cd;
            this.albumToolStripMenuItem1.Name = "albumToolStripMenuItem1";
            this.albumToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.albumToolStripMenuItem1.Text = "Album";
            this.albumToolStripMenuItem1.Click += new System.EventHandler(this.albumToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // ouvirToolStripMenuItem
            // 
            this.ouvirToolStripMenuItem.Name = "ouvirToolStripMenuItem";
            this.ouvirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ouvirToolStripMenuItem.Text = "Ouvir";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAjudaToolStripMenuItem,
            this.toolStripSeparator2,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // verAjudaToolStripMenuItem
            // 
            this.verAjudaToolStripMenuItem.Name = "verAjudaToolStripMenuItem";
            this.verAjudaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.verAjudaToolStripMenuItem.Text = "Ver Ajuda";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(122, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // lsbFaixas
            // 
            this.lsbFaixas.FormattingEnabled = true;
            this.lsbFaixas.Location = new System.Drawing.Point(302, 84);
            this.lsbFaixas.Name = "lsbFaixas";
            this.lsbFaixas.Size = new System.Drawing.Size(260, 329);
            this.lsbFaixas.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(600, 365);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(315, 47);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.AllowUserToAddRows = false;
            this.dgvAlbum.AllowUserToDeleteRows = false;
            this.dgvAlbum.AllowUserToResizeColumns = false;
            this.dgvAlbum.AllowUserToResizeRows = false;
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome});
            this.dgvAlbum.Location = new System.Drawing.Point(12, 84);
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.Size = new System.Drawing.Size(247, 328);
            this.dgvAlbum.TabIndex = 5;
            this.dgvAlbum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbum_CellClick);
            // 
            // nome
            // 
            this.nome.FillWeight = 203F;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 203;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVoltar,
            this.btnStop,
            this.btnPlay,
            this.btnPause,
            this.btnAvancar,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.cbxBanda,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(948, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnVoltar
            // 
            this.btnVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVoltar.Image = global::Tarefa3.Properties.Resources.icon_backward;
            this.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(23, 22);
            this.btnVoltar.Text = "Anterior";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = global::Tarefa3.Properties.Resources.icon_stop_32;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPlay.Image = global::Tarefa3.Properties.Resources.icon_play_32;
            this.btnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(23, 22);
            this.btnPlay.Text = "Play";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPause.Image = global::Tarefa3.Properties.Resources._1416908690_icon_pause_32;
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(23, 22);
            this.btnPause.Text = "Pausar";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAvancar.Image = global::Tarefa3.Properties.Resources.icon_forward_32;
            this.btnAvancar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(23, 22);
            this.btnAvancar.Text = "Proximo";
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel1.Text = "Banda/Artista:";
            // 
            // cbxBanda
            // 
            this.cbxBanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBanda.Name = "cbxBanda";
            this.cbxBanda.Size = new System.Drawing.Size(121, 25);
            this.cbxBanda.SelectedIndexChanged += new System.EventHandler(this.cbxBanda_SelectedIndexChanged);
            this.cbxBanda.Click += new System.EventHandler(this.cbxBanda_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(948, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "Bem Vindo!!!";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(11, 56);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(72, 25);
            this.lblAlbum.TabIndex = 8;
            this.lblAlbum.Text = "Album";
            // 
            // lblFaixas
            // 
            this.lblFaixas.AutoSize = true;
            this.lblFaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaixas.Location = new System.Drawing.Point(288, 56);
            this.lblFaixas.Name = "lblFaixas";
            this.lblFaixas.Size = new System.Drawing.Size(76, 25);
            this.lblFaixas.TabIndex = 9;
            this.lblFaixas.Text = "Faixas";
            // 
            // lblNomeAlbum
            // 
            this.lblNomeAlbum.AutoSize = true;
            this.lblNomeAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAlbum.Location = new System.Drawing.Point(595, 56);
            this.lblNomeAlbum.Name = "lblNomeAlbum";
            this.lblNomeAlbum.Size = new System.Drawing.Size(134, 25);
            this.lblNomeAlbum.TabIndex = 10;
            this.lblNomeAlbum.Text = "Nome Album";
            // 
            // picCapa
            // 
            this.picCapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.picCapa.Image = global::Tarefa3.Properties.Resources.icon_lp;
            this.picCapa.Location = new System.Drawing.Point(600, 84);
            this.picCapa.Name = "picCapa";
            this.picCapa.Size = new System.Drawing.Size(315, 275);
            this.picCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCapa.TabIndex = 3;
            this.picCapa.TabStop = false;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(255, 22);
            this.toolStripLabel2.Text = "Clique aqui para Abrir o Windows Media Player";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 465);
            this.Controls.Add(this.lblNomeAlbum);
            this.Controls.Add(this.lblFaixas);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvAlbum);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.picCapa);
            this.Controls.Add(this.lsbFaixas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefa 3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ouvirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAjudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ListBox lsbFaixas;
        private System.Windows.Forms.PictureBox picCapa;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem musicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandaArtistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem2;
        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnPlay;
        private System.Windows.Forms.ToolStripButton btnPause;
        private System.Windows.Forms.ToolStripButton btnAvancar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbxBanda;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblFaixas;
        private System.Windows.Forms.Label lblNomeAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}

