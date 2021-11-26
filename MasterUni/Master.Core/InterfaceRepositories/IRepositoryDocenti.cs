using Master.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Core.InterfaceRepositories
{
    public interface IRepositoryDocenti : IRepository<Docente>
    {
        public Docente GetById(int id);

    }
}
