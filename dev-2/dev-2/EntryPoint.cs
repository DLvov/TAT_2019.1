﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            var phonemeBuilder = new PhonemeBuilder();
            phonemeBuilder.BuildPhoneme(args[0]);
        }
    }
}
