using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Circle : Shape//Inherit Class Shape
    {
        public override double GetArea()//override เขียนทับ method GetArea in Class Shape
        {
            double radius = (6.0 * 6.0);
            double area = (Math.PI * radius);
            return area;
        }
    }
}
