Console.WriteLine("Kaç adet öğrenci gireceksiniz : ");
int a = Convert.ToInt32(Console.ReadLine());
string[] ogr = new string[a];
for(int i = 0; i < ogr.Length; i++)
{
    Console.WriteLine("Öğrenci adı");
    string b = Console.ReadLine();
    ogr[i] = b;
}
Console.WriteLine("*************************");
for(int i = 0; i < ogr.Length; i++)
{
    Console.WriteLine(ogr[i]);
}