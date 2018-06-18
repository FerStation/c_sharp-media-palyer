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
    public partial class Cadastrar : Form
    {
        //vetor com as profissoes
        private string[] profissoes = { "Arranjador","Compositor","DJ","Edição","Maestro","Músico","Produtor musical"};

        //vetor com os instrumentos
        private string[] instrumento = { "Acordeão","Baixo acústico","Baixo elétrico","Bandolim","Bateria",
            "Cavaquinho","Clarineta","Flauta doce","Flauta transversal",
            "Gaita","Guitarra","Órgão","Percussão","Piano","Saxofone",
            "Teclado","Trombone","Trompa","Trompete","Tuba","Viola",
            "Viola caipira","Violão","Violino","Violoncelo","Voz"};

        //vetro com os generos
        private string[] arrayGenero = { "Acid house","Ambient","Alternativa","Baião","Blues","Bolero","Bossa nova","Brega","Caipira",
            "Choro","Coral","Folk","Forró","Hardcore","Heavy metal","Hip-Hop","Jazz","Lambada",
            "Latin jazz/World fusion","Mambo","Metal","Música clássica","Ópera","Pagode",
            "Partido Alto","Pop rock","Punk","Rap","Reggae","Rock","Rock alternativo",
            "Rock progressivo","Salsa","Samba","Sertanejo","Tango"};

        //Lista com as profissões do musico
        private List<String> listProfissao = new List<String>();

        //lista com o instrumento do musico
        private List<String> listIntrumento = new List<string>();

        //lista com os generos
        private List<String> listGenero = new List<string>();

        //lista com os integrantes da banda
        private List<Musico> listIntegrantesBanda = new List<Musico>();

        //lista com as faixas do album
        private List<Musicas> listFaixas = new List<Musicas>();

        //lista aas musicas da banda
        private List<Musicas> listMusicasBanda = new List<Musicas>();

        //declaração dos objetos
        private Musico musico;
        private Banda banda;
        private Musicas musicas;
        private Album album;

        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Cadastrar(String nomeTab)
        {
            InitializeComponent();

            //limpa os campos
            limpar();

            //desabilita os campos
            desabilitaCampos();

            tabGerenciar.SelectTab(nomeTab);
            
        }

        /// <summary>
        /// Construtor Musico
        /// </summary>
        /// <param name="musico">musico que será alterado</param>
        public Cadastrar(Musico musico)
        {
            InitializeComponent();

            //configurações para alterar
            btnSalvar.Text = "Alterar";
            this.Text = "Alterar";
            this.musico = musico;

            //altera os valores
            cbxEstado.SelectedItem = musico.Estado;
            txtNomeMusico.Text = musico.Nome;
            txtNomeArt.Text = musico.NomeArtistico;
            txtRua.Text = musico.Rua;
            txtBairro.Text = musico.Bairro;
            txtCidade.Text = musico.Cidade;
            txtNumero.Text = musico.Numero;
            txtCep.Text = musico.Cep;
            txtEmail.Text = musico.Email;
            txtCelular.Text = musico.Celular;

            //adiciona a imagem
            picFotoMusico.ImageLocation = musico.Foto;
            picFotoMusico.SizeMode = PictureBoxSizeMode.StretchImage;

            //abre a tabMusico
            tabGerenciar.SelectTab("tabMusico");

            //percorre os vetrores para adicionar, a profissão, o instrumento e o genero do musico, que
            //já estão cadastrados
            foreach(String profissao in musico.Profissao)
            {
                listProfissao.Add(profissao);
                dgvProfissoes.Rows.Add(profissao, Properties.Resources.icon_trash2);
            }

            foreach (String instrumento in musico.Instrumento)
            {
                listIntrumento.Add(instrumento);
                dgvInstrumento.Rows.Add(instrumento, Properties.Resources.icon_trash2);
            }

            foreach (String genero in musico.Genero)
            {
                listGenero.Add(genero);
                dgvGenero.Rows.Add(genero, Properties.Resources.icon_trash2);
            }
        }


        /// <summary>
        /// Construtor banda
        /// </summary>
        /// <param name="banda">banda que será alterada</param>
        public Cadastrar(Banda banda)
        {
            InitializeComponent();

            //altera o texto do botão salvar
            btnSalvar.Text = "Alterar";
            this.Text = "Alterar";
            this.banda = banda;

            cbxGeneroBanda.SelectedItem = banda.Genero;
            txtNomeBanda.Text = banda.NomeBanda;
            txtNomeResp.Text = banda.NomeRestp;
            txtSite.Text = banda.Site;
            txtEmailBanda.Text = banda.Email;
            txtTelBanda.Text = banda.Telefone;

            picLogo.ImageLocation = banda.Logo;
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            tabGerenciar.SelectTab("tabBanda");

            //percorre o vetor para adicionar os integrantes da banda, ja cadastrados
            foreach (Musico musico in banda.Integrantes)
            {
                listIntegrantesBanda.Add(musico);
                //dgvIntegrantesBanda.Rows.Add(musico, Properties.Resources.icon_trash2);
                dgvIntegrantesBanda.Rows.Add(musico.Nome);
            }
        }

        /// <summary>
        /// Construtor Musicas
        /// </summary>
        /// <param name="musicas">musica que será alterada</param>
        public Cadastrar(Musicas musicas)
        {
            InitializeComponent();

            //altera o texto do botão salvar
            btnSalvar.Text = "Alterar";
            this.Text = "Alterar";
            this.musicas = musicas;

            cbxBandaMusica.SelectedItem = musicas.NomeBanda;
            txtNomeMusica.Text = musicas.Titulo;
            txtCompositor.Text = musicas.Compositor;
            txtLocalMusica.Text = musicas.LocalMusica;

            tabGerenciar.SelectTab("tabMusicas");

            //percorre o vetor para adicionar os integrantes da musica, que
            //já estão cadastrados
            foreach(Musico integrantes in musicas.Integrantes)
            {
                listIntegrantesBanda.Add(integrantes);
                dgvIntegrantesMusica.Rows.Add(integrantes.Nome);
            }

        }

        /// <summary>
        /// Construtor album
        /// </summary>
        /// <param name="album">album que será alterado</param>
        public Cadastrar(Album album)
        {
            InitializeComponent();

            //altera o texto do botão salvar
            btnSalvar.Text = "Alterar";
            this.Text = "Alterar";
            this.album = album;

            cbxBandaAlbum.SelectedItem = album.NomeBanda;
            txtNomeAlbum.Text = album.NomeAlbum;
            txtProdutor.Text = album.Produtor;
            txtGravadora.Text = album.Gravadora;
            picCapa.ImageLocation = album.Capa;

            tabGerenciar.SelectTab("tabAlbum");

            //percorre o vetro para adicionar as musicas já cadastradas
            foreach(Musicas musica in album.Faixas)
            {
                listMusicasBanda.Add(musica);
                dgvFaixas.Rows.Add(musica.Titulo, Properties.Resources.icon_trash2);
            }
        }

        /// <summary>
        /// Método Responsavel por limpar todos os campos
        /// </summary>
        public void limpar()
        {

            //limpa as Listas
            listProfissao.Clear();
            listIntrumento.Clear();
            listGenero.Clear();

            //============Limpa campos do musico=================

            //limpa as comboBox
            cbxProfissao.SelectedItem = null;
            cbxInstrumento.SelectedItem = null;
            cbxGenero.SelectedItem = null;
            cbxEstado.SelectedItem = null;


            //limpa as textBox
            txtNomeMusico.Text = "";
            txtNomeArt.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtNumero.Text = "";
            txtCep.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            txtCelular.Text = "";

            //limpa os DataGrid
            dgvProfissoes.Rows.Clear();
            dgvInstrumento.Rows.Clear();
            dgvGenero.Rows.Clear();

            //============Limpa campos da banda=================
            
            //limpa as comboBox
            cbxGeneroBanda.SelectedItem = null;

            //limpa as textBox
            txtNomeBanda.Text = "";
            txtNomeResp.Text = "";
            txtSite.Text = "";
            txtEmail.Text = "";
            txtTelBanda.Text = "";
            txtEmailBanda.Text = "";

            //============Limpa campos da musica=================
            //limpa a comboBox
            cbxBandaMusica.SelectedItem = "";

            //limpa as textBox
            txtNomeMusica.Text = "";
            txtCompositor.Text = "";
            txtLocalMusica.Text = "";

            //============Limpa campos do album=================
            //limpa a comboBox
            cbxBandaAlbum.SelectedItem = "";

            //limpa as textBox
            txtNomeAlbum.Text = "";
            txtProdutor.Text = "";
            txtGravadora.Text ="";

        }

        /// <summary>
        /// Método responsavel por desabilitar os campos
        /// </summary>
        private void desabilitaCampos()
        {
            //=======desabilita os campos do musico====================

            //desabilita as comboBox
            cbxProfissao.Enabled = false;
            cbxInstrumento.Enabled = false;
            cbxGenero.Enabled = false;
            cbxEstado.Enabled = false;


            //desabilita as textBox
            txtNomeMusico.Enabled = false;
            txtNomeArt.Enabled = false;
            txtRua.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            txtCep.Enabled = false;
            txtEmail.Enabled = false;
            txtTel.Enabled = false;
            txtCelular.Enabled = false;

            //desabilita os botoes
            btnImgMusico.Enabled = false;
            btnDelImgMusico.Enabled = false;
            btnProfissoes.Enabled = false;
            btnInstrumento.Enabled = false;
            btnGenero.Enabled = false;

            //============Desabilita campos da banda=================
            cbxIntegranteBanda.Enabled = false;
            cbxGeneroBanda.Enabled = false;

            txtNomeBanda.Enabled = false;
            txtNomeResp.Enabled = false;
            txtSite.Enabled = false;
            txtEmail.Enabled = false;
            txtTelBanda.Enabled = false;
            txtEmailBanda.Enabled = false;

            btnImgBanda.Enabled = false;
            btnDelImgBanda.Enabled = false;
            btnIntegranteBanda.Enabled = false;

            //============Desabilita campos da musica=================
            cbxBandaMusica.Enabled = false;
            cbxIntegranteMusica.Enabled = false;

            txtNomeMusica.Enabled = false;
            txtCompositor.Enabled = false;
            txtLocalMusica.Enabled = false;

            btnProcurarMusica.Enabled = false;
            btnProcurarIntegrante.Enabled = false;

            //============Desabilita campos do album=================
            cbxBandaAlbum.Enabled = false;
            cbxMusicaAlbum.Enabled = false;

            txtNomeAlbum.Enabled = false;
            txtProdutor.Enabled = false;
            txtGravadora.Enabled = false;

            btnImgAlbum.Enabled = false;
            btnDelImgAlbum.Enabled = false;
            btnProcurarMusicaAlbum.Enabled = false;


        }

        /// <summary>
        /// Método responsavel por habilitar os campos
        /// </summary>
        private void habilitaCampos()
        {
            //=======habilia os campos do musico====================

            //desabilita as comboBox
            cbxProfissao.Enabled = true;
            cbxInstrumento.Enabled = true;
            cbxGenero.Enabled = true;
            cbxEstado.Enabled = true;


            //desabilita as textBox
            txtNomeMusico.Enabled = true;
            txtNomeArt.Enabled = true;
            txtRua.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtCep.Enabled = true;
            txtEmail.Enabled = true;
            txtTel.Enabled = true;
            txtCelular.Enabled = true;

            //desabilita os botoes
            btnImgMusico.Enabled = true;
            btnDelImgMusico.Enabled = true;
            btnProfissoes.Enabled = true;
            btnInstrumento.Enabled = true;
            btnGenero.Enabled = true;

            //============Habilita campos da banda=================
            cbxIntegranteBanda.Enabled = true;
            cbxGeneroBanda.Enabled = true;

            txtNomeBanda.Enabled = true;
            txtNomeResp.Enabled = true;
            txtSite.Enabled = true;
            txtEmail.Enabled = true;
            txtTelBanda.Enabled = true;
            txtEmailBanda.Enabled = true;

            btnImgBanda.Enabled = true;
            btnDelImgBanda.Enabled = true;
            btnIntegranteBanda.Enabled = true;

            //============Habilita campos da musica=================
            cbxBandaMusica.Enabled = true;
            cbxIntegranteMusica.Enabled = true;

            txtNomeMusica.Enabled = true;
            txtCompositor.Enabled = true;
            txtLocalMusica.Enabled = true;

            btnProcurarMusica.Enabled = true;
            btnProcurarIntegrante.Enabled = true;

            //============Habilita campos do album=================
            cbxBandaAlbum.Enabled = true;
            cbxMusicaAlbum.Enabled = true;

            txtNomeAlbum.Enabled = true;
            txtProdutor.Enabled = true;
            txtGravadora.Enabled = true;

            btnImgAlbum.Enabled = true;
            btnDelImgAlbum.Enabled = true;
            btnProcurarMusicaAlbum.Enabled = true;
        }

        private List<String> dadosMusico(int index)
        {
            List<String> dadosMusico = new List<String>();

            String profissaoMusico = null;
            String instrumentoMusico = null;
            String generoMusico = null;

            //percorre o vetro profissoes
            foreach (String profissao in SalvaInfo.musico.ElementAt(index).Profissao)
            {
                profissaoMusico += profissao + "/";
            }

            //percoore o vetor instrumento
            foreach (String instrumento in SalvaInfo.musico.ElementAt(index).Instrumento)
            {
                instrumentoMusico += instrumento + "/";
            }

            //percoore o vetor genero
            foreach (String genero in SalvaInfo.musico.ElementAt(index).Genero)
            {
                generoMusico += genero + "/";
            }

            //remove o ultimo caracter da String
            profissaoMusico = profissaoMusico.Remove(profissaoMusico.Length - 1);
            instrumentoMusico = instrumentoMusico.Remove(instrumentoMusico.Length - 1);
            generoMusico = generoMusico.Remove(generoMusico.Length - 1);

            dadosMusico.Add(profissaoMusico);
            dadosMusico.Add(instrumentoMusico);
            dadosMusico.Add(generoMusico);

            return dadosMusico;

        }

        private void cancelarOperacao()
        {
            //limpa os campos
            limpar();

            //desabilita os campos
            desabilitaCampos();

            //desabilita os botões
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = true;
        }

        /// <summary>
        /// Evento Load, esse evento é responsavel por popular as comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gerenciar_Load(object sender, EventArgs e)
        {
            //adicone os vetores em suas respctivas comboBox
            //cbxEstado.Items.AddRange(estados);
            cbxProfissao.Items.AddRange(profissoes);
            cbxInstrumento.Items.AddRange(instrumento);
            cbxGenero.Items.AddRange(arrayGenero);
            cbxGeneroBanda.Items.AddRange(arrayGenero);

        }

        /// <summary>
        /// Esse Evento é responsavel por abrir um arquivo de audio e de inicia-lo no media player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcurarMusica_Click(object sender, EventArgs e)
        {
            //declaração das variaveis
            string nomeArquivo;
            string diretorioArquivo;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 (*.mp3)|*.mp3|WMA|*.wma"; //Definindo o filtro (extensões dos vídeos pelos quais o OpenFileDialog buscará).

            //abre o arquivo
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //captura o arquivo
                System.IO.FileInfo arquivo = new System.IO.FileInfo(ofd.FileName);

                //captura o nom do aqruivo
                nomeArquivo = arquivo.Name;

                //captura o diretorio do arquivo
                diretorioArquivo = arquivo.DirectoryName;

                //adiciona o diretorio + o nome do arquivo na textBox
                txtLocalMusica.Text = diretorioArquivo + "\\" + nomeArquivo;

                //adiciona a musica ao media player e da um stop na musica
                axWindowsMediaPlayer1.URL = txtLocalMusica.Text;
                axWindowsMediaPlayer1.Ctlcontrols.stop();

            }//fim do if

        }

        /// <summary>
        /// Evento responsavel por adicionar a foto do musico na pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImgMusico_Click(object sender, EventArgs e)
        {
            //abre a janela de busca com o filtro ativado para arquivos jpg e png
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.Filter = "jpg|*.jpg|png|*.png";

            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                //adiciona a imagem
                picFotoMusico.ImageLocation = arquivo.FileName;
                picFotoMusico.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        /// <summary>
        /// Evento que volta a imagemn original do Musico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelImgMusico_Click(object sender, EventArgs e)
        {
            picFotoMusico.Image = Properties.Resources.icon_user;
            picFotoMusico.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        /// <summary>
        /// Esse Evento adicona a profissão selecionada na comboBox no dataGrid e
        /// também adiciona a proffisão na lista: listProfissao
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfissoes_Click(object sender, EventArgs e)
        {

            if(cbxProfissao.SelectedItem != null)
            {
                dgvProfissoes.Rows.Add(cbxProfissao.SelectedItem, Properties.Resources.icon_trash2);
                listProfissao.Add(cbxProfissao.SelectedItem.ToString());
            }
        }

        private void btnInstrumento_Click(object sender, EventArgs e)
        {
            if (cbxInstrumento.SelectedItem != null)
            {
                dgvInstrumento.Rows.Add(cbxInstrumento.SelectedItem, Properties.Resources.icon_trash2);
                listIntrumento.Add(cbxInstrumento.SelectedItem.ToString());

            }
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            if (cbxGenero.SelectedItem != null)
            {
                dgvGenero.Rows.Add(cbxGenero.SelectedItem, Properties.Resources.icon_trash2);
                listGenero.Add(cbxGenero.SelectedItem.ToString());

            }
        }

        private void tabGerenciar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //adiciona todos os integrantes cadastrados na comobo INtegrantres
            if(tabGerenciar.SelectedTab == tabGerenciar.TabPages["tabBanda"])
            {
                //limpa a camboBox
                cbxIntegranteBanda.Items.Clear();

                //adiciona os musicos na comboBox
                foreach (Musico musico in SalvaInfo.musico)
                {
                    cbxIntegranteBanda.Items.Add(musico.Nome);
                }
            }

            else if (tabGerenciar.SelectedTab == tabGerenciar.TabPages["tabMusicas"])
            {
                //limpa a camboBox
                cbxBandaMusica.Items.Clear();

                //adiciona os musicos na comboBox
                foreach (Banda banda in SalvaInfo.banda)
                {
                    cbxBandaMusica.Items.Add(banda.NomeBanda);
                }
            }
            else if (tabGerenciar.SelectedTab == tabGerenciar.TabPages["tabAlbum"])
            {
                //limpa a camboBox
                cbxBandaAlbum.Items.Clear();

                //adiciona os musicos na comboBox
                foreach (Banda banda in SalvaInfo.banda)
                {
                    cbxBandaAlbum.Items.Add(banda.NomeBanda);
                }
            }
        }

        private void btnIntegranteBanda_Click(object sender, EventArgs e)
        {
            //adiciona as informaçoes do musico selecionado no dataGridView
            dgvIntegrantesBanda.Rows.Add(SalvaInfo.musico.ElementAt(cbxIntegranteBanda.SelectedIndex).Nome,
                dadosMusico(cbxIntegranteBanda.SelectedIndex).ElementAt(0),
                dadosMusico(cbxIntegranteBanda.SelectedIndex).ElementAt(1),
                dadosMusico(cbxIntegranteBanda.SelectedIndex).ElementAt(2), "|||");

            listIntegrantesBanda.Add(SalvaInfo.musico.ElementAt(cbxIntegranteBanda.SelectedIndex));
        }

        private void dgvProfissoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                DialogResult msg = MessageBox.Show("Deseja realmente Deletar esse item?","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(msg == DialogResult.Yes)
                {
                    listProfissao.RemoveAt(e.RowIndex);
                    dgvProfissoes.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dgvInstrumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                DialogResult msg = MessageBox.Show("Deseja realmente Deletar esse item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    listIntrumento.RemoveAt(e.RowIndex);
                    dgvInstrumento.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dgvGenero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                DialogResult msg = MessageBox.Show("Deseja realmente Deletar esse item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    listGenero.RemoveAt(e.RowIndex);
                    dgvGenero.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dgvIntegrantesBanda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DialogResult msg = MessageBox.Show("Deseja realmente Deletar esse item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    listIntegrantesBanda.RemoveAt(e.RowIndex);
                    dgvIntegrantesBanda.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void cbxBandaMusica_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvIntegrantesMusica.Rows.Clear();
            listIntegrantesBanda.Clear();
            cbxIntegranteMusica.Items.Clear();

            //adiciona os musicos na da banda selecionada no DataGrid
            foreach (Musico integrantes in SalvaInfo.banda.ElementAt(cbxBandaMusica.SelectedIndex).Integrantes)
            {
                dgvIntegrantesMusica.Rows.Add(integrantes.Nome,
                    dadosMusico(cbxBandaMusica.SelectedIndex).ElementAt(0),
                    dadosMusico(cbxBandaMusica.SelectedIndex).ElementAt(1),
                    dadosMusico(cbxBandaMusica.SelectedIndex).ElementAt(2));
                listIntegrantesBanda.Add(integrantes);

            }

            //adiciona todos os musicos na combo-box
            foreach (Musico musico in SalvaInfo.musico)
            {
                cbxIntegranteMusica.Items.Add(musico.Nome);
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if(btnSalvar.Text == "Salvar")
            {
                //Salva o musico
                if (tabGerenciar.SelectedTab == tabGerenciar.TabPages["tabMusico"])
                {
                    //valida campos
                    if (txtNomeMusico.Text != "" && txtNomeArt.Text != "" &&
                        txtRua.Text != "" && txtBairro.Text != "" &&
                        txtCidade.Text != "" && txtNumero.Text != "" &&
                        txtCep.Text != "" && txtEmail.Text != "" &&
                        txtTel.Text != "" && txtCelular.Text != "" &&
                        dgvProfissoes.Rows.Count > 0 && dgvInstrumento.Rows.Count > 0 &&
                        dgvGenero.Rows.Count > 0 && cbxEstado.SelectedItem != null)
                    {
                        //objeto da classe musico
                        Musico musico = new Musico(txtNomeMusico.Text, txtNomeArt.Text,
                        txtRua.Text, txtBairro.Text, txtCidade.Text, txtNumero.Text, txtCep.Text,
                        cbxEstado.SelectedItem.ToString(), txtEmail.Text, txtCelular.Text, new List<String>(listProfissao), new List<String>(listIntrumento), new List<String>(listGenero), picFotoMusico.ImageLocation);

                        //salva o musico
                        SalvaInfo.musico.Add(musico);

                        //exibe a menssagem que tudo ocorreu corretamnte
                        MessageBox.Show("Musico: " + txtNomeMusico.Text + " castrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //desabilita os botoes
                        cancelarOperacao();

                        //adicona o foco no botão novo
                        btnNovo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Por favor preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                //salva a banda
                else if (tabGerenciar.SelectedTab == tabGerenciar.TabPages["tabBanda"])
                {
                    if(txtNomeBanda.Text != "" &&
                        cbxGeneroBanda.SelectedItem != null &&
                        txtNomeResp.Text != "" &&
                        txtSite.Text != "" &&
                        txtEmailBanda.Text != "" &&
                        txtTelBanda.Text != "")
                    {
                        Banda banda = new Banda(txtNomeBanda.Text, cbxGeneroBanda.SelectedItem.ToString(), txtNomeResp.Text, txtSite.Text, txtEmailBanda.Text, txtTelBanda.Text, new List<Musico>(listIntegrantesBanda), picLogo.ImageLocation);
                        SalvaInfo.banda.Add(banda);

                        //exibe a menssagem que tudo ocorreu corretamnte
                        MessageBox.Show("Banda: " + txtNomeBanda.Text + " castrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //desabilita os botoes
                        cancelarOperacao();

                        //adicona o foco no botão novo
                        btnNovo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Por favor preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                //salva musicas
                else if (tabGerenciar.SelectedTab == tabGerenciar.TabPages["tabMusicas"])
                {
                    if(cbxBandaMusica.SelectedItem != null &&
                        txtNomeMusica.Text != "" &&
                        txtCompositor.Text != "" &&
                        txtLocalMusica.Text != "")
                    {
                        Musicas musicas = new Musicas(cbxBandaMusica.SelectedItem.ToString(), txtNomeMusica.Text, txtCompositor.Text, txtLocalMusica.Text, new List<Musico>(listIntegrantesBanda));

                        SalvaInfo.musicas.Add(musicas);
                        listIntegrantesBanda.Clear();

                         //exibe a menssagem que tudo ocorreu corretamnte
                        MessageBox.Show("Musica: " + txtNomeMusica.Text + " castrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //desabilita os botoes
                        cancelarOperacao();

                        //adicona o foco no botão novo
                        btnNovo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Por favor preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                }
                //salva album
                else if (tabGerenciar.SelectedTab == tabGerenciar.TabPages["tabAlbum"])
                {
                    if(cbxBandaAlbum.SelectedItem != null &&
                        txtNomeAlbum.Text != "" &&
                        txtProdutor.Text != "" &&
                        txtGravadora.Text != "")
                    {
                        Album album = new Album(cbxBandaAlbum.SelectedItem.ToString(), txtNomeAlbum.Text, txtProdutor.Text, txtGravadora.Text, new List<Musicas>(listFaixas), picCapa.ImageLocation);

                        SalvaInfo.album.Add(album);
                        listFaixas.Clear();

                        //exibe a menssagem que tudo ocorreu corretamnte
                        MessageBox.Show("Album: " + txtNomeAlbum.Text + " cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //desabilita os botoes
                        cancelarOperacao();

                        //adicona o foco no botão novo
                        btnNovo.Focus();
                    }
                    
                    else
                    {
                        MessageBox.Show("Por favor preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else if(btnSalvar.Text == "Alterar")
            {
                if(tabGerenciar.SelectedTab == tabGerenciar.TabPages["tabMusico"])
                {
                    musico.Nome = txtNomeMusico.Text;
                    musico.NomeArtistico = txtNomeArt.Text;
                    musico.Rua = txtRua.Text;
                    musico.Bairro = txtBairro.Text;
                    musico.Cidade = txtCidade.Text;
                    musico.Numero = txtNumero.Text;
                    musico.Cep = txtCep.Text;
                    musico.Estado = cbxEstado.SelectedItem.ToString();
                    musico.Email = txtEmail.Text;
                    musico.Celular = txtCelular.Text;
                    musico.Profissao =  new List<String>(listProfissao);
                    musico.Instrumento = new List<String>(listIntrumento);
                    musico.Genero = new List<String>(listGenero);
                    musico.Foto = picFotoMusico.ImageLocation;
                }
                //altera a banda
                else if (tabGerenciar.SelectedTab == tabGerenciar.TabPages["tabBanda"])
                {
                    banda.NomeBanda = txtNomeBanda.Text;
                    banda.Genero = cbxGeneroBanda.Text;
                    banda.NomeRestp = txtNomeResp.Text;
                    banda.Site = txtSite.Text;
                    banda.Email = txtEmail.Text;
                    banda.Telefone = txtTel.Text;
                    banda.Integrantes = new List<Musico>(listIntegrantesBanda);
                    banda.Logo = picLogo.ImageLocation;

                }
                //altera musicas
                else if (tabGerenciar.SelectedTab == tabGerenciar.TabPages["tabMusicas"])
                {
                    musicas.NomeBanda = cbxBandaMusica.SelectedItem.ToString();
                    musicas.Titulo = txtNomeMusica.Text;
                    musicas.Compositor = txtCompositor.Text;
                    musicas.LocalMusica = txtLocalMusica.Text;
                    musicas.Integrantes = new List<Musico>(listIntegrantesBanda);

                }
                //altera album
                else if (tabGerenciar.SelectedTab == tabGerenciar.TabPages["tabAlbum"])
                {
                    album.NomeBanda = cbxBandaAlbum.SelectedItem.ToString();
                    album.NomeAlbum = txtNomeAlbum.Text;
                    album.Produtor = txtProdutor.Text;
                    album.Gravadora = txtGravadora.Text;
                    album.Faixas = new List<Musicas>(listFaixas);
                    album.Capa = picCapa.ImageLocation;
                }

                MessageBox.Show("Alteração efetuada com sucesso!");
                cancelarOperacao();
                btnSalvar.Text = "Salvar";
                this.Text = "Cadastro";
                
            }
            
        }

        private void btnProcurarIntegrante_Click(object sender, EventArgs e)
        {
            String profissaoMusico = null;
            String instrumentoMusico = null;
            String generoMusico = null;

            //percorre o vetro profissoes
            foreach (String profissao in SalvaInfo.musico.ElementAt(cbxIntegranteMusica.SelectedIndex).Profissao)
            {
                profissaoMusico += profissao + "/";
            }

            //percoore o vetor instrumento
            foreach (String instrumento in SalvaInfo.musico.ElementAt(cbxIntegranteMusica.SelectedIndex).Instrumento)
            {
                instrumentoMusico += instrumento + "/";
            }

            //percoore o vetor genero
            foreach (String genero in SalvaInfo.musico.ElementAt(cbxIntegranteMusica.SelectedIndex).Genero)
            {
                generoMusico += genero + "/";
            }

            //remove o ultimo caracter da String
            profissaoMusico = profissaoMusico.Remove(profissaoMusico.Length - 1);
            instrumentoMusico = instrumentoMusico.Remove(instrumentoMusico.Length - 1);
            generoMusico = generoMusico.Remove(generoMusico.Length - 1);

            //adiciona as informaçoes do musico selecionado no dataGridView
            dgvIntegrantesMusica.Rows.Add(SalvaInfo.musico.ElementAt(cbxIntegranteMusica.SelectedIndex).Nome,
                profissaoMusico, instrumentoMusico, generoMusico, "|||");

            listIntegrantesBanda.Add(SalvaInfo.musico.ElementAt(cbxIntegranteMusica.SelectedIndex));
        }

        private void cbxBandaAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMusicaAlbum.Items.Clear();
            listMusicasBanda.Clear();
            dgvFaixas.Rows.Clear();

            foreach (Musicas musicas in SalvaInfo.musicas)
            {
                if(musicas.NomeBanda.Equals(cbxBandaAlbum.SelectedItem.ToString()))
                {
                    cbxMusicaAlbum.Items.Add(musicas.Titulo);
                    listMusicasBanda.Add(musicas);
                }
            }
        }

        private void btnProcurarMusicaAlbum_Click(object sender, EventArgs e)
        {
            dgvFaixas.Rows.Add(listMusicasBanda.ElementAt(cbxMusicaAlbum.SelectedIndex).Titulo, "|||");
            listFaixas.Add(listMusicasBanda.ElementAt(cbxMusicaAlbum.SelectedIndex));
        }

        private void btnImgBanda_Click(object sender, EventArgs e)
        {
            //abre a janela de busca com o filtro ativado para arquivos jpg e png
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.Filter = "jpg|*.jpg|png|*.png";

            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                //adiciona a imagem
                picLogo.ImageLocation = arquivo.FileName;
                picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnDelImgBanda_Click(object sender, EventArgs e)
        {
            picLogo.Image = Properties.Resources.icon_festival_512px_GREY;
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnImgAlbum_Click(object sender, EventArgs e)
        {
            //abre a janela de busca com o filtro ativado para arquivos jpg e png
            OpenFileDialog arquivo = new OpenFileDialog();
            arquivo.Filter = "jpg|*.jpg|png|*.png";

            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                //adiciona a imagem
                picCapa.ImageLocation = arquivo.FileName;
                picCapa.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnDelImgAlbum_Click(object sender, EventArgs e)
        {
            picCapa.Image = Properties.Resources.icon_album_cd;
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
            
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpa os campos
            limpar();

            //limpa as imagens
            btnDelImgMusico_Click(sender, e);
            btnDelImgBanda_Click(sender, e);
            btnDelImgAlbum_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult msg = MessageBox.Show("Todos os dados inseridos nessa cadastro serão perdidos\n Deseja realmente continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes && btnNovo.Enabled == false)
            {
                cancelarOperacao();
            }
        }

        private void dgvIntegrantesMusica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                DialogResult msg = MessageBox.Show("Deseja realmente Deletar esse item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    listIntegrantesBanda.RemoveAt(e.RowIndex);
                    dgvIntegrantesMusica.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dgvFaixas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                DialogResult msg = MessageBox.Show("Deseja realmente Deletar esse item?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msg == DialogResult.Yes)
                {
                    listFaixas.RemoveAt(e.RowIndex);
                    dgvFaixas.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

    }
}
