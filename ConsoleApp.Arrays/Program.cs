// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Declare Fixed Size Array
int[] grades = new int[5]; // [num] is the size
// Index : 0, 1, 2, 3, 4


// Add values to fixed size array
grades[0] = 45;
grades[1] = 25;
grades[2] = 38;
grades[3] = 45;
grades[4] = 54;

for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values in Fixed size Array 
Console.WriteLine("The Grades you have entered are: ");
foreach (var grade in grades)
{
    Console.WriteLine(grade);
}

// Declare Variable Sized Array
string[] studentNames = { "Newton", "Joshua", "Bryant" };

// Add values to Variable Sized Array
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}