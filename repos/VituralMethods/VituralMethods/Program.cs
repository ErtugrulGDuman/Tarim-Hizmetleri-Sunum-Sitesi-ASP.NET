SqlServerr sqlServerr = new SqlServerr();
sqlServerr.Add();

MySql mySql = new MySql();
mySql.Add();















class Database
{
    public  virtual void Add()
    {
        Console.WriteLine("Added");
    }
    public virtual void Delete()
    {
        Console.WriteLine("Deleted");
    }
}
class SqlServerr : Database
{
    public override void Add()
    {
        Console.WriteLine("Added by sql code");
        base.Add();
    }
}
class MySql : Database
{

}