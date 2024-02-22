//int[] dizi1 = new int[3];
//dizi1[0] = 9;
//dizi1[1] = 10;
//dizi1[2] = 11;


//for (int i = 0; i <= 2; i++)
//{
//	Console.WriteLine(dizi1[i]);
//}


//string[] dizi2 = { "Bir", "İki", "Üç", "Dört" };

//for (int i = 0; i <= 3; i++)
//{
//	Console.WriteLine(dizi2[i]);
//}

//void topla1()
//{
//	Console.Write("1.sayıyı giriniz: ");
//	int a = Convert.ToInt16(Console.ReadLine());
//	Console.Write("2.sayıyı giriniz: ");
//	int b = Convert.ToInt16(Console.ReadLine());
//	int sonuc = a + b;
//	Console.WriteLine("Toplama Sonucu: " + sonuc);
//}

//topla1();

//void topla2(int c, int d)
//{
//	int sonuc2 = c + d;
//	Console.WriteLine("Toplama 2 Sonucu: " + sonuc2);
//}

//topla2(5,8);

//static int topla3(int f, int g)
//{
//	int sonuc3 = f + g;
//	return sonuc3;
//}

//topla3(2,2);

//static void mesaj(string isim)
//{
//	Console.WriteLine("Merhaba {0} Hoş Geldin", isim);
//}

//mesaj("Hilal");

//static string mesaj2()
//{
//	string donus = "Hoş Geldin";
//	return donus;
//}

//Console.WriteLine(mesaj2());

//static int hesapla(int a)
//{
//	return a * a;
//}

//Console.WriteLine(hesapla(5));

//static void yaz(params string[] a)
//{
//	Console.WriteLine("****metot başladı");
//	for (int i = 0; i < a.Length; i++)
//	{
//		Console.WriteLine(a[i]);
//	}
//	Console.WriteLine("****metot bitti");
//}

//yaz();

//static int toplam(int k)
//{
//	Console.Write(k + " ");
//	if (k < 1)
//	{
//		return 0;
//	}
//	return k + toplam(k - 1);
//}

//Console.WriteLine(toplam(4));




//yıldız yapma
//Console.Write("Sutun sayısını giriniz: ");
//int sutun = Convert.ToInt16(Console.ReadLine());
//Console.Write("Satır sayısını giriniz: ");
//int satir = Convert.ToInt16(Console.ReadLine());
//for (int j = 0; j < satir; j++)
//{
//    for (int i = 0; i < j; i++)
//    {
//        Console.Write(" ");
//    }
//    Console.WriteLine("*");
//}
//for (int k = satir - 2; k >= 0; k--)
//{
//    for (int l = 0; l < k; l++)
//    {
//        Console.Write(" ");
//    }
//    Console.WriteLine("*");
//}

Console.Write("Satır sayısını giriniz: ");
int satir = Convert.ToInt16(Console.ReadLine());
for (int k = satir - 1; k > 0; k--)
{
    for (int l = 0; l < k; l++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("*");
}
for (int j = 0; j < satir; j++)
{
    for (int i = 0; i < j; i++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("*");
}


Console.ReadLine();