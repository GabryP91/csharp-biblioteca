/*
 * 
    Si vuole progettare un sistema per la gestione di una biblioteca.
    Gli utenti si possono registrare al sistema, fornendo:
    - cognome
    - nome
    - email
    - password
    - recapito telefonico
    Gli utenti registrati possono prendere in prestito dei documenti che sono di vario tipo (libri, DVD).
    I documenti sono caratterizzati da:
    - un codice identificativo di tipo stringa
    - titolo
    - anno
    - settore (storia, matematica, economia, …)
    - uno scaffale in cui è posizionato
    - un autore (Nome, Cognome)
    Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
    L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, prendere in prestito registrando il periodo (Dal/Al) del prestito e il documento.
    Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
    Creiamo anche una classe Biblioteca che contiene la lista dei documenti, la lista degli utenti e la lista dei prestiti.
    Contiene inoltre i metodi per le ricerche e per l’aggiunta dei documenti, utenti e prestiti.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            int TotUser,TotBook;

            Utente utente = null;

            //creazione documento (LIBRO)
            Documento libro = new Libro();

            libro = null;

            Console.WriteLine("\nQuanti utenti si vogliono inserire?:");
            //controllo sull'input dell'utente, se quello che è stato digitato non è un numero darà errore
            while (int.TryParse(Console.ReadLine(), out TotUser) == false)
            {
                Console.WriteLine("Sintassi errata. Inserisci numero");
            }

            for (int i = 0; i < TotUser; i++)
            {

                
                Console.WriteLine($"Inserimento utente {i + 1} di {TotUser}:");

                utente = Population();

                //inserimento in biblioteca nuovo utente
                biblioteca.AggiungiUtente(utente);
            }

            Console.WriteLine("\nQuanti libri si vogliono inseire?:");
            //controllo sull'input dell'utente, se quello che è stato digitato non è un numero darà errore
            while (int.TryParse(Console.ReadLine(), out TotBook) == false)
            {
                Console.WriteLine("Sintassi errata. Inserisci numero");
            }

            for (int i = 0; i < TotBook; i++)
            {

                Console.WriteLine($"Inserimento utente {i + 1} di {TotBook}:");

                libro = PopulationBook();

                //inserimento in biblioteca nuovo documento(LIBRO)
                biblioteca.AggiungiDocumento(libro);
            }


          
           
            //ottengo la data corrente e la memorizzo in una opportuna variabile
            DateTime oggi = DateTime.Today;

            //ottengo la data corrente e la memorizzo in una opportuna variabile incrementata di uno
            DateTime domani = oggi.AddDays(1);

            //inserimento in biblioteca nuovo presito
            biblioteca.RegistraPrestito(utente, libro, oggi, domani);

            // Ricerca documenti per titolo
            List<Documento> documentiRicerca = biblioteca.CercaDocumentiPerTitolo("Il signore degli anelli");

            foreach (Documento doc in documentiRicerca)
            {
                Console.WriteLine($"Titolo: {doc.Titolo}, Autore: {doc.Autore.Nome} {doc.Autore.Cognome}");
            }

            // Ricerca prestiti per utente
            List<Prestito> prestitiUtente = biblioteca.CercaPrestitiPerUtente("Mario", "Rossi");

            foreach (Prestito prestito in prestitiUtente)
            {
                Console.WriteLine($"Utente: {prestito.Utente.Nome} {prestito.Utente.Cognome}, Documento: {prestito.Documento.Titolo}, Dal: {prestito.Dal}, Al: {prestito.Al}");
            }



            Console.ReadKey();
        }

        static Utente Population()
        {

            Console.WriteLine("Inserisci il cognome:");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci il nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci l'email:");
            string email = Console.ReadLine();
            Console.WriteLine("Inserisci la password:");
            string password = Console.ReadLine();
            Console.WriteLine("Inserisci il recapito telefonico:");
            string RecapTel = Console.ReadLine();

            // restituisco oggetto con informazione utente
            return new Utente
            {
                Cognome = cognome,
                Nome = nome,
                Email = email,
                Password = password,
                RecapTel = RecapTel
            };

        }

        static Libro PopulationBook()
        {
            int year,tot_page;

            Console.WriteLine("Inserisci il codice:");
            string code = Console.ReadLine();

            Console.WriteLine("Inserisci il Titolo:");
            string title = Console.ReadLine();

            Console.WriteLine("Inserisci anno di pubblicazione:");
            //controllo sull'input dell'utente, se quello che è stato digitato non è un numero darà errore
            while (int.TryParse(Console.ReadLine(), out year) == false)
            {
                Console.WriteLine("Sintassi errata. Inserisci numero");
            }

            Console.WriteLine("Inserisci Genere:");
            string tipe = Console.ReadLine();

            Console.WriteLine("Inserisci Scaffale di riferimento:");
            string pos = Console.ReadLine();

            Console.WriteLine("Inserisci Nome autore:");
            string nameA = Console.ReadLine();

            Console.WriteLine("Inserisci Cognome autore:");
            string surA = Console.ReadLine();

            Console.WriteLine("Inserisci numero pagine:");
            //controllo sull'input dell'utente, se quello che è stato digitato non è un numero darà errore
            while (int.TryParse(Console.ReadLine(), out tot_page) == false)
            {
                Console.WriteLine("Sintassi errata. Inserisci numero");
            }

            //creazione documento (LIBRO)
            return new Libro
            {
                Id_code = code,
                Titolo = title,
                Anno = year,
                Settore = tipe,
                Scaffale = pos,
                Autore = new Autore { Nome = nameA, Cognome = surA },
                Num_pag = tot_page
            };


        }



    }
}
