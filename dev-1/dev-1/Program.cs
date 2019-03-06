using System;

namespace dev_1
{
    class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        static void Main(string[] args)
        {
            subsequenceCollector myCollector = new subsequenceCollector();
            myCollector.collect(args[0]);
            myCollector.showSubsequences();
            Console.ReadLine();
        }
    }
}
