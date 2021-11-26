using Master.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Core.InterfaceRepositories
{
   public interface IRepositoryStudenti : IRepository<Studente>
    {

        public Studente GetById(int id);
        List<Studente> GetByCorseCode(string codice);
    }
}
