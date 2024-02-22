void ad()
{
    Console.WriteLine("Adınızı Giriniz");
    string ad = Console.ReadLine();
    Console.WriteLine(ad);
}

int No ()
{
    Console.WriteLine("NO Giriniz");
    int no = Convert.ToInt16(Console.ReadLine());
    int result = no * 3;
    Console.WriteLine(result);
    return result;
}

void yas ()
{
    Console.WriteLine("Yaşınızı Giriniz :");
    int yasi = Convert.ToInt16(Console.ReadLine());
    if(yasi < 18)
    {
        Console.WriteLine("Anneni Çağır ");
    }
    else
    {
        Console.WriteLine("++++++++++++++++++++++++++++ " + yasi);
    }
    
}


No();
ad();
yas();