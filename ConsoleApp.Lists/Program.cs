// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Declare a List
List<int> grades = new List<int>();
// var grades = new List<int>();  // also can

// Add values to list 
grades.Add(45);

// or 
//List<int> gradesList<int> grades = [45];


Console.WriteLine(grades[0]);


// Prefer to use while - no limit
int grade = 0;
do
{
    Console.Write("Enter Grade: ");
    grade = Convert.ToInt32(Console.ReadLine());
    if (grade != -1)
    {
        grades.Add(grade);
    }
} while (grade != -1);


// Print values in list - foreach
Console.WriteLine("Printing grades via foreach");
foreach (int g in grades)
{
    Console.WriteLine(g);
}