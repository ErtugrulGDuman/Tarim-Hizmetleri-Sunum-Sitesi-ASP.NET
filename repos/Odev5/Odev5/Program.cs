int islem, toplam = 0;
Console.WriteLine("Bir işlem seçiniz ");
Console.WriteLine(" 0 = 1 den 100 e kadar olan tek sayıların toplamı");
Console.WriteLine(" 1 = 1 den 100 e kadar olan çift sayıların toplamı");
islem = Convert.ToInt32(Console.ReadLine());

if(islem == 0)
{
    for (int i = 1; i < 100; i += 2)
    {
        toplam = toplam + i;
    };
    Console.WriteLine("Sonuç = " + toplam);
};

if (islem == 1)
{
    for (int i = 0; i < 100; i += 2)
    {
        toplam = toplam + i;
    };
    Console.WriteLine("Sonuç = " + toplam);
};