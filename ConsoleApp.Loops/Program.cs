// See https://aka.ms/new-console-template for more information


for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine("*********************************************");

int counter = 0;
while (counter < 10)
{
    Console.WriteLine(counter++);
}

Console.WriteLine("*********************************************");


int sum = 0;
int inputNum = 0;
Console.WriteLine("Please enter number to be summed up. (-1 to stop)");
while (inputNum != -1)
{
    sum += inputNum;
    inputNum = Convert.ToInt32(Console.ReadLine());  
}

Console.WriteLine($"Your sum is : {sum}");


Console.WriteLine("*********************************************");

int sum2 = 0;
int num2 = 0;
Console.WriteLine("Please enter number to be summed up. (-1 to stop)");
do
{
    sum2 += num2;
    num2 = Convert.ToInt32(Console.ReadLine());
}
while (num2 != -1);