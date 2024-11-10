using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcPropeller.Propeller
{
    public class Section
    {
        public List<Coordinates> point = new List<Coordinates>();
    }
    public struct Coordinates
    {
        public double x, y;
    }
}
