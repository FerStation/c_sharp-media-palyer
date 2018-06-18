using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa3
{
    public class Album
    {
        private string nomeBanda;

        public string NomeBanda
        {
            get { return nomeBanda; }
            set { nomeBanda = value; }
        }
        private string nomeAlbum;

        public string NomeAlbum
        {
            get { return nomeAlbum; }
            set { nomeAlbum = value; }
        }
        private string produtor;

        public string Produtor
        {
            get { return produtor; }
            set { produtor = value; }
        }
        private string gravadora;

        public string Gravadora
        {
            get { return gravadora; }
            set { gravadora = value; }
        }
        private List<Musicas> faixas;

        public List<Musicas> Faixas
        {
            get { return faixas; }
            set { faixas = value; }
        }

        private String capa;

        public String Capa
        {
            get { return capa; }
            set { capa = value; }
        }

        public Album(string nomeBanda, string nomeAlbum, string produtor, string gravadora, List<Musicas> faixas, String capa)
        {
            // TODO: Complete member initialization
            this.nomeBanda = nomeBanda;
            this.nomeAlbum = nomeAlbum;
            this.produtor = produtor;
            this.gravadora = gravadora;
            this.faixas = faixas;
            this.capa = capa;
        }

    }
}
