using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.ClassDemo.Utils;

namespace ConsoleApp.ClassDemo.Classes.PersonDemo;

public class Student : Person
{
    public void GenerateStudentIdNumber()
    {
        _idNumber = PersonHelper.GenerateIdHelper("STU-");
    }
}
