


//DortIslem dortIslem = new DortIslem(2, 3);
//Console.WriteLine(dortIslem.Topla2());
//Console.WriteLine(dortIslem.Topla(3, 4))

var tip = typeof(DortIslem);
//DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);
//Console.WriteLine(dortIslem.Topla2());
//Console.WriteLine(dortIslem.Topla(4,5));

var instance = Activator.CreateInstance(tip, 6, 7);
Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null));
Console.WriteLine("-------------------------------------------------");
var Metodlar = tip.GetMethods();
foreach (var info in Metodlar)
{
    Console.WriteLine("Metod Adı : {0}", info.Name);
    foreach (var parametre in info.GetParameters())
    {
        Console.WriteLine("Parametre : {0}", parametre.Name);
    }
    foreach (var attribute in info.GetCustomAttributes())
    {
        Console.WriteLine("Attribute Name : {0}",attribute.GetType().Name);
    }
}


public class DortIslem
{
    int _s1;
    int _s2;

    public DortIslem(int s1, int s2)
    {
        _s1 = s1;
        _s2 = s2;
    }

    public int Topla(int s1, int s2)
    {
        return s1 + s2;
    }
    public int Carp(int s1, int s2)
    {
        return s1 * s2;
    }
    public int Topla2()
    {
        return _s1 + _s2;
    }
    public int Carp2()
    {
        return _s1 * _s2;
    }
}
public class MetodName:Attribute
{

}