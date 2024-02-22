using System.Collections;

int[] egd = new int[5];
Random rnd = new Random();
    for(int i = 0; i<egd.Length; i++)
{
    egd[i] = rnd.Next(0, 10);
}
    foreach(int elements in egd)
{
    Console.WriteLine(elements);
}