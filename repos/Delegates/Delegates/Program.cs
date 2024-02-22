public delegate void MyDelegate();




CustomerManager cManager=new CustomerManager();
customerManager.SendMessage();
customerManager.ShowAlert();


public class CustomerManager
{
    public void SendMessage()
    {
        Console.WriteLine("Hello");
    }
    public void ShowAlert()
    {
        Console.WriteLine("Be Careful");
    }
}