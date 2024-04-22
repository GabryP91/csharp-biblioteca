using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente
    {
        //attributi
        private string nome;

        private string cognome;

        private string email;

        private string password;

        private string recapTel;

        //metodi
        public string Nome
        {
            get { return nome; }
            set {  nome = value; }
        }

        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string RecapTel
        {
            get { return recapTel; }
            set { recapTel = value; }
        }

    }
}
