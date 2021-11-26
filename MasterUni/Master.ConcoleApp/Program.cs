using Master.Core.BusinessLayer;
using Master.Core.Entities;
using Master.RepositoryMock;
using RepositoryADO;
using System;
using System.Collections.Generic;

namespace Master.ConcoleApp
{
    class Program
    {
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryCorsiMock(), new RepositoryStudentiMock(), new RepositoryDocentiMock());
        // private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryCorsiADO(), new RepositoryStudentiADO());
        static void Main(string[] args)
        {
            bool continua = true;


            Console.WriteLine("Benvenuto al master!");

            while (continua == true)
            {

                int scelta = SchermoMenu();
                continua = AnalizzaScelta(scelta);
            }
        }

        private static bool AnalizzaScelta(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    VisualizzaCorsi();

                    break;

                case 2:
                    InserisciCorso();

                    break;

                case 3:
                    ModificaCorso();

                    break;

                case 4:
                    EliminaCorso();

                    break;

                case 5:
                    VisualizzaStudenti();

                    break;

                case 6:
                    InserisciStudente();

                    break;

                case 7:
                    ModificaStudente();

                    break;

                case 8:
                    EliminaStudente();

                    break;

                case 9:
                    VisualizzaStudentiCorso();

                    break;

                case 10:
                    VisualizzaDocenti();

                    break;

                case 11:
                    AggiungiDocente();

                    break;

                case 12:
                    ModificaDocente();

                    break;    
                
                case 13:
                    EliminaDocente();

                    break;


                case 0:
                    return false;

            }
            return true;

        }

        private static void EliminaDocente()
        {
            throw new NotImplementedException();
        }

        private static void ModificaDocente()
        {
            int id;
            do
            {
                Console.WriteLine("Inserisci l'ID del docente da modificare tra i seguenti:");
                VisualizzaDocenti();
            }
            while (!(int.TryParse(Console.ReadLine(), out id)));

            Console.WriteLine("Inserisci la nuova mail:");
            string mail = Console.ReadLine();  
            Console.WriteLine("Inserisci il nuovo numero di telefono:");
            string telefono = Console.ReadLine();

            Esito esito = bl.ModificaDocente(id, mail, telefono);
            Console.WriteLine(esito.Messaggio);

        }

        private static void AggiungiDocente()
        {

            Console.WriteLine("Inserisci il nome del nuovo docente:");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome del nuovo docente:");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci la mail del nuovo docente:");
            string mail = Console.ReadLine();
            Console.WriteLine("Inserisci il numero di telefono del nuovo docente:");
            string telefono = Console.ReadLine();

            Docente docente = new Docente();
            docente.Nome = nome;
            docente.Cognome = cognome;
            docente.Mail = mail;
            docente.NumeroTelefono = telefono;


            Esito esito = bl.AggiungiDocente(docente);
            Console.WriteLine(esito.Messaggio);





        }

        private static void VisualizzaDocenti()
        {

            List<Docente> docenti = new List<Docente>();

            docenti = bl.GetAllDocenti();

            foreach (var item in docenti)
            {
                Console.WriteLine(item);
            }

        }

        private static void VisualizzaStudentiCorso()
        {
            Console.WriteLine("Digita il codice del corso di cui vuoi visualizzare gli studenti iscritti:");
            VisualizzaCorsi();
            string codice = Console.ReadLine();
            bool exist = bl.VerificaCodice(codice);

            if (exist == true)
            {
                List<Studente> studenti = bl.GetAllStudentiByCorseCode(codice);
                foreach (var item in studenti)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Non esiste un corso con questo codice.");

            }

        }

        private static void EliminaStudente()
        {
            int codice;
            Console.WriteLine("Elenco studenti disponibili:");
            VisualizzaStudenti();
            do
            {
                Console.WriteLine("Quale studente vuoi eliminare? Inserisci l'ID.");
            }
            while (!(int.TryParse(Console.ReadLine(), out codice)));

            Esito e = bl.EliminaStudente(codice);

            Console.WriteLine(e.Messaggio);
        }

        private static void ModificaStudente()
        {
            int codice;
            Console.WriteLine("Lista studenti::");
            VisualizzaStudenti();
            do
            {
                Console.WriteLine("Quale studente vuoi modificare? Inserisci l'ID.");
            }
            while (!(int.TryParse(Console.ReadLine(), out codice)));
            Console.WriteLine("Inserisci la nuova mail:");
            string mail = Console.ReadLine();


            Esito esito = bl.ModificaStudente(codice, mail);
            Console.WriteLine(esito.Messaggio);
        }

        private static void InserisciStudente()
        {

            Console.WriteLine("Inserisci il nome del nuovo studente:");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome del nuovo studente:");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci la mail del nuovo studente:");
            string mail = Console.ReadLine();
            Console.WriteLine("Inserisci la data di nascita del nuovo studente:");
            DateTime dataNascita = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il titolo di studio del nuovo studente:");
            string titolo = Console.ReadLine();
            Console.WriteLine("Inserisci il codice del corso a cui lo studente è iscritto:");
            string codice = Console.ReadLine();

            bool exist = bl.VerificaCodice(codice);

            if (exist == true)
            {
                Studente studente = new Studente();
                studente.Nome = nome;
                studente.Cognome = cognome;
                studente.DataNascita = dataNascita;
                studente.Mail = mail;
                studente.TitoloStudio = titolo;
                studente.IdCorso = codice;


                Esito esito = bl.AggiungiStudente(studente);
                Console.WriteLine(esito.Messaggio);

            }
            else
            {
                Console.WriteLine("Non esiste un corso con questo codice.");

            }



        }

        private static void VisualizzaStudenti()
        {
            List<Studente> studenti = bl.GetAllStudenti();
            foreach (var item in studenti)
            {
                Console.WriteLine(item);
            }
        }

        private static void EliminaCorso()
        {
            Console.WriteLine("Elenco corsi disponibili:");
            VisualizzaCorsi();
            Console.WriteLine("Quale corso vuoi eliminare? Inserisci il codice.");
            string codice = Console.ReadLine();
            Esito e = bl.EliminaCorso(codice);

            Console.WriteLine(e.Messaggio);
        }

        private static void ModificaCorso()
        {
            Console.WriteLine("Elenco corsi disponibili:");
            VisualizzaCorsi();
            Console.WriteLine("Quale corso vuoi modificare? Inserisci il codice.");
            string codice = Console.ReadLine();
            Console.WriteLine("Inserisci il nuovo nome del corso:");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci la nuova descrizione del corso:");
            string descrizione = Console.ReadLine();

            Esito esito = bl.ModificaCorso(codice, nome, descrizione);
            Console.WriteLine(esito.Messaggio);


        }

        private static void InserisciCorso()
        {




            Console.WriteLine("Inserisci il codice del nuovo corso:");
            string codice = Console.ReadLine();
            Console.WriteLine("Inserisci il nome del nuovo corso:");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci la descrizione del nuovo corso:");
            string descrizione = Console.ReadLine();

            Corso corso = new Corso();
            corso.CodiceCorso = codice;
            corso.Nome = nome;
            corso.Descrizione = descrizione;

            Esito esito = bl.AggiungiCorso(corso);
            Console.WriteLine(esito.Messaggio);

        }

        private static void VisualizzaCorsi()
        {

            List<Corso> corsi = bl.GetAllCorsi();
            foreach (var item in corsi)
            {
                Console.WriteLine(item);
            }
        }

        private static int SchermoMenu()
        {
            Console.WriteLine("************Menu************");
            Console.WriteLine("\nFunzionalità Corsi");
            Console.WriteLine("1. Visualizza corsi.");
            Console.WriteLine("2. Inserisci un nuovo corso.");
            Console.WriteLine("3.Modifica corso.");
            Console.WriteLine("4. Elimina corso.");
            Console.WriteLine("5. Visualizza studenti.");
            Console.WriteLine("6. Inserisci studente.");
            Console.WriteLine("7. Modifica studente.");
            Console.WriteLine("8. Elimina studente.");
            Console.WriteLine("9. Visualizza studenti in un determinato corso.");
            Console.WriteLine("10. Visualizza docenti.");
            Console.WriteLine("11. Aggiungi docente.");
            Console.WriteLine("12. Modifica docente.");
            Console.WriteLine("13. Elimina docente.");
            Console.WriteLine("\n0. Exit");
            Console.WriteLine("****************************");
            int scelta;
            Console.WriteLine("Inserisci la tua scelta.");
            while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 13))
            {
                Console.WriteLine("Scelta errata! Inserisci scelta corretta.");
            }

            return scelta;

        }
    }
}
