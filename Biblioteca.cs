using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        //attributi

        private List<Documento> documenti = new List<Documento>();
        private List<Utente> utenti = new List<Utente>();
        private List<Prestito> prestiti = new List<Prestito>();




        //metodi (set)
        public void AggiungiDocumento(Documento documento)
        {
            this.documenti.Add(documento);
        }

        public void AggiungiUtente(Utente utente)
        {
            this.utenti.Add(utente);
        }

        public void RegistraPrestito(Utente utente, Documento documento, DateTime dal, DateTime al)
        {
            prestiti.Add(new Prestito
            {
                Utente = utente,
                Documento = documento,
                Dal = dal,
                Al = al
            });
        }

        //metodi (get)
        public List<Documento> CercaDocumentiPerCodice(string codice)
        {
            //recuperami tutti i documenti che presentano il codice ID uguale a quello passato. (con funzione lambda)
            return this.documenti.FindAll(doc => doc.Id_code == codice);
        }

        public List<Documento> CercaDocumentiPerTitolo(string titolo)
        {
            //restituisce una lista di tutti i documenti il cui titolo contiene la stringa specificata. (con funzione lambda)
            return this.documenti.FindAll(doc => doc.Titolo.Contains(titolo));
        }

        public List<Prestito> CercaPrestitiPerUtente(string nome, string cognome)
        {
            //restituisce una lista di tutti i prestiti effettuati da una specifica persona. (con funzione lambda)
            return this.prestiti.FindAll(prestito => prestito.Utente.Nome == nome && prestito.Utente.Cognome == cognome);
        }

        // Getter per la lista degli utenti
        public List<Utente> Utenti
        {
            get { return this.utenti; }
        }

        // Getter per la lista degli documenti
        public List<Documento> Documenti
        {
            get { return this.documenti; }
        }

    }
}
