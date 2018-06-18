using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa3
{
    public class Musicas
    {
        private String nomeBanda;
        private String titulo;
        private String compositor;
        private String localMusica;
        private List<Musico> integrantes;

        public Musicas(String nomeBanda, String titulo,
        String compositor, String localMusica, List<Musico> integrantes)
        {
            this.nomeBanda = nomeBanda;
            this.titulo = titulo;
            this.compositor = compositor;
            this.localMusica = localMusica;
            this.integrantes = integrantes;
        }

        public String NomeBanda
        {
            get { return nomeBanda; }
            set { nomeBanda = value; }
        }

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public String Compositor
        {
            get { return compositor; }
            set { compositor = value; }
        }

        public String LocalMusica
        {
            get { return localMusica; }
            set { localMusica = value; }
        }

        public List<Musico> Integrantes
        {
            get { return integrantes; }
            set { integrantes = value; }
        }
    }
}
