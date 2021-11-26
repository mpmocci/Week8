using Master.Core.Entities;
using Master.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Master.RepositoryMock
{
    public class RepositoryStudentiMock : IRepositoryStudenti
    {

        public static List<Studente> studenti = new List<Studente>()
        {
        };
        public Studente Add(Studente item)
        {
            if(studenti.Count == 0)
            {
                item.Id = 1;
            }
            else
            {
                int maxId = 1;
                foreach (var s in studenti)
                {
                    if(s.Id> maxId)
                    {
                        maxId = s.Id;
                    }
                }

                item.Id = maxId + 1;
            }
            studenti.Add(item);
            return item;

        }

        public bool Delete(Studente item)
        {
            studenti.Remove(item);
            return true;

        }

        public List<Studente> GetAll()
        {
            return studenti;
        }

      
        public List<Studente> GetByCorseCode(string codice)
        {
            List<Studente> studentiCorso = new List<Studente>();

            foreach (var item in studenti)
            {
                if (item.IdCorso == codice)
                {
                    studentiCorso.Add(item);
                }
            }

            return studentiCorso;
        }

        public Studente GetById(int id)
        {
            foreach (var item in studenti)
            {
                if (item.Id == id)
                {
                    return item;
                }

            }
            return null;


        }

        public Studente Update(Studente item)
        {

            foreach (var s in studenti)
            {
                if (s.Id == item.Id)
                {
                    s.Mail = item.Mail;
                    return s;
                }

            }
            return null;


        }
    }
}
