using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTDD
{
public    class Converter
    {
        static double MetrTOMile = 0.0006214;
        static double MetrTOFt = 3.281;
        static double MileTOFt = 5280;
        public double MetrToMile(double metr)
        {
            return metr * MetrTOMile;
        }
    }
}
