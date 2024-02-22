int ucgenAlan ()
{
    Console.WriteLine("Tabanı giriniz");
    int taban = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Yüksekliği giriniz");
    int yukseklik = Convert.ToInt32(Console.ReadLine());
    int result = taban * yukseklik / 2;
    Console.WriteLine("CEVAP " + result);
    return result;
}

int ucgenCevre ()
{
    Console.WriteLine("kenarları giriniz");
    Console.WriteLine("ilk kenar");
    int ilkKenar = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ikinci kenar");
    int ikinciKenar = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("üçüncü kenar");
    int ucuncuKenar = Convert.ToInt32(Console.ReadLine());
    int result = ilkKenar + ikinciKenar + ucuncuKenar;
    Console.WriteLine("CEVAP " + result);
    return result;
}

int kareAlan ()
{
    Console.WriteLine("Kenar Giriniz");
    int ilkKenar = Convert.ToInt32(Console.ReadLine());
    int result = ilkKenar * ilkKenar;
    Console.WriteLine(result);
    return result;
}

int kareCevre ()
{
    Console.WriteLine("Kenar Giriniz");
    int ilkKenar = Convert.ToInt32(Console.ReadLine());
    int result = ilkKenar * 4;
    Console.WriteLine(result);
    return result;
}

int cemberCevre ()
{
    Console.WriteLine("Yarıçapı giriniz");
    double r = Convert.ToDouble(Console.ReadLine());
    const double pi = 3.14;
    double result = 2 * pi * r;
    Console.WriteLine(result);
    return (int)result;
}

int cemberAlan ()
{
    Console.WriteLine("Yarıçapı giriniz");
    double r = Convert.ToDouble(Console.ReadLine());
    const double pi = 3.14;
    double result = pi * r * r;
    Console.WriteLine (result);
    return (int)result;
}

Console.WriteLine("Alan veya Çevre hesaplamak için sayı seçimi yapınız");
Console.WriteLine("Üçgen Alan = 1");
Console.WriteLine("Üçgen Çevre = 2");
Console.WriteLine("Kare Alan = 3");
Console.WriteLine("Kare Çevre = 4");
Console.WriteLine("Çember Alan = 5");
Console.WriteLine("Çember Çevre = 6");
int secim = Convert.ToInt32(Console.ReadLine());

switch (secim)
{
    case 1:
        ucgenAlan();
        break;
    case 2:
        ucgenCevre();
        break;
    case 3:
        kareAlan();
        break;
    case 4:
        kareCevre();
        break;
    case 5:
        cemberAlan();
        break;
    case 6:
        cemberCevre();
        break;
}