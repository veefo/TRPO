using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;

namespace Erofeev
{
    internal class ErofeevLog : LogAbstract, ILogInterface
    {
        List<string> logList = new List<string>();
        public ILogInterface log(string str)
        {
            logList.Add(str);
            return this;
        }

        public ILogInterface write()
        {
            writeConsole(logList.ToArray());
            return this;
        }


        private static ErofeevLog instance;

        private ErofeevLog() { }
        public static ErofeevLog I()
        {
            if(instance == null)
            {
                instance = new ErofeevLog();
            }
            return instance;
        }
    }
}
