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

    }

}
