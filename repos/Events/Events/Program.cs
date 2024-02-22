
Product harddisk = new Product(50);
harddisk.ProductName = "Hard Disk";
Product gsm=new Product(50);
for (int i=0; i<10; i++)
{
    harddisk.Sell(10);
    gsm.Sell(10);
}




public delegate void StockControl();
public class Product
{
    private int stock;
    public Product(int stock)
    {
        Stock = stock;
    }

    public event StockControl StockControlEvent;
    public string ProductName { get; set; }
    public int Stock {
        get
        {
            return Stock;
        }
        set
        {
            Stock = value;
            if (value <= 15 && StockControlEvent != null)
            {
                StockControlEvent();
            }
        }
    }
    public void Sell(int amount)
    {
        Stock -= amount;
        Console.WriteLine("Stock amount : {0}",Stock);
    }
}