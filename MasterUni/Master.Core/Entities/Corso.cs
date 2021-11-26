using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Core.Entities
{
    public class Corso
    {
        public string CodiceCorso { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public List<Lezione> ListaLezioni { get; set; } = new List<Lezione>();
        public List<Studente> ListaStudenti { get; set; }

        public override string ToString()
        {
            return $"{CodiceCorso}\t{Nome}\t{Descrizione}";
        }
    }
}
