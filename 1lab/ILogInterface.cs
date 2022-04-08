using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    internal interface ILogInterface
    {
        ILogInterface log(string str);
        ILogInterface write();

    }
}
