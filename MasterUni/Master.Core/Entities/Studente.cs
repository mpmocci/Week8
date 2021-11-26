using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Core.Entities
{
   public class Studente : Persona
    {

        public DateTime DataNascita { get; set; }
        public string TitoloStudio { get; set; }
        public string IdCorso{ get; set; }
        public Corso Corso { get; set; }

        

        public override string ToString()
        {
            return $"Id: {Id}\t {Nome}\t {Cognome}\t nato il: {DataNascita.ToShortDateString()}\t Altre info: {Mail} - {TitoloStudio}";
        }

    }
}
