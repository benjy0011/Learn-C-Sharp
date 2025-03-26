//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



Console.WriteLine("************ - Methods - ************");

// void methods - complete a task without returning a value
void PrintName()
{
    // Method code
    Console.WriteLine("Trevor Williams");
}


// value returning methods - return a value after an operation
int GetFiveYearsAgo()
{
    return DateTime.Now.AddYears(-5).Year;
}


// methods with params
void PrintNameWithParams(string name)
{
    // Method code
    Console.WriteLine($"Name: {name}");
}

int GetYearDifferenceWithParams(int year)
{
    return DateTime.Now.Year - year;
}


// methods with optional parameters - param with default value
int GetFutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}

// methods with nullable parameters
void PrintNameNullableParam(string? name, int? count = 2)
{
    //if (string.IsNullOrWhiteSpace(name))
    //{
    //    name = "Default Name";
    //}

    name ??= "Default Name"; // short hand - if null then assign the value

    //if (!count.HasValue)
    //{
    //    count = 1;
    //}

    count ??= 2;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}


/* Function Calls */
PrintName();
Console.WriteLine( GetFiveYearsAgo().ToString() );
PrintNameWithParams("Ben");
Console.WriteLine( GetYearDifferenceWithParams(2015).ToString() );


var pastYear1 = GetFutureOrPastYear();
var pastYear2 = GetFutureOrPastYear(2);

Console.WriteLine(pastYear1.ToString() + " | " + pastYear2.ToString());


PrintNameNullableParam(name: "Name");
PrintNameNullableParam(null);
PrintNameNullableParam(null, null);