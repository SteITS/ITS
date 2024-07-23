using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseCRUD
{
    internal class StudentiDAL
    {
        private SqlConnectionStringBuilder connectionString;

        public StudentiDAL()
        {
            connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = @".\SQLEXPRESS";
            connectionString.InitialCatalog = "CRUD";
            connectionString.UserID = "backed";
            connectionString.Password = "Its-2024";
        }

        //elenco degli studenti
        public List<Studente> Elenco()
        {
            //accesso al db
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                var list = new List<Studente>();
                sqlConnection.ConnectionString = connectionString.ConnectionString;
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "Select * from Studenti";
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Studente()
                            {
                                Matricola = reader.GetInt16("matricola"),
                                Cognome = reader.GetString("Cognome"),
                                Nome = reader.GetString("nome"),
                                Email = reader.GetString("Email"),
                                Classe = reader.GetString("classe")
                            });
                        }
                    }
                }
                return list;
            }


        }
        public Studente? Dettaglio(int matricola)
        {
            //accesso al db
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                var list = new List<Studente>();
                sqlConnection.ConnectionString = connectionString.ConnectionString;
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "Select * from Studenti where Matricola=@Matricola";
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = matricola;
                    sqlCommand.CreateParameter();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Studente()
                            {
                                Matricola = reader.GetInt16("matricola"),
                                Cognome = reader.GetString("Cognome"),
                                Nome = reader.GetString("nome"),
                                Email = reader.GetString("Email"),
                                Classe = reader.GetString("classe")
                            });
                        }
                    }
                }
                return null;
            }
        }
        public void Nuovo(Studente studente)
        {
            if (studente == null)
                throw new Exception("Studente non esiste");
            //accesso al db
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                var list = new List<Studente>();
                sqlConnection.ConnectionString = connectionString.ConnectionString;
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "Insert into Studenti(Matricola,Cognome,Nome,Email,Classe) values(@Matricola,@Cognome,@Nome,@Email,@Classe)";
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = studente.Matricola;
                    sqlCommand.Parameters.Add("@Cognome", SqlDbType.VarChar, 50).Value = studente.Cognome;
                    sqlCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = studente.Nome;
                    sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = studente.Email;
                    sqlCommand.Parameters.Add("@Classe", SqlDbType.VarChar, 50).Value = studente.Classe;
                    sqlCommand.CreateParameter();

                    int rows = sqlCommand.ExecuteNonQuery();

                    if (rows != 1)
                    {
                        throw new Exception("Operazione Nuovo fallita");
                    }
                }
            }
        }
        public void Modifica(Studente studente)
        {
            if (studente == null)
                throw new Exception("Studente non esiste");
            //accesso al db
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                var list = new List<Studente>();
                sqlConnection.ConnectionString = connectionString.ConnectionString;
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "Update Studenti set Cognome=@Cognome,Nome=@Nome,Email=@Email,Classe=@Classe where Matricola=@Matricola";
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = studente.Matricola;
                    sqlCommand.Parameters.Add("@Cognome", SqlDbType.VarChar, 50).Value = studente.Cognome;
                    sqlCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = studente.Nome;
                    sqlCommand.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = studente.Email;
                    sqlCommand.Parameters.Add("@Classe", SqlDbType.VarChar, 50).Value = studente.Classe;
                    sqlCommand.CreateParameter();

                    int rows = sqlCommand.ExecuteNonQuery();

                    if (rows != 1)
                    {
                        throw new Exception("Operazione Modifica fallita");
                    }
                }
            }
        }
        public void Elimina(Studente studente)
        {
            if (studente == null)
                throw new Exception("Studente non esiste");
            //accesso al db
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                var list = new List<Studente>();
                sqlConnection.ConnectionString = connectionString.ConnectionString;
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "Delete from Studenti where Matricola=@Matricola";
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.Add("@Matricola", SqlDbType.Int).Value = studente.Matricola;
                    sqlCommand.CreateParameter();

                    int rows = sqlCommand.ExecuteNonQuery();

                    if (rows != 1)
                    {
                        throw new Exception("Operazione Modifica fallita");
                    }
                }
            }
        }
    }

}
