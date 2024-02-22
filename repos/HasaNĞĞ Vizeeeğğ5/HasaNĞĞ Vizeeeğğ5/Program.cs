int[] dizi = new int[10];
int toplam=0, avg=0,min=21;
Random rnd = new Random();


for (int i = 0; i < dizi.Length; i++)
{
    dizi[i] = rnd.Next(20);
    toplam = toplam + dizi[i];
    Console.WriteLine(dizi[i]);
}

Console.WriteLine("****************************************");
avg = toplam / dizi.Length;
//Console.WriteLine(mak);
//Console.WriteLine(min);
//Console.WriteLine(avg);



int maksi(int mak = 0)
{
    for (int i = 0; i < dizi.Length; i++)
    {
        if (dizi[i] > mak)
        {
            mak = dizi[i];
        }
    }
    return mak;
    Console.WriteLine(mak);
}



int mini()
{
    for(int i = 0; i < dizi.Length; i++)
    {
        if (dizi[i] < min)
        {
            min = dizi[i];
        }
    }
    return min;
    Console.WriteLine(min);
}



int orta()
{
    avg=toplam / dizi.Length;
    return avg;
    Console.WriteLine(avg);
}


int sonmak = maksi(mak);