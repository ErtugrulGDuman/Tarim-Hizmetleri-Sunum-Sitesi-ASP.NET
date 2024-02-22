int[] sayilar = new int[10];
Random rnd = new Random();
int tek, cift;


for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = rnd.Next(1, 100);
    Console.WriteLine(i + ". eleman : " + sayilar[i]);
}

Console.WriteLine("++++++++++++++++++++++");

for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] % 2 == 1)
    {
        tek = sayilar[i];
        Console.WriteLine(i + ". Tek Sayı : " + tek);
    }
}

for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] % 2 == 0)
    {
        cift = sayilar[i];
        Console.WriteLine(i + ". çift Sayı : " + cift);
    }
}