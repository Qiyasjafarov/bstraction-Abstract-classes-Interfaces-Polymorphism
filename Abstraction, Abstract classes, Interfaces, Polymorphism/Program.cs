using Abstraction__Abstract_classes__Interfaces__Polymorphism.Models;
using System;

namespace Abstraction__Abstract_classes__Interfaces__Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 1;
            while (key >= 1 && key <= 2)
            {
                Console.WriteLine("1,2,3");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:

                        Square s = new Square(5);
                        s.CalcArea();
                        break;
                    case 2:

                        Rectangular r = new Rectangular(5, 10);
                        r.CalcArea();
                        break;
                    case 3:
                        Console.WriteLine("Quit");
                        break;
                }
            }
        }
    }
}
