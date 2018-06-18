using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa3
{
    public class Musico
    {
        private string nome;
        private string nomeArtistico;
        private string rua;
        private string bairro;
        private string cidade;
        private string numero;
        private string cep;
        private string estado;
        private string email;
        private string celular;
        private List<String> profissao;
        private List<String> instrumento;
        private List<String> genero;
        private string foto;

        public Musico(string nome, string nomeArtistico,string rua,string bairro, string cidade,
            string numero,string cep,string estado, string email,string celular, List<string> profissao,
            List<string> instrumento, List<string> genero, string foto)
        {
            this.nome = nome;
            this.nomeArtistico = nomeArtistico;
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
            this.numero = numero;
            this.cep = cep;
            this.estado = estado;
            this.email = email;
            this.celular = celular;
            this.profissao = profissao;
            this.instrumento = instrumento;
            this.genero = genero;
            this.foto = foto;

        }

        public Musico(string nome)
        {
            this.nome = nome;
        }

        public Musico()
        {
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string NomeArtistico
        {
            get { return nomeArtistico; }
            set { nomeArtistico = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public List<String> Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }


        public List<String> Instrumento
        {
            get { return instrumento; }
            set { instrumento = value; }
        }

        public List<String> Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }
    }
}
