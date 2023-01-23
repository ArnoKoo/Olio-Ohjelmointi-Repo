using System;
namespace EnumDemo
{
    class Ovihommeli
    {
        static bool oviLukossa = false;
        static bool oviKiinni = false;
        static bool loppu = false;
        enum Ovet
        {
            Auki = 1,
            Kiinni,
            Lukossa,
            Loppu
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Ovi on " + Ovet.Auki + ", mitä haluat tehdä?");
            while (loppu == false)
            {
                string käsky = Console.ReadLine();
                if (käsky == "Kiinni")
                {
                    Console.WriteLine("Ovi on " + Ovet.Kiinni + ", mitä haluat tehdä?");
                    Ovihommeli.oviKiinni = true;
                    Ovihommeli.oviLukossa = false;
                }
                if (käsky == "Lukko")
                {
                    if (!Ovihommeli.oviKiinni)
                    {
                        Console.WriteLine("Sulje ovi ennen kuin lukitset oven!");
                    }
                    else
                    {
                        Console.WriteLine("Ovi on " + Ovet.Lukossa + ", mitä haluat tehdä?");
                        Ovihommeli.oviLukossa = true;
                        Ovihommeli.oviKiinni = false;
                    }
                }
                if (käsky == "Auki")
                {
                    if (oviLukossa == true)
                    {
                        Console.WriteLine("Poista lukko ekaksi!");
                    }
                    else
                    {
                        Console.WriteLine("Ovi on " + Ovet.Auki + ", mitä haluat tehdä?");
                        Ovihommeli.oviKiinni = false;
                    }
                }
                if (käsky == "Loppu")
                {
                    loppu = true;
                }
            }
        }
    }
}