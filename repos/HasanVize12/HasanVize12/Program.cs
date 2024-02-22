Random rastgele = new Random();
    int enKucuk = 0, enBuyuk = 100;
    int tahmin, sayi = rastgele.Next(100);
    int hak = 5;

while (true)
{
    Console.WriteLine("\n\n" + hak-- + " hakkınız var.");
    if (hak < 0)
    {
        Console.WriteLine("KAYBETTİNİZ! Tutulan sayı: " + sayi);
        break;
    }

    Console.Write(enKucuk + " ile " + enBuyuk + " ARASI BİR SAYI GİRİNİZ: ");
    tahmin = Convert.ToInt32(Console.ReadLine());

    if (tahmin > sayi)
    {
        if (tahmin < enBuyuk)
        {
            enBuyuk = tahmin;
        }
    }
    else if (tahmin < sayi)
    {
        if (tahmin > enKucuk)
        {
            enKucuk = tahmin;
        }
    }
    else
    {
        Console.WriteLine("TEBRİKLER!");
        break;
    }
}
