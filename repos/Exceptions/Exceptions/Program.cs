using Exceptions;

List<String> students = new List<string> { "A", "B", "C" };
if (students.Contains("A"))
{
    throw new RecordNotFoundException();
}
else
{
    Console.WriteLine("Record Found !!!");
}