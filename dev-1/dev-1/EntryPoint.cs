using System;

namespace dev_1
{
    class EntryPoint
    {
        /// <summary>
        /// Entry point of program.
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        /// <returns 0>Correct work</returns>
        /// <returns 1>Inputed string is shorter than 2 chars</returns>
        /// <returns 2>Something wrong</returns>

        static int Main(string[] args)
        {
            try
            {
                string separator = " ";
                var myCollector = new SubsequenceCollector(String.Join(separator, args));
                myCollector.CollectAndShowSubsequences();
                return 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("Inputed string is shorter than 2 chars!");
                return 1;
            }
            catch (Exception)
            {
                Console.WriteLine("Something wrong!");
                return 2;
            }

        }
    }
}
