using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa3
{
    public class Banda
    {
        private String nomeBanda;
        private String genero;
        private String nomeRestp;
        private String site;
        private String email;
        private String telefone;
        private List<Musico> integrantes;
        private String logo;

        public Banda(String nomeBanda,String genero,String nomeRestp, String site,String email,
            String telefone,List<Musico> integrantes, String logo)
        {
            this.nomeBanda = nomeBanda;
            this.genero = genero;
            this.nomeRestp = nomeRestp;
            this.site = site;
            this.email = email;
            this.telefone = telefone;
            this.integrantes = integrantes;
            this.logo = logo;
        }

        public String NomeBanda
        {
            get { return nomeBanda; }
            set { nomeBanda = value; }
        }

        public String Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public String NomeRestp
        {
            get { return nomeRestp; }
            set { nomeRestp = value; }
        }

        public String Site
        {
            get { return site; }
            set { site = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public List<Musico> Integrantes
        {
            get { return integrantes; }
            set { integrantes = value; }
        }


        public String Logo
        {
            get { return logo; }
            set { logo = value; }
        }

    }
}
