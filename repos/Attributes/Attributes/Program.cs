

Customer customer = new Customer { Id = 1, LName = "egd", Age = 20 };
CustomerDal customerDal = new CustomerDal();
customerDal.Add(customer);
[ToTable("Customers")]
[ToTable("TblCustomers")]
class Customer
{
    public int Id { get; set; }
    [RequiredProperty]
    public string FName { get; set; }
    [RequiredProperty]
    public string LName { get; set; }
    [RequiredProperty]
    public int  Age { get; set; }
}
class CustomerDal
{
    [Obsolete("Dont use Add, İnstead use AddNew Method")]
    public void Add(Customer customer)
    {
        Console.WriteLine("{0},{1},{2},{3} ADDED "
            ,customer.Id,customer.FName,customer.LName,customer.Age );
    }
    public void AddNew(Customer customer)
    {

    }
}
[AttributeUsage(AttributeTargets.Property)]
class RequiredPropertyAttribute : Attribute
{

}
[AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]
class ToTableAttribute : Attribute
{
    private string _tableName;
    public ToTableAttribute(string tableName)
    {
        _tableName = tableName;
    }
}