using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Core.Entities
{
    public class Lezione
    {

        public int IdLezione { get; set; }
        public DateTime DataOrario { get; set; }
        public int Durata { get; set; }
        public string Aula { get; set; }
        public int IdDocente { get; set; }
        public string CodiceCorso { get; set; }
        public Docente Docente { get; set; }
        public Corso Corso { get; set; }

        public override string ToString()
        {
            return $"Lezione: {IdLezione}\tData:{DataOrario}\tAula:{Aula}Durata (in gg):\t{Durata}";
        }
    }
}
