// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the sample calculator");

int choice = 999;
int num1;
int num2;

while (choice != 0)
{
    try
    {
        PrintMenu();

        choice = Convert.ToInt32(Console.ReadLine());


        if (choice == 0) break;

        Console.Write("Please enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        


        int answer = 0;
        switch (choice)
        {
            case 1:
                answer = AddNumbers(num1, num2);
                break;
            case 2:
                answer = SubtractNumbers(num1, num2);
                break;
            case 3:
                answer = Product(num1, num2);
                break;
            case 4:
                answer = Quotient(num1, num2);
                break;
            case 5:
                answer = Fibonaci(num1, num2);
                break;
            default:
                throw new Exception("Invalid Menu Item Selected");
        }

        // Print output
        Console.WriteLine($"The result is: {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press Enter to continue ...");
        Console.ReadLine();
    }

}



// Method definition

void PrintMenu()
{
    Console.Clear();
    // Prompt for user input
    Console.WriteLine("Please select an operation");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci");
    Console.WriteLine("\n0. Exit");
}

int AddNumbers(int num1, int num2)
{
   return num1 + num2;
}

int SubtractNumbers(int num1, int num2)
{
    return num1 - num2;
}

int Product(int num1, int num2)
{
    return num1 * num2;
}

int Quotient(int num1, int num2)
{
    return num1 / num2;
}

int Fibonaci(int num1, int num2)
{
    int answer = 0;
    for (int i = num1; i <= num2; i++)
    {
        answer += i;
    }
    return answer;
}