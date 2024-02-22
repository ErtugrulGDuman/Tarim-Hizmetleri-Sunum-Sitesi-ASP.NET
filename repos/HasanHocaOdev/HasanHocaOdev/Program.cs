
using System.Collections;

Console.WriteLine("Kaç Adet Öğrenci Girilecek");
int OgrAdet = Convert.ToInt32(Console.ReadLine());
ArrayList Ogrnclr = new ArrayList();
Console.Clear();
int i;
string b;
for (i = 0; i < OgrAdet; i++)
{
    Console.WriteLine("Ad Soyad Giriniz");
    b = Console.ReadLine();
    Ogrnclr.Add(b);
    Console.WriteLine("Girmiş Olduğunuz Öğrenciler : " + Ogrnclr[i]);
}