using Master.Core.Entities;
using Master.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Master.RepositoryMock
{
    public class RepositoryCorsiMock : IRepositoryCorsi
    {

        public static List<Corso> Corsi = new List<Corso>()
        {
            new Corso{CodiceCorso="C01", Nome="PreAcademyD", Descrizione="C# base"},
            new Corso{CodiceCorso="C02", Nome="AcademyD", Descrizione="C# avanzato"},
        };

        public Corso Add(Corso item)
        {
            Corsi.Add(item);

            return item;
        }

        public bool Delete(Corso item)
        {
            Corsi.Remove(item);
            return true;
                }

        public List<Corso> GetAll()
        {

            return Corsi;
        }

        public Corso GetByCode(string codice)
        {
            foreach (var item in Corsi)
            {
                if (item.CodiceCorso == codice)
                {
                    return item;
                }

            }
            return null;

        }

        public Corso Update(Corso item)
        {

            foreach (var c in Corsi)
            {
                if (c.CodiceCorso == item.CodiceCorso)
                {
                    c.Nome = item.Nome;
                    c.Descrizione = item.Descrizione;
                    return c;
                }

            }
            return null;
        }
    }
}
