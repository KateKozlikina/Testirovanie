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

        public object MileToMetr(double v)
        {
            return v / MetrTOMile;
        }
        public object MetrToFt(double v)
        {
            return v * MetrTOFt;
        }
        public object FtToMetr(double v)
        {
            return v / MetrTOFt;
        }
        public object MileToFt(double v)
        {
            return v * MileTOFt;
        }
        public object FtToMile(double v)
        {
            return v / MileTOFt;
        }
    }
}
