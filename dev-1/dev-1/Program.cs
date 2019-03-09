using System;

namespace dev_1
{
    class Program
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        static void Main(string[] args)
        {
            SubsequenceCollector myCollector = new SubsequenceCollector();
            myCollector.Collect(args[0]);
            myCollector.ShowSubsequences();
            Console.ReadLine();
        }
    }
}
