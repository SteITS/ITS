namespace DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione dati CRUD!");

            var dal = new StudentiDAL();
            Console.WriteLine(string.Join("\n", dal.Elenco()));
            Console.WriteLine("Elenco Studenti");

            try 
            {
                var studente = new Studente()
                {
                    Matricola = 1000,
                    Cognome = "De Lillo Piras",
                    Nome = "Goffredo",
                    Email = "ppp@its.net",
                    Classe = "6B"
                };
                dal.Elimina(studente);
                dal.Nuovo(studente);
                Console.WriteLine("Inserito con Successo");



            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
