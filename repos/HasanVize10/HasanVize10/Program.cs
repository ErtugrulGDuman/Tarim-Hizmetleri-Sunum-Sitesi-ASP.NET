int gir = Convert.ToInt16(Console.ReadLine());
int a = 1, b=1, c;
Console.WriteLine(a);
Console.WriteLine(b);
for(int i = 0; i < gir; i++)
{
    c = a + b;
    a = b;
    b = c;
    Console.WriteLine(c);
}