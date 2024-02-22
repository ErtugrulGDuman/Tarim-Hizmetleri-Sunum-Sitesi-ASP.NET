var random = new Random();
Console.WriteLine("Hangi sayılar arasında sayı türetmek istediğinizi seçiniz");
Console.Clear();
Console.WriteLine("ilk sayıyı giriniz");
var g = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ilk sayıyı giriniz");
var h = Convert.ToInt32(Console.ReadLine());
var sayi = random.Next(g, h);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(sayi);
}