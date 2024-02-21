 
using System.Xml;

var person=new Person();
Console.Write("Enter your name: ");
person.FirstName = Console.ReadLine();

Console.Write("Enter your last name: ");
person.LastName = Console.ReadLine();

Console.Write("Enter your age: "); 
person.Age=int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(person.GetFullName());
Console.WriteLine("My birth year is "+person.GetBirthYear());

class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Adress; 
    public string GetFullName()
    {
        return $"My name is {FirstName} {LastName}";
    } 
    public int GetBirthYear()
    {
          
        return DateTime.Now.Year - Age;
    }
}