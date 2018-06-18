using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa3
{
    public partial class Gerenciar : Form
    {
        public Gerenciar(String nomeTab)
        {
            InitializeComponent();

            tabGerenciar.SelectTab(nomeTab);
            
        }

        private void Gerenciar_Load(object sender, EventArgs e)
        {
            //adiciona o musico no datagrid
            foreach(Musico musico in SalvaInfo.musico)
            {
                dgvMusico.Rows.Add(musico.Nome);
            }

            //adiciona todas as bandas no datagrid
            foreach (Banda banda in SalvaInfo.banda)
            {
                dgvBanda.Rows.Add(banda.NomeBanda);
            }

            //adiciona todas as musicas no datagrid
            foreach (Musicas musicas in SalvaInfo.musicas)
            {
                dgvMusicas.Rows.Add(musicas.Titulo);
            }

            //adiciona todos os albums no datagrid
            foreach (Album album in SalvaInfo.album)
            {
                dgvAlbum.Rows.Add(album.NomeBanda);
            }
        }

        private void dgvMusico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //abre o form para edição do cadastro
            if(e.ColumnIndex == 1)
            {
                Cadastrar musico = new Cadastrar(SalvaInfo.musico.ElementAt(e.RowIndex));
                musico.Show();
            }
            //remove a linha selecionada e também remove o objeto da list
            else if(e.ColumnIndex == 2)
            {
                SalvaInfo.musico.RemoveAt(e.RowIndex);
                dgvMusico.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvBanda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //abre o form para edição do cadastro
            if (e.ColumnIndex == 1)
            {
                Cadastrar banda = new Cadastrar(SalvaInfo.banda.ElementAt(e.RowIndex));
                banda.Show();
            }
            //remove a linha selecionada e também remove o objeto da list
            else if (e.ColumnIndex == 2)
            {
                SalvaInfo.banda.RemoveAt(e.RowIndex);
                dgvBanda.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvMusicas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //abre o form para edição do cadastro
            if (e.ColumnIndex == 1)
            {
                Cadastrar musicas = new Cadastrar(SalvaInfo.musicas.ElementAt(e.RowIndex));
                musicas.Show();
            }
            //remove a linha selecionada e também remove o objeto da list
            else if (e.ColumnIndex == 2)
            {
                SalvaInfo.musicas.RemoveAt(e.RowIndex);
                dgvMusicas.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvAlbum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //abre o form para edição do cadastro
            if (e.ColumnIndex == 1)
            {
                Cadastrar album = new Cadastrar(SalvaInfo.album.ElementAt(e.RowIndex));
                album.Show();
            }
            //remove a linha selecionada e também remove o objeto da list
            else if (e.ColumnIndex == 2)
            {
                SalvaInfo.album.RemoveAt(e.RowIndex);
                dgvAlbum.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
