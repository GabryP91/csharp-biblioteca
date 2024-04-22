using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito
    {

        //attributi
        private Utente utente;

        private Documento documento;

        private DateTime dal;

        private DateTime al;


        //metodi

        public Utente Utente
        {
            get { return utente; }
            set { utente = value; }
        }

        public Documento Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public DateTime Dal
        {
            get { return dal; }
            set { dal = value; }
        }

        public DateTime Al
        {
            get { return al; }
            set { al = value; }
        }

    }
}
