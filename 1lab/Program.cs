using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CClass c = new CClass();

            BClass b = new BClass(new CClass());
            AClass a = new AClass(new BClass(new CClass()), new CClass(), new CClass());
            
        }
    }
}
