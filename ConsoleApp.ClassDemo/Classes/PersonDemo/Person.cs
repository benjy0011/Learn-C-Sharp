// Define a class
using System.Security.Cryptography;

namespace ConsoleApp.ClassDemo.Classes.PersonDemo;
public partial class Person
{
    // Constructor
    // Overloading
    // 'ctor' = shortcut for constructor
    public Person ()
    {

    }

    

    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxNumber;
    }

    // Properties/Data Members
    // 'get' only => prevent any changes after instantiated
    // 'init' => replacing set, allow one set only
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateOnly DateOfBirth { get; set; }


    // Fields member
    private string? _taxNumber;
    //private string? _idNumber; // private not able to share to child
    protected string? _idNumber = "N/A";



    public void PrintFullName()
    {
        // GetType() can get alot info of the class 
        var type = GetType().Name;
        Console.WriteLine($"{type} name: {FirstName} {LastName}");
    }

    public void PrintInitials() {
        var firstInitial = FirstName[0];
        var lastInitial = LastName[0];
        Console.WriteLine($"{firstInitial}.{lastInitial}.");
    }
    
    public void GenerateTaxNumber()
    {
        if(string.IsNullOrEmpty( _taxNumber ))
        {
            _taxNumber = GetRandomNumber();
        }
        else
        {
            Console.WriteLine("Tax number already exists");
        }
    }

    public string GetTextNumber()
    {
        return _taxNumber;
    }

    public string GetIdNumber()
    {
        return _idNumber;
    }

    // Method overload

    

    protected string GetRandomNumber()
    {
        return RandomNumberGenerator
            .GetInt32(100000, 9999999)
            .ToString();
    }
}


 
