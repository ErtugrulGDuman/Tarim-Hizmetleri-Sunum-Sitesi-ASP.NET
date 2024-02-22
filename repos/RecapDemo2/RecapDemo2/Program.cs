CustomerManager customerManager=new CustomerManager();
customerManager.Logger = new FileLogger();
customerManager.Add();






class CustomerManager
{
    public ILogger Logger { get; set; }
    public void Add()
    {
        Logger.Log();
        Console.WriteLine("Customer Added");
    }
}
class Logger
{
    public void Log()
    {
        Console.WriteLine("Logged");
    }
}
class DataBaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to Database");
    }
}
class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged toFile");
    }
}
interface ILogger
{
    void Log();
}