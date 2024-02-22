PersonManager manager=new PersonManager();
manager.Add(new Customer { Id = 1, FName = "Ertuğrul", LName = "Duman", Address = "Tekirdağ" });
Student student = new Student
{
    Id = 1,
    FName = "Gökay",
    LName = "Duman",
    Department = "Computer Sciences"
};







interface IPerson
{
    int Id { get; set; }
    string FName { get; set; }
    string LName { get; set; } 
}
class Customer:IPerson
{
    public int Id { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public string Address { get; set; }
}
class Student:IPerson
{
    public int Id { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public string Department { get; set; }
}
class PersonManager
{
    public void Add(IPerson iperson)
    {
        Console.WriteLine(iperson.FName);
    }
}