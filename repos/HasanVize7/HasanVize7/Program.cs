int[] sayilar = new int[5];
Random rnd = new Random();
int min, mak;

for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = rnd.Next(1, 10);
    Console.WriteLine(sayilar[i]);
}
min = sayilar[0];
mak = sayilar[0];
for (int i = 1; i < sayilar.Length; i++)
{
    if (min > sayilar[i])
        min = sayilar[i];
    if (mak < sayilar[i])
        mak = sayilar[i];
}
Console.WriteLine("*******************************");
Console.WriteLine(min);
Console.WriteLine("*******************************");
Console.WriteLine(mak);
