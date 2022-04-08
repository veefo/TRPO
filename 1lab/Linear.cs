using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erofeev;

namespace Erofeev
{
    internal class Linear
    {
        protected List<float> x;
        public List<float> LinearGetResult(float a, float b)
        {
            if (a == 0)
            {
                throw new ErofeevException("Уравнение не имеет корней");
            }
            ErofeevLog.I().log("This is linear equation");
            return x = new List<float>() { b / a };
        }
    }
}
