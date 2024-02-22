
    Person[] persons = new Person[3]
    {
        new Customer{FName= "eto"},
        new Student{FName= "duman"},
        new Person{FName= "Salih"}
    };
foreach (var person in persons)
{
    Console.WriteLine(person.FName);
}
class Person
{
    public int Id{ get; set; }
    public string FName{ get; set; }
    public string LName { get; set; }
}
class Customer : Person
{
    public string City { get; set; }
}
class Student : Person
{
    public string Department { get; set; }
}
