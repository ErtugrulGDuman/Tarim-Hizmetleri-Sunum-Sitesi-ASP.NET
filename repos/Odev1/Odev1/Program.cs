int a1, a2, a3, a4, a5, Toplam, Ortalama;

Console.Write("İlk sayıyı giriniz : ");
a1 = Convert.ToUInt16(Console.ReadLine());
Console.Clear();

Console.Write("İkinci sayıyı giriniz : ");
a2 = Convert.ToUInt16(Console.ReadLine());
Console.Clear();

Console.Write("Üçüncü sayıyı giriniz : ");
a3 = Convert.ToUInt16(Console.ReadLine());
Console.Clear();

Console.Write("Dördüncü sayıyı giriniz : ");
a4 = Convert.ToUInt16(Console.ReadLine());
Console.Clear();

Console.Write("Beşinci sayıyı giriniz : ");
a5 = Convert.ToUInt16(Console.ReadLine());
Console.Clear();

Toplam = a1 + a2 + a3 + a4 + a5;
Console.WriteLine("Sayıların Toplamı : " + Toplam);

Ortalama = Toplam / 5;
Console.WriteLine("Sayıların Ortalaması : " + Ortalama);
