// Declare variables
using System.Xml.Linq;
using System.Globalization;

char choice = '0';

const int retirementAge = 65;

string? firstName = string.Empty;
string lastName = string.Empty;
int age; // default int is 0
DateOnly dob = new DateOnly();
decimal salary = 0;
char gender = char.MinValue;
bool working = false;



List<Person> persons = new List<Person>();

while(choice != 'E')
{
    // Prompt the user for input
    Console.Write("Please enter your first name: ");
    firstName = Console.ReadLine();

    Console.Write("Please enter your last name: ");
    lastName = Console.ReadLine();

    Console.Write("Please enter your date of birth (dd/mm/yyyy): ");
    dob = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
    age = DateTime.Now.Year - dob.Year;

    Console.Write("Please enter your salary: ");
    salary = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Please enter your gender (M or F): ");
    gender = Convert.ToChar(Console.ReadLine());

    Console.Write("Are you working? (true or false): ");
    working = Convert.ToBoolean(Console.ReadLine());



    Person person = new(dob)
    {
        FirstName = firstName,
        LastName = lastName,
        //DateOfBirth = dob,
        Gender = gender,
        IsWorking = working,
        Salary = salary
    };

    persons.Add(person);

    //persons.Add(new Person(dob)
    //{
    //    FirstName = firstName,
    //    LastName = lastName,
    //    Gender = gender,
    //    IsWorking = working,
    //    Salary = salary
    //});

    Console.WriteLine("C - Continue | E - Exit");
    choice = Convert.ToChar(Console.ReadLine());
}


foreach (var person in persons)
{
    // Output the results to the user
    Console.WriteLine($"Full name: {person.ToString()}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Your Salary is: {person.Salary.ToString("C")}");
    Console.WriteLine($"Your Gender is: {person.Gender}");
    Console.WriteLine($"You Are Employed: {person.IsWorking}");
    Console.WriteLine($"Number of working years remaining: {person.GetNumberOfWorkingYearsRemaining()}");
    Console.WriteLine($"Estimated Retirement Year: {person.GetEstimatedRetirementDate()}");

    Console.WriteLine("\n=================================================\n");
}





