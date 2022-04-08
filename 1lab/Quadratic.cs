using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;

namespace Erofeev
{
    internal class Quadratic : Linear
    {
        protected List<float> x;
        protected float getDisc(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }

        public List<float> solve(float a, float b, float c)
        {
            if(a == 0)
            {
                return LinearGetResult(b, c);
            }

            float _forX = getDisc(a, b, c);

            if (_forX < 0)
            {
                ErofeevLog.I().log("Дискрименант < 0");
                throw new ErofeevException("Корни не определены");
            }

            x = new List<float>();

            if (_forX > 0)
            {
                _forX = (float)Math.Sqrt(_forX);
                ErofeevLog.I().log("This is quadratic equation");
                return x = new List<float>()
                {
                    (-b + _forX) / (2 * a),
                    (-b - _forX) / (2 * a)
                };
            }
            return x = new List<float>()
            {
                -b / 2 * a
            };
        }
    }
}
