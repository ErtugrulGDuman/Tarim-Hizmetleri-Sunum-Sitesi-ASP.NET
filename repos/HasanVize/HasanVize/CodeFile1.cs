int[] dizi = new int[5];
int toplam = 0, avg = 0;
Random rand = new Random();
for (int i = 0; i < dizi.Length; i++)
{
    dizi[i] = rand.Next(11);
    Console.WriteLine(dizi[i]);
    toplam = toplam + dizi[i];
    avg = avg + dizi[i];
}
Console.WriteLine("****************************************");
avg = toplam / dizi.Length;
Console.WriteLine(toplam + " " + avg);