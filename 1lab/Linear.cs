using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erofeev
{
    internal class Linear
    {
        protected List<float> x;
        public List<float> LinearGetResult(float a, float b)
        {
            if (a == 0)
            {
                throw new ArgumentException("Уравнение не имеет корней");
            }
            return x = new List<float>() { b / a };
        }
    }
}
