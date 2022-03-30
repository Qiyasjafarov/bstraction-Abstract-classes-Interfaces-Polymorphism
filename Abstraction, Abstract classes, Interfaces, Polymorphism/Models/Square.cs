using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction__Abstract_classes__Interfaces__Polymorphism.Models
{
    class Square:Figure
    {
        private double _side;
        public double Side 
        { 
            get 
            {
                return _side;
            } 
            set 
            {
                if (value > 0)
                {
                    _side = value;
                }
            } 
        }
        public Square(double side)
        {
            Side = side;
        }

        public override void CalcArea()
        {
            Console.WriteLine("square");
        }
    }
}
