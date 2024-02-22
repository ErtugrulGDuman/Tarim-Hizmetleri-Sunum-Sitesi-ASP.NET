int sayi, islem, toplam = 0;
Console.Write("Bir sayı giriniz : ");
sayi = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("İşlem seçiniz : ");
Console.WriteLine("1 = seçtiğiniz sayıya kadar olan tek sayıların toplamı");
Console.WriteLine("2 = seçtiğiniz sayıya kadar olan çift sayıların toplamı");
islem = Convert.ToInt32(Console.ReadLine());

if (islem == 1)
{
    for(int i = 1; i < sayi; i = i + 2)
    {
        toplam = toplam + i;
        Console.Write(i + " ");
    }
    Console.Write(" " + toplam);
};

if (islem == 2)
{
    for(int i = 0; i < sayi; i = i + 2)
    {
        toplam = toplam + i;
        Console.Write(i + " ");
    }
    Console.Write(" " + toplam);
};