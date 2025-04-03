// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ConsoleApp.ClassDemo.Classes.PersonDemo;
using ConsoleApp.ClassDemo.Classes.ShapeDemo;

Person person; // this will be null in default

Person baby = new Person();
baby.LastName = "Thompson";
baby.FirstName = "Theresa";
baby.DateOfBirth = new DateOnly(2023, 10, 29);

//Console.WriteLine($"{baby.FirstName} {baby.LastName}");
baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

Console.WriteLine($"\n===Person 2====\n");

var person1 = new Person("Developer", "One", new DateOnly(2001, 2, 24));
person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Developer", "Two", "123456789");
person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();

var person2IdNumber = person2.GetIdNumber();
Console.WriteLine(person2IdNumber);


Console.WriteLine($"\n===Teacher====\n");

// Inheritance
var teacher = new Teacher();
teacher.LastName = "Lim";
teacher.FirstName = "Teacher";
teacher.DateOfBirth = new DateOnly(1993, 10, 29);

teacher.PrintFullName(); 
teacher.PrintInitials();
teacher.GenerateTaxNumber();

teacher.GenerateTeacherIdNumber();
var teacherIdNumber = teacher.GetIdNumber();
Console.WriteLine(teacherIdNumber);

Console.WriteLine($"\n===Student====\n");

Student student = new();
student.LastName = "Tan";
student.FirstName = "Student";
student.DateOfBirth = new DateOnly(2003, 10, 29);

student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();

student.GenerateStudentIdNumber();
var studentIdNumber = student.GetIdNumber();
Console.WriteLine(studentIdNumber);


Console.WriteLine($"\n===Square====\n");

// Abstract
//Polygon polygon = new Polygon(); // compile error - cuz this is a abstract class

Rectangle rectangle = new(10, 20);
var rectangleArea = rectangle.Area();

Square square = new(50);
var squareArea = square.Area();

//var sq = new Square();
//sq.Width = 12;
var sq = new Square   // new elegant way
{
    Width = 12
};
Console.WriteLine(sq.Area());

var sq2  = new Square(11);
Console.WriteLine(sq2.Area());



Console.WriteLine($"\n===Cuboid====\n");

// Interface
Cuboid cuboid = new(1, 5, 7);
var cuboidArea = cuboid.Area();
var cuboidVolume =  cuboid.Volume();
var cuboidPerimeter = cuboid.Perimeter();
Console.WriteLine($"Cuboid area is: {cuboidArea}");
Console.WriteLine($"Cuboid volumn is: {cuboidVolume}");
Console.WriteLine($"Cuboid perimeter is: {cuboidPerimeter}");


// shortcut for multi-select "Alt + Shift"
// "Alt + Shift + ."
Sphere sphere = new(7);
var sphereCircumference = sphere.Circumference();
var sphereVolume = sphere.Volume();
Console.WriteLine($"Sphere volumn is: {sphereVolume}");
Console.WriteLine($"Sphere circumference is: {sphereCircumference}");