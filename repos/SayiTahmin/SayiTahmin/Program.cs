Random rnd = new Random();
int a=rnd.Next(1,100);
int tahmin=0;
while (true)
{
    Console.WriteLine("Bir sayı giriniz : ");
    tahmin = Convert.ToInt16(Console.ReadLine());
    if (tahmin < a)
    {
        Console.WriteLine("Daha büyük bir sayı giriniz : ");
        continue;
    }
    else if (tahmin > a)
    {
        Console.WriteLine("Daha küçük bir sayı giriniz : ");
        continue;
    }
    else
    {
        Console.WriteLine("Tebrikler doğru tahmin");
        break;
    }
}