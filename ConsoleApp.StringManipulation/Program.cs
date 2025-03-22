// See https://aka.ms/new-console-template for more information
Console.WriteLine("******** - String Manipulation ********");


// Initialize with a regular string literal
string s1 = "This is a literal string";
String s2 = "This is a literal string";

// Declare wihtout initializing. (possible null execption)
string s3;

// Initialize to null. (possible null execption)
string? s4 = null; // nullable

// Initialize as an empty string
string s5 = string.Empty; // ""
string s6 = " "; // this is not an empty string

// Escape sequences and characters
string sentence = "She said, \"I have your phone\" \r\n This is the next line ";

// Verbatim string literal.
string oldPath = "C:\\program files\\programfolder\\";
string newPath = @"C:\program files\programfolder\";

// Use a concat string to prevent modification to a string
const string path = "C:\\program files\\programfolder\\";
// path = "new value"; // Illegal
s1 = "A new string"; // Legal

// Raw string literals
string rawLiteral = """ She said, "I have your phone" """;
string rawLiteral_1 = """ 
    She said, "I have your phone"
    This is the next line
    And another one
    Path = "C:\program files\programfolder\"
    """;

// Review concatenation and interpolation
s1 = s1 + s2;
s1 += s2;
string newString = $"{s1} {s2} Some random literal text";
string newString_1 = String.Format("Literal string {0} {1}", s1, s2);

/* String manipulation methods and properties. Sometimes it just assessment */

// Null or empty checks 
// find the length of a string
Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");

if (!string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
}

// Substrings
string subString = s1.Substring(0, s1.Length); // (starting point, how long from the starting point)
Console.WriteLine(subString);

// Splitting strings
var splitStrings = s2.Split(' '); // delimiter is ' ', split by ' '
foreach (var item in splitStrings)
{
    Console.WriteLine(item);
}


// Replace
string replacements1 = s1.Replace('s', 'V'); // (old, new)
Console.WriteLine($"{s1} | {replacements1}");

// Convert to string
string salary = 4123.2.ToString();
Console.WriteLine(salary);

// Changing Formatting
int value = 12345;
Console.WriteLine($"{nameof(salary)}: {salary:C}");
Console.WriteLine($"{nameof(value)}: {value.ToString("C")}");

// String comparison
string a = "hello";
string b = "hello";
bool areEqual = a == b;  // true

areEqual = string.Equals(a, b);  // true, using default comparison (usually ordinal)
// For a case-insensitive comparison:
bool areEqualIgnoreCase = string.Equals(a, b, StringComparison.OrdinalIgnoreCase);

int result = String.Compare(a, b, StringComparison.Ordinal);
// result is 0 if a equals b.

areEqual = StringComparer.OrdinalIgnoreCase.Equals(a, b);
