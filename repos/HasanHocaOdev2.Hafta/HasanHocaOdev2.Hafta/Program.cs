Console.WriteLine("piramit kaç katlı olsun");
int satır = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("piramitin genişliği ne kadar olsun");
int sutun = Convert.ToInt32(Console.ReadLine());





for (int i = 0; i < satır; i++)
{
    for (int k = i; k < sutun; k++)
    {
        Console.Write(" ");
    }
    for (int x = 0; x <= i; x++)
    {
        Console.Write("*");
        Console.Write(" ");
    }
    Console.WriteLine();
}