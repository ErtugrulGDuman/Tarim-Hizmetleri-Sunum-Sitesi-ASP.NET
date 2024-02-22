int sayi, kuvvet, sonuc;
Console.Write("Kuvvetini almak istediğiniz sayıyı girirniz : ");
sayi = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write("Sayının kuvvetini giriniz : ");
kuvvet = Convert.ToInt32(Console.ReadLine());
Console.Clear();

sonuc = (int)Math.Pow(sayi, kuvvet);
Console.WriteLine(sayi + "^" + kuvvet + " = " + sonuc);