using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1lab
{
    internal class AClass : BClass
    {
        public AClass(Object b, Object _c, Object _d) : base(b)
        {
            c = _c;
            d = _d;
        }
        protected Object c;
        protected Object d;
    }
}
