using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Tarefa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void cbxBanda_Click(object sender, EventArgs e)
        {
            cbxBanda.Items.Clear();

            foreach (Banda banda in SalvaInfo.banda)
            {
                cbxBanda.Items.Add(banda.NomeBanda);
            }
        }

        private void cbxAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Album album in SalvaInfo.album)
            {
                dgvAlbum.Rows.Add(album.NomeAlbum);
            }
        }


        private void cbxBanda_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Album album in SalvaInfo.album)
            {
                dgvAlbum.Rows.Add(album.NomeAlbum);
            }
        }

        private void dgvAlbum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");
            WMPLib.IWMPMedia musica;

            foreach (Musicas musicas in SalvaInfo.album.ElementAt(e.RowIndex).Faixas)
            {
                lsbFaixas.Items.Add(musicas.Titulo);

                musica = axWindowsMediaPlayer1.newMedia(musicas.LocalMusica);
                playlist.appendItem(musica);

                lsbFaixas.SelectedIndex = 0;

            }
            
            //adiciona a playlist ao mediaPlaqyer
            axWindowsMediaPlayer1.currentPlaylist = playlist;

            //adiciona a capa do album na pictureBox
            picCapa.ImageLocation = SalvaInfo.album.ElementAt(e.RowIndex).Capa;
            picCapa.SizeMode = PictureBoxSizeMode.StretchImage;

            //mostra o nome do album na label
            lblNomeAlbum.Text = SalvaInfo.album.ElementAt(e.RowIndex).NomeAlbum;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        private void artistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerenciar gerenciar = new Gerenciar("tabMusico");
            gerenciar.ShowDialog();
        }

        private void bandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerenciar gerenciar = new Gerenciar("tabBanda");
            gerenciar.ShowDialog();
        }

        private void musicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gerenciar gerenciar = new Gerenciar("tabMusicas");
            gerenciar.ShowDialog();
        }

        private void albumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gerenciar gerenciar = new Gerenciar("tabAlbum");
            gerenciar.ShowDialog();
        }

        private void musicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar gerenciar = new Cadastrar("tabMusico");
            gerenciar.ShowDialog();
        }

        private void bandaArtistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar gerenciar = new Cadastrar("tabBanda");
            gerenciar.ShowDialog();
        }

        private void musicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar gerenciar = new Cadastrar("tabMusicas");
            gerenciar.ShowDialog();
        }

        private void albumToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cadastrar gerenciar = new Cadastrar("tabAlbum");
            gerenciar.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wmplayer.exe");
        }


    }
}
