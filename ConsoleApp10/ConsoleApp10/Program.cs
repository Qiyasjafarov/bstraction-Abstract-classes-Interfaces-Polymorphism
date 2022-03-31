using ConsoleApp10.Models;
using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee("Vaif","Mamedov",55,50,30);
            //Console.WriteLine(e.CalculateSalary() );
            Student s = new Student("Vaif", "Mamedov", 25, 100, 100);
            //Console.WriteLine(s.AGE);
            s.ExamResult();

        }
    }
}
