using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPropeller
{
    public class CalcController
    {
        public double Diameter { get; set; }
        public double Step { get; set; }
        public CalcController()
        {
                
        }
        public bool checkFields(double diameter, double step)
        {
            
            return true;
        }
    }
}
