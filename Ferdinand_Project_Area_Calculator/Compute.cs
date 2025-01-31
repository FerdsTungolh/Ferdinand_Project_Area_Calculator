using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferdinand_Project_Area_Calculator
{
    internal class Compute
    {

        public double Radius;
        public Compute(double Radius) 
        { 
         this.Radius = Radius;
        }
        public double Circle(double Radius)
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
