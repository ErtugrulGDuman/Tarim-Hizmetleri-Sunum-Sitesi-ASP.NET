﻿Console.WriteLine("Bir Sayı Giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = 0;
for (int i = 1; i < sayi; i++)
{
    if (sayi % i == 0)
    {
        toplam += i;
    }
}
if (toplam == sayi)
{
    Console.WriteLine("Girilen Sayı Mükemmeldir");
}
else
{
    Console.WriteLine("Sayı Mükemmel Değildir");
}