using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documento
    {

        //attributi
        private string id_code;

        private string titolo;

        private int anno;

        private string settore;

        private string scaffale;

        private Autore autore;

        //metodi
        public string Id_code
        {
            get { return id_code; }
            set { id_code = value; }
        }
        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }
        public int Anno
        {
            get { return anno; }
            set { anno = value; }
        }
        public string Settore
        {
            get { return settore; }
            set { settore = value; }
        }
        public string Scaffale
        {
            get { return scaffale; }
            set { scaffale = value; }
        }

        public Autore Autore
        {
            get { return autore; }
            set { autore = value; }
        }
    }
}
