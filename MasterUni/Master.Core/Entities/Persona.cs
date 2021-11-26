using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Core.Entities
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Nome{ get; set; }
        public string Cognome{ get; set; }
        public string Mail{ get; set; }


    }
}
