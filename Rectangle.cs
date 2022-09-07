using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Abstract
{
    internal class Rectangle:Shape
    {
        int l, b;
    public Rectangle(int length, int breadth)
        {
            l = length;
            b = breadth;
        }
        public override int Area()
        {
            return l*b;   
        }

    }
}
