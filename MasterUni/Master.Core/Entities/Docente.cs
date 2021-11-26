using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Core.Entities
{
    public class Docente : Persona
    {
        public string NumeroTelefono { get; set; }
        public List<Lezione> ListaLezioni { get; set; } = new List<Lezione>();

        public override string ToString()
        {
            return $"Id: {Id}\t {Nome}\t {Cognome}\t \t Altre info: {Mail} - {NumeroTelefono}";
        }

    }
}
