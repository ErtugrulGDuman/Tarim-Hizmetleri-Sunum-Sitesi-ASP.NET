int sayi, F =1;
Console.WriteLine("Bir Sayı Giriniz");
sayi = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= sayi; i++)
{
    F *= i;
};
Console.WriteLine(F);