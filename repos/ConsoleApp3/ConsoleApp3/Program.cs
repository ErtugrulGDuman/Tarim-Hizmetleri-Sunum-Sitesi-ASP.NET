class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void SayHello()
    {
        Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");
    }
}