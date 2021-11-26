using Master.Core.Entities;
using Master.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryADO
{

    public class RepositoryCorsiADO : IRepositoryCorsi
    {

        const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniMaster;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Corso Add(Corso item)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT INTO dbo.Corso VALUES (@codice, @nome, @descrizione)";
                    command.Parameters.AddWithValue("@nome", item.Nome);
                    command.Parameters.AddWithValue("@descrizione", item.Descrizione);
                    command.Parameters.AddWithValue("@codice", item.CodiceCorso);


                    int numRighe = command.ExecuteNonQuery();
                    if (numRighe == 1)
                    {
                        connection.Close();
                        return item;
                    }
                    connection.Close();
                    return item;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }


        }

        public bool Delete(Corso item)
        {

            List<Corso> corsi = new List<Corso>();
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Corso WHERE CodiceCorso=@c";
                command.Parameters.AddWithValue("@c", item.CodiceCorso);


                int numRighe = command.ExecuteNonQuery();
                if (numRighe == 1)
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }

            }


        }

        public List<Corso> GetAll()
        {
            List<Corso> corsi = new List<Corso>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Corso";


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var codice = (string)reader["CodiceCorso"];
                    var nome = (string)reader["Nome"];
                    var descrizione = (string)reader["Descrizione"];


                    Corso corso = new Corso()
                    {
                        CodiceCorso = codice,
                        Nome = nome,
                        Descrizione = descrizione

                    };

                    corsi.Add(corso);
                }
                connection.Close();

                return corsi;

            }
        }

        public Corso GetByCode(string code)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Corso WHERE CodiceCorso=@c";
                command.Parameters.AddWithValue("@c", code);


                SqlDataReader reader = command.ExecuteReader();

                Corso corso = new Corso();
                while (reader.Read())
                {
                    var codice = (string)reader["CodiceCorso"];
                    var nome = (string)reader["Nome"];
                    var descrizione = (string)reader["Descrizione"];


                    corso.CodiceCorso = codice;
                    corso.Nome = nome;
                    corso.Descrizione = descrizione;


                }
                connection.Close();

                return corso;

            }
        }

        public Corso Update(Corso item)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE dbo.Corso SET Nome=@n, Descrizione=@d WHERE CodiceCorso=@c";
                command.Parameters.AddWithValue("@c", item.CodiceCorso);
                command.Parameters.AddWithValue("@n", item.Nome);
                command.Parameters.AddWithValue("@d", item.Descrizione);


                int rigaInserita = command.ExecuteNonQuery();
                if (rigaInserita == 1)
                {
                    connection.Close();
                    return item;

                }
                else
                {
                    connection.Close();
                    return null;

                }
            }






        }
    }
}
