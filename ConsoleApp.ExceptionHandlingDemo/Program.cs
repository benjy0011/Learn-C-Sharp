// See https://aka.ms/new-console-template for more information



try
{
    Console.Write("Enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You are {age} years old.");
}
catch (Exception)
{
    Console.WriteLine("Your age value was incorrect, please try again.");
    //throw;
}
finally
{
    Console.WriteLine("Tq for using this program. Bye bye.");
}