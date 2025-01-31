using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferdinand_Project_Area_Calculator
{
    internal class Compute2
    {
        public double Length;
        public double Width;
        public Compute2(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public double Rectangle(double Length, double Width)
        {
            return 2 * (Width * Length);
        }
    }
}
