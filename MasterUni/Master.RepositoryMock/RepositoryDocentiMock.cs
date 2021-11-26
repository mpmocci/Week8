using System;
using System.Collections.Generic;
using System.Text;
using Master.Core.Entities;
using Master.Core.InterfaceRepositories;


namespace Master.RepositoryMock
{
    public class RepositoryDocentiMock : IRepositoryDocenti
    {
        public List<Docente> docenti = new List<Docente>();

        public Docente Add(Docente item)
        {
            if (docenti.Count == 0)
            {
                item.Id = 1;
            }
            else
            {
                int maxId = 1;

                foreach (var s in docenti)
                {
                    if(s.Id > maxId)
                    {
                        maxId = s.Id;
                    }
                }

                item.Id = maxId + 1;

            }

            docenti.Add(item);
            return item;
        }

        public bool Delete(Docente item)
        {
            throw new NotImplementedException();
        }

        public List<Docente> GetAll()
        {
            return docenti;

        }

        public Docente GetById(int id)
        {

            foreach (var item in docenti)
            {
                if (item.Id == id)
                {
                    return item;
                }

            }

            return null;

        }

        public Docente Update(Docente item)
        {

            foreach (var s in docenti)
            {
                if (s.Id == item.Id)
                {
                    s.Mail = item.Mail;
                    s.NumeroTelefono = item.NumeroTelefono;
                    return s;
                }

            }
            return null;

        }
    }
}
