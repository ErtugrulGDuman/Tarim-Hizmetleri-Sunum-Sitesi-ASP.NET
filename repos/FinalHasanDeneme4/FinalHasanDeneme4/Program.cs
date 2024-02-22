int sayi, birlerbas, toplam = 0, sayikopya;
sayi = Convert.ToInt32(Console.ReadLine());
sayikopya = sayi;
while (sayi > 0)
{
    birlerbas = sayi % 10;
    sayi = sayi / 10;
    toplam = toplam * 10 + birlerbas;
}
if (sayikopya == toplam)
{
    Console.WriteLine("Sayı Palindrom");
}
else
{
    Console.WriteLine("Sayi Palindrom Değil.");
}