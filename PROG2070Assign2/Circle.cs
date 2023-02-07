using System;
using System.Collections.Generic;
using System.Text;

namespace PROG2070Assign2
{
    public class Circle
    {
        private int pvtradius { get; set; }
        public int InputRadius;
        public Circle() //default constructor
        {
            pvtradius = 1;
        }

        // Parameterised Constructor
        public Circle ( int InputRadius)
        {
            pvtradius= InputRadius;
        }
        public int GetRadius()
        {
            return pvtradius;
        }

        public void SetRadius(int inputRadius)
        {
            pvtradius = inputRadius;
        }

        public double GetCircumference()
        {

            return 2 * 3.14 * this.pvtradius;
        }

        public double GetArea()
        {
            return 3.14 * pvtradius * pvtradius;
        }

    }
}
