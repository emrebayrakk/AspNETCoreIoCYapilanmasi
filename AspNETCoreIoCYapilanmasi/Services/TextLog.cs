﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNETCoreIoCYapilanmasi.Services.Interface;

namespace AspNETCoreIoCYapilanmasi.Services
{
    public class TextLog : ILog
    {
        public void Log()
        {
            Console.WriteLine("Text dosyasına loglama işlemi gerçekleştirildi..");
        }
    }
}
