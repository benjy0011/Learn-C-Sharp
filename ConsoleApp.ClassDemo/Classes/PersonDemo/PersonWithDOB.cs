﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ClassDemo.Classes.PersonDemo;

// partial allow you to split the same class into different file
public partial class Person
{
    public Person(string firstName, string lastName, DateOnly dob)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dob;
    }

    public int GetAge()
    {
        var age = DateTime.Now.Year - DateOfBirth.Year;
        return age;
    }

    public string GetAge(int year)
    {
        var age = year - DateOfBirth.Year;
        return age.ToString();
    }
}
