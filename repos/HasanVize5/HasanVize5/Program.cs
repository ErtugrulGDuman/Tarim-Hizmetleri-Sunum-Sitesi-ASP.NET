Console.WriteLine("Sayı Giriniz");
int sayi =Convert.ToInt32(Console.ReadLine());


if (sayi == 0)
{
    Console.WriteLine("0 dan farklı bir sayı giriniz");
    sayi = Convert.ToInt32(Console.ReadLine());
}


if (sayi % 2 == 0)
{
    for(int i = 0; i <= sayi; i = i + 2)
    {
        Console.WriteLine(i);
    }
}


if (sayi % 2 == 1)
{
    for (int i = 1; i <= sayi; i = i + 2)
    {
        Console.WriteLine(i);
    }
}