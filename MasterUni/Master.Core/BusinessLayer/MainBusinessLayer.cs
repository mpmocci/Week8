using Master.Core.Entities;
using Master.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {

        private readonly IRepositoryCorsi corsiRepo;
        private readonly IRepositoryStudenti studentiRepo;
        private readonly IRepositoryDocenti docentiRepo;


        public MainBusinessLayer(IRepositoryCorsi corsi, IRepositoryStudenti studenti, IRepositoryDocenti docenti)
        {
            corsiRepo = corsi;
            studentiRepo = studenti;
            docentiRepo = docenti;
        }

        #region Funzionalità Corsi
        public Esito AggiungiCorso(Corso c)
        {
           Corso corsoEsistente =  corsiRepo.GetByCode(c.CodiceCorso);

            if (corsoEsistente.CodiceCorso == null)
            {

                corsiRepo.Add(c);
                return new Esito { Messaggio = $"Corso aggiunto correttamente", IsOk= true };
            }
            else
            {
                return new Esito { Messaggio = $"Esiste già un corso con questo codice.", IsOk = false };
            }

        }

        public Esito EliminaCorso(string codice)
        {
            Corso corsoEsistente = corsiRepo.GetByCode(codice);

            if (corsoEsistente != null)
            {
                corsiRepo.Delete(corsoEsistente);
          

                return new Esito { Messaggio = "Il corso è stato eliminato correttamente.", IsOk = true };
            }
            else
            {
                return new Esito { Messaggio = "Nessun corso corrispondente al codice inserito", IsOk = false };
            }

        }

        public List<Corso> GetAllCorsi()
        {
            return corsiRepo.GetAll();


        }

        public Esito ModificaCorso(string codice, string nome, string descrizione)
        {
            Corso corsoEsistente = corsiRepo.GetByCode(codice);

            if(corsoEsistente != null)
            {

                Corso corsoDaAggiornare = new Corso();
                corsoDaAggiornare.CodiceCorso = codice;
                corsoDaAggiornare.Nome = nome;
                corsoDaAggiornare.Descrizione = descrizione;
                corsiRepo.Update(corsoDaAggiornare);

                return new Esito { Messaggio = "I dati sono stati aggiornati correttamente.", IsOk = true };
            }
            else
            {
                return new Esito { Messaggio = "Nessun corso corrispondente al codice inserito", IsOk = false };
            }

        }

        public bool VerificaCodice(string codice)
        {
            Corso corsoEsistente = corsiRepo.GetByCode(codice);

            if (corsoEsistente == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        #endregion Funzionalità Corsi

        #region Funzionalità Studenti
        public List<Studente> GetAllStudenti()
        {
            return studentiRepo.GetAll();

        }
        public Esito AggiungiStudente(Studente s)
        {
            Corso corsoEsistente = corsiRepo.GetByCode(s.IdCorso);

            if (corsoEsistente == null)
            {
                return new Esito { Messaggio = $"Non esiste un corso con questo codice.", IsOk = false };
            }
                studentiRepo.Add(s);
                return new Esito { Messaggio = $"Studente aggiunto correttamente", IsOk = true };
            

        }

        public Esito ModificaStudente(int codice, string mail)
        {
            Studente studenteEsistente = studentiRepo.GetById(codice);

            if (studenteEsistente != null)
            {

                Studente studenteDaAggiornare = new Studente();
                studenteDaAggiornare.Id = codice;
                studenteDaAggiornare.Mail = mail;
                studentiRepo.Update(studenteDaAggiornare);

                return new Esito { Messaggio = "I dati sono stati aggiornati correttamente.", IsOk = true };
            }
            else
            {
                return new Esito { Messaggio = "Nessuno studente corrispondente all'ID inserito", IsOk = false };
            }

        }

        public Esito EliminaStudente(int codice)
        {

            Studente studenteEsistente = studentiRepo.GetById(codice);

            if (studenteEsistente != null)
            {
                studentiRepo.Delete(studenteEsistente);


                return new Esito { Messaggio = "Lo studente è stato eliminato correttamente.", IsOk = true };
            }
            else
            {
                return new Esito { Messaggio = "Nessuno studente corrispondente all' ID inserito", IsOk = false };
            }

        }

        public List<Studente> GetAllStudentiByCorseCode(string codice)
        {


            return studentiRepo.GetByCorseCode(codice);


        }



        #endregion Funzionalità Studenti

        #region Funzionalità Docenti

        public List<Docente> GetAllDocenti()
        {

            return docentiRepo.GetAll();

        }

        public Esito AggiungiDocente(Docente docente)
        {
             docentiRepo.Add(docente);

            return new Esito {Messaggio="Docente aggiunto correttamente.", IsOk=true };
        }

        public Docente GetDocenteById(int id)
        {
            throw new NotImplementedException();
        }

        public Esito ModificaDocente(int id, string mail, string telefono)
        {

            Docente docenteEsistente = docentiRepo.GetById(id);

            if (docenteEsistente != null)
            {
                Docente docenteDaAggiornare = new Docente();

                docenteDaAggiornare.Id = id;
                docenteDaAggiornare.Mail = mail;
                docenteDaAggiornare.NumeroTelefono = telefono;

                docentiRepo.Update(docenteDaAggiornare);

                return new Esito { Messaggio = "I dati sono stati aggiornati correttamente.", IsOk = true };
            }
            else
            {
                return new Esito { Messaggio = "Non esiste un docente con questo ID.", IsOk = false };

            }


        }



        #endregion Funzionalità Docenti

    }
}
