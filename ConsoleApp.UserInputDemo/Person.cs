﻿// Declare variables
public class Person
{
    public Person(DateOnly dob)
    {
        _age = DateTime.Now.Year - dob.Year ;
        DateOfBirth = dob;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public decimal Salary { get; set; }

    public char Gender { get; set; }

    public bool IsWorking { get; set; }

    private readonly int _age;

    public int GetNumberOfWorkingYearsRemaining()
    {
        // Ctrl + r + r  => replace all
        return Constants.RetirementAge - _age;
    }

    public DateOnly GetEstimatedRetirementDate()
    {
        return DateOnly.FromDateTime(DateTime.Now.AddYears(
            GetNumberOfWorkingYearsRemaining()
            ));
    }

    public int GetAge()
    {
        return _age;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
