using Master.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        //Visualizza tutti i corsi
        public List<Corso> GetAllCorsi();
        public Esito AggiungiCorso(Corso c);
        Esito ModificaCorso(string codice, string nome, string descrizione);
        Esito EliminaCorso(string codice);
        List<Studente> GetAllStudenti();
        public Esito AggiungiStudente(Studente s);
        Esito ModificaStudente(int codice, string mail);
        Esito EliminaStudente(int codice);
        List<Studente> GetAllStudentiByCorseCode(string codice);
        bool VerificaCodice(string codice);
       public List<Docente> GetAllDocenti();
        Esito AggiungiDocente(Docente docente);
        Esito ModificaDocente(int id, string mail, string telefono);
    }
}
