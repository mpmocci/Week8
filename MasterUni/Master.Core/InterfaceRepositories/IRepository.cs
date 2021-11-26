using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Core.InterfaceRepositories
{
    public interface IRepository<T>
    {
        //operazioni crud

        public List<T> GetAll();

        public T Add(T item);

        public T Update(T item);

        public bool Delete(T item);

    }
}
