using Master.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Core.InterfaceRepositories
{
    public interface IRepositoryCorsi : IRepository<Corso>
    {
        public Corso GetByCode(string code);
    }
}
