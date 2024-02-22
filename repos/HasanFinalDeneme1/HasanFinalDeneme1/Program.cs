int satirSayisi = 5;
int bosluk = satirSayisi - 1;
int yildiz = 1;
for (int i = 0; i < satirSayisi; i++)
{
    for (int j = 0; j < bosluk; j++)
    {
        Console.Write(" ");
    }
    for(int k = 0; k < yildiz; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    bosluk--;
    yildiz += 2;
}
yildiz -= 4;
bosluk = 1;
for (int i = 0; i < satirSayisi - 1; i++)
{
    for(int j = 0; j < bosluk; j++)
    {
        Console.Write(" ");
    }
    for(int k = 0; k < yildiz; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    bosluk++;
    yildiz -= 2;
}