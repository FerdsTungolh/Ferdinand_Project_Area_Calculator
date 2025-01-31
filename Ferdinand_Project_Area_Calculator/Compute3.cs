using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferdinand_Project_Area_Calculator
{
    internal class Compute3
    {
        public double BaseLength;
        public double Height;
        public Compute3(double BaseLength, double Height)
        {
            this.BaseLength = BaseLength;
            this.Height = Height;
        }

        public double Triangle(double BaseLength, double Height)
        {
            return 0.5 * (BaseLength * Height);
        }
    }
}
