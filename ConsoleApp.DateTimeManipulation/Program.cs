// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Globalization;

Console.WriteLine("********* - DateTime Manipulation - *********");

// Empty DateTime
DateTime date = new DateTime(); // declaration of new object item

// Create a DateTime from date and time
var dateofBirth = new DateTime(1980, 12, 25);
Console.WriteLine(dateofBirth.ToString());
Console.WriteLine($"My Dob is : {dateofBirth}"); // Like this no need to convert to string

var exactTimeOfBirth = new DateTime(1980, 12, 25, 14, 45, 25, DateTimeKind.Local);
Console.WriteLine($"My Dob is : {exactTimeOfBirth}");

Console.WriteLine($"Day of Week: {dateofBirth.DayOfWeek}");
Console.WriteLine($"Day of Year: {dateofBirth.DayOfYear}");
Console.WriteLine($"Time of Day: {exactTimeOfBirth.TimeOfDay}");
Console.WriteLine($"Ticks: {exactTimeOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactTimeOfBirth.Kind}");

// Create a DateTime from current timestamp
DateTime now = DateTime.Now; // looking at the machine that running this code
Console.WriteLine($"Now -> {now}");

// Create a DateTime from a String
Console.WriteLine("What is your DOB (dd/mm/yyyy): ");
//string dob = Console.ReadLine();
string dob = "24/02/2001";

var userDob = DateTime.Parse( dob );
Console.WriteLine(userDob.ToString());

// Change Format DateTime
Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("MMM dd, yyyy")}");

// Add Additional Time
Console.WriteLine($"One hour from now is: " + now.AddHours(8));
Console.WriteLine($"One day from now is: " + now.AddDays(-7));


// UTC - Coordinated Universal Time
var utcNow = DateTime.UtcNow;
Console.WriteLine($"Now Date Time: {now}");
Console.WriteLine($"UTC Date Time: {utcNow}");


// DateTimeOffSet and TimeZone Info
var timezone = TimeZoneInfo.Local.GetUtcOffset( utcNow );
Console.WriteLine($"User Time Zone: {timezone}");

var dto = new DateTimeOffset(now, timezone);
Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}");

var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
Console.WriteLine($"Action was completed in India at: {indiaDateTime}");

// Date Only
var dateOnly = new DateOnly(2001, 2, 24);
Console.WriteLine($"{nameof(dateOnly)}: {dateOnly}");
var theDateOnly = DateOnly.ParseExact(dateOnly.ToString(), "dd/M/yyyy", CultureInfo.InvariantCulture); // must match the format
Console.WriteLine($"{nameof(theDateOnly)}: {theDateOnly}");


// TimeOnly
var timeOnly = new TimeOnly(12, 12, 12);
Console.WriteLine($"{nameof(timeOnly)}: {timeOnly}");
Console.WriteLine($"{nameof(timeOnly)}: {timeOnly: hh mm tt}");


// Date Time comparisons
var date1 = new DateTime(1985, 11, 23);
var date2 = new DateTime(1985, 1, 20);

Console.WriteLine($" Is '{nameof(date1)}' equal? {date1 == date2}");
Console.WriteLine($" Is '{nameof(date1)}' equal? {date1.Equals(date2)}");
Console.WriteLine($" Is '{date2}' after? {date2 > date1}");
Console.WriteLine($" Is '{date2}' before? {date2 < date1}");