Console.Write("Bir sayi giriniz: ");
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
    Console.WriteLine("Girilen sayi MÜKEMMEL bir sayidir.");
}
else
{
    Console.WriteLine("Girilen sayi MÜKEMMEL bir sayi DEGİLDİR.");
}