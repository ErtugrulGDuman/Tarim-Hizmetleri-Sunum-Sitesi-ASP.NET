int count = 0, SAdeti = 0;

for (int i = 1; i <= 1000; i++)
{
    if ((i % 5 == 0) && (i % 7 != 0))
    {
        Console.WriteLine(i);
        count = count + i;
        SAdeti++; 
    };
}

Console.WriteLine("Sayıların toplamı : " + count);
Console.WriteLine("Sayıların adeti : " + SAdeti);