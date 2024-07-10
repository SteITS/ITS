namespace Solidi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I Solidi!");


            Materiale acciaio = new Materiale() { Denominazione = TipoMateriale.ACCIAIO, PesoSpecifico = 7.85 };//kg/dm3
            Materiale tungsteno = new Materiale() { Denominazione = TipoMateriale.TUNGSTENO, PesoSpecifico = 19.10 };//kg/dm3
            Materiale alluminio = new Materiale() { Denominazione = TipoMateriale.ALLUMINIO, PesoSpecifico = 2.60  };//kg/dm3
            double piombo = 11.34;//kg/dm3
            //stagno 7.28 kg/dm3
            //diamante 3.55 kg/dm3
            //fonte:https://www.oppo.it/tabelle/pesi_specifici.html

            Solido s1;// = new Solido(7.85); //non ammessa

            Cubo cubo = new Cubo(1,tungsteno);
            Console.WriteLine(cubo);
            Sfera sfera = new Sfera(1,acciaio);
            Console.WriteLine(sfera);
            Cilindro cilindro = new Cilindro(3, 5, alluminio);
            Console.WriteLine(cilindro);
        }
    }
}
