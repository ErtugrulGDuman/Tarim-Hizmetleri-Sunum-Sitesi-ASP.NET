string[,] regions = new string[5, 3]
{
    {"istanbul" , "izmit" , "balıkesir"},
    {"ankara","konya","kırıkkale"},
    {"antalya","adana","mersin"},
    {"r","j","ehj"},
    {"jhdjb","öcn","dlvjdk"}
};
for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("***************");
}