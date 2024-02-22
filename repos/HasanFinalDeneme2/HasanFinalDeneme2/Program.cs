int sayi1, sayi2, toplam1 = 0, toplam2 = 0, i;
Console.WriteLine("Birinci sayıyı Girin : ");
sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("İkinci sayıyı girin : ");
sayi2 = int.Parse(Console.ReadLine());
for (i = 1; i < sayi1; i++)
{
    if (sayi1 % i == 0)
    {
        toplam1 = toplam1 + i;
    }
}
for (i = 1; i < sayi2; i++)
{
    if (sayi2 % i == 0)
    {
        toplam2 = toplam2 + i;
    }
}
if (sayi1 == toplam2 && sayi2 == toplam1)
{
    Console.WriteLine("Girilen sayılar Arkadaş sayı");
}
else
{
    Console.WriteLine("Sayılar arkadaş sayı değil");
}