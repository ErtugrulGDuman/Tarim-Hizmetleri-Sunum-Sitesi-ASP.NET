if (asal(4))
{
    Console.WriteLine("asal sayı");
}
else
{
    Console.WriteLine("asal sayı değil");
}
static bool asal (int number)
{
    bool result = true;
    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}