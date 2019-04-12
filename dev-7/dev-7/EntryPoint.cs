﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new FormatException("The program must accept two XML file names!");
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong!");
            }
        }
    }
}
