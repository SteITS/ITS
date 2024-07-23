using System.Data;
using System.Data.SqlClient;
namespace ConnessioneDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connessione al dbms SQL Server!");

            //stringa di connessione con parametri di accesso
            SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = @"localhost\SQLEXPRESS";
            connectionString.InitialCatalog = "Anagrafica";
            connectionString.UserID = "sa";
            connectionString.Password = "Its-2024";
            //connessione al database
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString.ConnectionString;
            sqlConnection.Open();
            Console.WriteLine("Connessione al database riuscita");

            Console.Write("Inserisci il titolo id studio preferito [Diploma, Laurea]: ");
            string titolo = Console.ReadLine();

            //selezione dei dati presenti in tabella Studenti ITS
            string sql = $"Select * from StudentiITS where TitoloStudio=@TitoloStudio";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.Add("@TitoloStudio",SqlDbType.VarChar,50).Value = titolo;
            sqlCommand.CreateParameter();
            Console.WriteLine("Accesso ai dati riuscita");

            //visualizzazione dei dati recuperati
            SqlDataReader reader = sqlCommand.ExecuteReader();
            string msg = string.Empty;
            while (reader.Read())
            {
                msg = $"Matricola: {reader.GetInt16("Matricola")}" +
                     $", Cognome: {reader.GetString("Cognome")}" +
                     $", Nome: {reader.GetString("Nome")}" +
                     $", Data Nascita: {reader.GetDateTime("DataNascita").ToShortDateString()}" +
                     $", Email: {reader.GetString("Email")}";
                Console.WriteLine(msg);
            }

            //chiusura connessione

            reader.Close();
            sqlCommand.Dispose();
            sqlConnection.Close();
        }
    }
}
