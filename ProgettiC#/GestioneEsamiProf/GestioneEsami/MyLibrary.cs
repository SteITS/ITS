using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami
{
    internal class MyLibrary
    {
        public static string ExportCSV(string pathFileName) {
            if (!File.Exists(pathFileName))
                throw new FileNotFoundException($"{pathFileName} non trovato");

            var list = new List<Studente>();
            var text = string.Empty;

            using (StreamReader sr = new StreamReader(pathFileName))
            {
                text = sr.ReadToEnd();
            }

            if (text == string.Empty)
                throw new ArgumentNullException($"Dati non trovati");

            return text;
        }

        public static List<Studente> LoadStudentiCSV(string pathFileName)
        {            
            var list = new List<Studente>();
            
            string[] lines = ExportCSV(pathFileName).Split(Environment.NewLine);
            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                if (data.Length > 0)
                    list.Add(new Studente
                    {
                        Matricola = Convert.ToInt32(data[0]),
                        Cognome = data[1],
                        Nome = data[2],
                        DataNascita = Convert.ToDateTime(data[3]),
                        LuogoNascita = data[4],
                        Via = data[5],
                        Cap = data[6],
                        Citta = data[7],
                        SiglaProvincia = data[8],
                        Telefono = data[9],
                        Email = data[10],
                        TioloStudio = data[11]
                    });
            }

            return list;
        }

        public static List<Materia> LoadMaterieCSV(string pathFileName)
        {
            var list = new List<Materia>();            

            string[] lines = ExportCSV(pathFileName).Split(Environment.NewLine);
            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                if (data.Length > 0)
                    list.Add(new Materia
                    {
                        Codice = Convert.ToInt32(data[0]),
                        Denominazione = data[1],
                        Descrizione = data[2],
                        NumeroOre = Convert.ToInt32(data[3])
                    });

            }

            return list;
        }

        public static List<Esame> LoadEsamiCSV(string pathFileName)
        {
            var list = new List<Esame>();
            
            string[] lines = ExportCSV(pathFileName).Split(Environment.NewLine);
            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                if (data.Length > 0)
                    list.Add(new Esame
                    {
                        MatricolaStudente = Convert.ToInt32(data[0]),
                        CodiceMateria = Convert.ToInt32(data[1]),
                        Data = Convert.ToDateTime(data[2]),
                        Voto = Convert.ToInt32(data[3])
                    });
            }
            return list;
        }
    }
}
