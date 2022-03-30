using Abstraction__Abstract_classes__Interfaces__Polymorphism.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction__Abstract_classes__Interfaces__Polymorphism
{
    class Rectangular:Figure
    {
        private double _width;
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }
        private double _length;
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
            }
        }
        public Rectangular(double width,double length)
        {
            Width = width;
            Length = length;
        }

        public override void CalcArea()
        {
            Console.WriteLine("rectengular");
        }
    }
}
