using Master.Core.Entities;
using Master.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryADO
{
    public class RepositoryStudentiADO : IRepositoryStudenti
    {

        const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniMaster;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Studente Add(Studente item)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "INSERT INTO Studente VALUES (@nome, @cognome, @mail, @data,  @titolo, @codice )";
                    command.Parameters.AddWithValue("@nome", item.Nome);
                    command.Parameters.AddWithValue("@cognome", item.Cognome);
                    command.Parameters.AddWithValue("@mail", item.Mail);
                    command.Parameters.AddWithValue("@data", item.DataNascita);
                    command.Parameters.AddWithValue("@titolo", item.TitoloStudio);
                    command.Parameters.AddWithValue("@codice", item.IdCorso);


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

        public bool Delete(Studente item)
        {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "DELETE FROM Studente WHERE Id=@id";
                    command.Parameters.AddWithValue("@id", item.Id);


                int rigaEliminata = command.ExecuteNonQuery();
                if (rigaEliminata == 1)
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

        public List<Studente> GetAll()
        {

            List<Studente> studenti = new List<Studente>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Studente";


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var id = (int)reader["Id"];
                    var cognome = (string)reader["Cognome"];
                    var nome = (string)reader["Nome"];
                    var mail = (string)reader["Mail"];
                    var titolo = (string)reader["Titolo"];
                    var dataNascita = (DateTime)reader["DataNascita"];
                    var idCorso = (string)reader["IdCorso"];


                    Studente studente = new Studente()
                    {
                        Id = id,
                        Nome = nome,
                        Cognome = cognome,
                        Mail = mail,
                        TitoloStudio = titolo,
                        DataNascita = dataNascita,
                        IdCorso = idCorso,

                    };

                    studenti.Add(studente);
                }
                connection.Close();

                return studenti;


            }

        }

        public List<Studente> GetByCorseCode(string codice)
        {
            throw new NotImplementedException();
        }

        public Studente GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Studente WHERE Id=@id";
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();
                Studente studente = new Studente();

                while (reader.Read())
                {
                    var cognome = (string)reader["Cognome"];
                    var nome = (string)reader["Nome"];
                    var mail = (string)reader["Mail"];
                    var titolo = (string)reader["Titolo"];
                    var dataNascita = (DateTime)reader["DataNascita"];
                    var idCorso = (string)reader["IdCorso"];



                    studente.Id = id;
                    studente.Nome = nome;
                    studente.Cognome = cognome;
                    studente.Mail = mail;
                    studente.TitoloStudio = titolo;
                    studente.DataNascita = dataNascita;
                    studente.IdCorso = idCorso;



                }
                connection.Close();

                return studente;


            }
        }

        public Studente Update(Studente item)
        {


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "UPDATE dbo.Studente SET Mail =@mail WHERE Id=@id";
                    command.Parameters.AddWithValue("@mail", item.Mail);
                    command.Parameters.AddWithValue("@id", item.Id);


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




    }
}
