string karkitilaus = "a";
string peratilaus = "b";
int pituustilaus = 0;
string haluttupituus;

Console.WriteLine("Minkälainen kärki (puu, teräs, timantti) :");
while (karkitilaus != "puu" || karkitilaus != "teräs" || karkitilaus != "timantti" )
{
    karkitilaus = Console.ReadLine();
    if (karkitilaus == "puu" || karkitilaus == "timantti" || karkitilaus == "teräs")
    {
        break;
    }
}
Console.WriteLine("Minkälainen perä (lehti, kanansulka, kotkansulka) :");
while (peratilaus != "lehti" || peratilaus != "kanansulka" || peratilaus != "kotkansulka")
{
    peratilaus = Console.ReadLine();
    if (peratilaus == "lehti" || peratilaus == "kanansulka" || peratilaus == "kotkansulka")
    {
        break;
    }
}
Console.WriteLine("Mikä on nuolen pituus (60-100cm) :");
while (pituustilaus < 60 || pituustilaus > 100)
{
    haluttupituus = Console.ReadLine();
    if (int.TryParse(haluttupituus, out pituustilaus) == true && pituustilaus < 100 && pituustilaus > 60)
    {
        break;
    }
}

NuoliHommeli TilattuNuoli = new NuoliHommeli(karkitilaus, peratilaus, pituustilaus);
Console.WriteLine("Nuoli maksaaa " + TilattuNuoli.PalautaHinta() + " kultaa.");

public class NuoliHommeli
{
    private string _karki;
    private string _pera;
    private double _pituus;
    private double nuolenhinta;

    public NuoliHommeli(string karki, string pera, int pituus)
    {
        _karki = karki;
        _pera = pera;
        _pituus = pituus;
        if (_karki == "puu")
        {
            nuolenhinta += 3;
        }
        if (_karki == "teräs")
        {
            nuolenhinta += 5;
        }
        if (_karki == "timantti")
        {
            nuolenhinta += 50;
        }
        if (_pera == "kanansulka")
        {
            nuolenhinta += 1;
        }
        if (karki == "kotkansulka")
        {
            nuolenhinta += 5;
        }
        nuolenhinta = nuolenhinta + _pituus * 0.05;
        return;
    }

    public double PalautaHinta()
    {
        return nuolenhinta;
    }

    public string Karki()
    {
        return _karki;
    }

    public string Pera()
    {
        return _pera;
    }

    public double Pituus()
    {
        return _pituus;
    }
}