using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.ClassDemo.Utils;

namespace ConsoleApp.ClassDemo.Classes.PersonDemo;

public class Teacher : Person
{
    
    public void GenerateTeacherIdNumber()
    {
        // _idNumber is private in Person initially before protected
        //_idNumber = "TCH-" + GetRandomNumber();
        _idNumber = PersonHelper.GenerateIdHelper("TCH-");
    }
}
