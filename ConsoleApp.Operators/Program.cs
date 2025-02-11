// See https://aka.ms/new-console-template for more information

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int num2 = 0;
Console.Write("Please eenter the second number: ");
string numberEntered = Console.ReadLine();
num2 = Convert.ToInt32(numberEntered);


/*
    Math Operations and Operators
*/

// Add numbers
int sum = (int)(num1 + num2);

// Multiply
int product = num1 * num2;

// Division
int quotient = num1 / num2;

// Subtraction
int difference = num1 - num2;

// Modulus
int mod = num1 % num2;

Console.WriteLine("\n****************** Math Results ******************");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Modulus: {mod}");


/*
    Logic Operations and Operators
*/

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterOrEqual = num1 >= num2;
bool isLesserOrEqual = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("\n****************** Logic Results ******************");
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Or Equal: {isGreaterOrEqual}");
Console.WriteLine($"Is Lesser Or Equal: {isLesserOrEqual}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");


/*
    Assignment Operations and Operators
 */
Random random = new Random();
int randomValue = random.Next(1, 11);


Console.WriteLine("\n****************** Assignment Results ******************");
Console.WriteLine();
num1 += randomValue;
Console.WriteLine($"Num 1 increased by {randomValue}: {num1}");
num1 -= randomValue;
Console.WriteLine($"Num 1 reduced by {randomValue}: {num1}");
num1 /= randomValue;
Console.WriteLine($"Num 1 divided by {randomValue}: {num1}");
num1 %= randomValue;
Console.WriteLine($"Num 1 mod by {randomValue}: {num1}");
num1 *= randomValue;
Console.WriteLine($"Num 1 multiplied by {randomValue}: {num1}");
