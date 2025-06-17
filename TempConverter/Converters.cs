using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    public class Converters
    {
        public double f2c(double f)
        {
            return (f - 32) * 5 / 9;
        }

        public double c2f(double c)
        {
            return (c * 9 / 5) + 32;
        }

        public double k2c(double k)
        {
            return k - 273.15;
        }

        public string cToText(double c)
        {
            if (c < 10)
                return "Cold";
            else if (c <= 20)
                return "Warm";
            else
                return "Hot";
        }
    }
}

