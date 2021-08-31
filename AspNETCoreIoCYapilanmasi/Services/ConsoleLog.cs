using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AspNETCoreIoCYapilanmasi.Services.Interface;

namespace AspNETCoreIoCYapilanmasi.Services
{
    public class ConsoleLog:ILog
    {
        public ConsoleLog(int a)
        {

        }
        public void Log()
        {
            Console.WriteLine("Console a loglama işlemi gerçekleştirildi..");
        }

    }
}
