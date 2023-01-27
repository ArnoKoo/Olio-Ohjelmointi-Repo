using System;
namespace Tupleharkka
{
    class Tupleharkka
    {
        static void Main(string[] args)
        {
            PääraakaAine RaakaAine = PääraakaAine.Kanaa;
            Lisukkeet Lisuke = Lisukkeet.Pastaa;
            Kastikkeet Kastike = Kastikkeet.Chiliä;

            (string, string, string) RaakaAineLista = ("Nautaa", "Kanaa", "Kasvista");
            Console.WriteLine("Pääraaka-aine " + RaakaAineLista);
            string valinta1 = Console.ReadLine();

            if (valinta1 == "Nautaa")
            {
                RaakaAine = PääraakaAine.Nautaa;
            }
            if (valinta1 == "Kanaa")
            {
                RaakaAine = PääraakaAine.Kanaa;
            }
            if (valinta1 == "Kasvista")
            {
                RaakaAine = PääraakaAine.Kasvista;
            }


            (string Peruna, string Riisi, string Pasta) LisukeLista = ("Perunaa", "Riisiä", "Pastaa");
            Console.WriteLine("Lisukkeet " + LisukeLista);
            string valinta2 = Console.ReadLine();

            if (valinta2 == "Perunaa")
            {
                Lisuke = Lisukkeet.Perunaa;
            }
            if (valinta2 == "Riisiä")
            {
                Lisuke = Lisukkeet.Riisiä;
            }
            if (valinta2 == "Pastaa")
            {
                Lisuke = Lisukkeet.Pastaa;
            }

            (string Pippuri, string Chili, string Hapani) KastikeLista = ("Pippuria", "Chiliä", "Hapanimiä");
            Console.WriteLine("Kastikkeet " + KastikeLista);
            string valinta3 = Console.ReadLine();

            if (valinta3 == "Pippuria")
            {
                Kastike = Kastikkeet.Pippuria;
            }
            if (valinta3 == "Chiliä")
            {
                Kastike = Kastikkeet.Chiliä;
            }
            if (valinta3 == "Hapanimiä")
            {
                Kastike = Kastikkeet.Hapanimiä;
            }

            (PääraakaAine, Lisukkeet, Kastikkeet) tilausLista = (RaakaAine, Lisuke, Kastike);
            Console.WriteLine(tilausLista);
        }
        enum PääraakaAine
        {
            Nautaa,
            Kanaa,
            Kasvista
        };

        enum Lisukkeet
        {
            Perunaa,
            Riisiä,
            Pastaa
        };

        enum Kastikkeet
        {
            Pippuria,
            Chiliä,
            Hapanimiä
        };
    }
}