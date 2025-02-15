// See https://aka.ms/new-console-template for more information
Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());


// Decide to print pass or fail based on input
if(grade > 50)
{
    Console.WriteLine("Student has passed");
}
else
{
    Console.WriteLine("Student has failed");
    Console.WriteLine("Please recommend student to student affair's office");
}

Console.WriteLine("Thankyou for using this program");


Console.WriteLine("*************************************");

if(grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if (grade >= 50 && grade <= 65)
{
    Console.WriteLine("C+");
}
else if (grade <= 85)
{
    Console.WriteLine("B+");
}
else
{
    Console.WriteLine("A - Good job");
}

Console.WriteLine("*************************************");

string passStatus = grade >= 50 ? "Pass" : "Fail";

Console.WriteLine("*************************************");

Console.Write("Please enter the day of the week: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Chewsday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("Error");
        break;
}