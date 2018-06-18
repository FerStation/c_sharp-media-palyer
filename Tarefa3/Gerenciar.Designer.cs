namespace Tarefa3
{
    partial class Gerenciar
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
            this.tabGerenciar = new System.Windows.Forms.TabControl();
            this.tabMusico = new System.Windows.Forms.TabPage();
            this.dgvMusico = new System.Windows.Forms.DataGridView();
            this.nomeMusico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alterarMusico = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletarMusico = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabBanda = new System.Windows.Forms.TabPage();
            this.dgvBanda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabMusicas = new System.Windows.Forms.TabPage();
            this.dgvMusicas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabAlbum = new System.Windows.Forms.TabPage();
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabGerenciar.SuspendLayout();
            this.tabMusico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusico)).BeginInit();
            this.tabBanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanda)).BeginInit();
            this.tabMusicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).BeginInit();
            this.tabAlbum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGerenciar
            // 
            this.tabGerenciar.Controls.Add(this.tabMusico);
            this.tabGerenciar.Controls.Add(this.tabBanda);
            this.tabGerenciar.Controls.Add(this.tabMusicas);
            this.tabGerenciar.Controls.Add(this.tabAlbum);
            this.tabGerenciar.Location = new System.Drawing.Point(13, 13);
            this.tabGerenciar.Name = "tabGerenciar";
            this.tabGerenciar.SelectedIndex = 0;
            this.tabGerenciar.Size = new System.Drawing.Size(735, 343);
            this.tabGerenciar.TabIndex = 0;
            // 
            // tabMusico
            // 
            this.tabMusico.Controls.Add(this.dgvMusico);
            this.tabMusico.Location = new System.Drawing.Point(4, 22);
            this.tabMusico.Name = "tabMusico";
            this.tabMusico.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusico.Size = new System.Drawing.Size(727, 317);
            this.tabMusico.TabIndex = 0;
            this.tabMusico.Text = "Musico";
            this.tabMusico.UseVisualStyleBackColor = true;
            // 
            // dgvMusico
            // 
            this.dgvMusico.AllowUserToAddRows = false;
            this.dgvMusico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeMusico,
            this.alterarMusico,
            this.deletarMusico});
            this.dgvMusico.Location = new System.Drawing.Point(7, 7);
            this.dgvMusico.Name = "dgvMusico";
            this.dgvMusico.Size = new System.Drawing.Size(714, 304);
            this.dgvMusico.TabIndex = 0;
            this.dgvMusico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusico_CellClick);
            // 
            // nomeMusico
            // 
            this.nomeMusico.FillWeight = 300F;
            this.nomeMusico.HeaderText = "Nome";
            this.nomeMusico.Name = "nomeMusico";
            this.nomeMusico.Width = 300;
            // 
            // alterarMusico
            // 
            this.alterarMusico.HeaderText = "Alterar";
            this.alterarMusico.Name = "alterarMusico";
            // 
            // deletarMusico
            // 
            this.deletarMusico.HeaderText = "Deletar";
            this.deletarMusico.Name = "deletarMusico";
            // 
            // tabBanda
            // 
            this.tabBanda.Controls.Add(this.dgvBanda);
            this.tabBanda.Location = new System.Drawing.Point(4, 22);
            this.tabBanda.Name = "tabBanda";
            this.tabBanda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBanda.Size = new System.Drawing.Size(727, 317);
            this.tabBanda.TabIndex = 1;
            this.tabBanda.Text = "Banda/Artista";
            this.tabBanda.UseVisualStyleBackColor = true;
            // 
            // dgvBanda
            // 
            this.dgvBanda.AllowUserToAddRows = false;
            this.dgvBanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2});
            this.dgvBanda.Location = new System.Drawing.Point(6, 6);
            this.dgvBanda.Name = "dgvBanda";
            this.dgvBanda.Size = new System.Drawing.Size(714, 304);
            this.dgvBanda.TabIndex = 1;
            this.dgvBanda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanda_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 300F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome Banda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Alterar";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Deletar";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // tabMusicas
            // 
            this.tabMusicas.Controls.Add(this.dgvMusicas);
            this.tabMusicas.Location = new System.Drawing.Point(4, 22);
            this.tabMusicas.Name = "tabMusicas";
            this.tabMusicas.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusicas.Size = new System.Drawing.Size(727, 317);
            this.tabMusicas.TabIndex = 2;
            this.tabMusicas.Text = "Musicas";
            this.tabMusicas.UseVisualStyleBackColor = true;
            // 
            // dgvMusicas
            // 
            this.dgvMusicas.AllowUserToAddRows = false;
            this.dgvMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewButtonColumn3,
            this.dataGridViewButtonColumn4});
            this.dgvMusicas.Location = new System.Drawing.Point(6, 6);
            this.dgvMusicas.Name = "dgvMusicas";
            this.dgvMusicas.Size = new System.Drawing.Size(714, 304);
            this.dgvMusicas.TabIndex = 1;
            this.dgvMusicas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusicas_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 300F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Alterar";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.HeaderText = "Deletar";
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            // 
            // tabAlbum
            // 
            this.tabAlbum.Controls.Add(this.dgvAlbum);
            this.tabAlbum.Location = new System.Drawing.Point(4, 22);
            this.tabAlbum.Name = "tabAlbum";
            this.tabAlbum.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlbum.Size = new System.Drawing.Size(727, 317);
            this.tabAlbum.TabIndex = 3;
            this.tabAlbum.Text = "Album";
            this.tabAlbum.UseVisualStyleBackColor = true;
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.AllowUserToAddRows = false;
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn5,
            this.dataGridViewButtonColumn6});
            this.dgvAlbum.Location = new System.Drawing.Point(6, 6);
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.Size = new System.Drawing.Size(714, 304);
            this.dgvAlbum.TabIndex = 1;
            this.dgvAlbum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbum_CellClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 300F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome Album";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewButtonColumn5
            // 
            this.dataGridViewButtonColumn5.HeaderText = "Alterar";
            this.dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            // 
            // dataGridViewButtonColumn6
            // 
            this.dataGridViewButtonColumn6.HeaderText = "Deletar";
            this.dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
            // 
            // Gerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 358);
            this.Controls.Add(this.tabGerenciar);
            this.Name = "Gerenciar";
            this.Text = "Gerenciar";
            this.Load += new System.EventHandler(this.Gerenciar_Load);
            this.tabGerenciar.ResumeLayout(false);
            this.tabMusico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusico)).EndInit();
            this.tabBanda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanda)).EndInit();
            this.tabMusicas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).EndInit();
            this.tabAlbum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGerenciar;
        private System.Windows.Forms.TabPage tabMusico;
        private System.Windows.Forms.TabPage tabBanda;
        private System.Windows.Forms.TabPage tabMusicas;
        private System.Windows.Forms.DataGridView dgvMusico;
        private System.Windows.Forms.TabPage tabAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeMusico;
        private System.Windows.Forms.DataGridViewButtonColumn alterarMusico;
        private System.Windows.Forms.DataGridViewButtonColumn deletarMusico;
        private System.Windows.Forms.DataGridView dgvBanda;
        private System.Windows.Forms.DataGridView dgvMusicas;
        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn6;
    }
}