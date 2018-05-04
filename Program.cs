using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Log logo=new Log("logeehher","Hej Gbbe",10101);
            logo.EventLogWritter();
        }
    }
}
