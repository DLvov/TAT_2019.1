using System;

namespace dev_2
{
    class EntryPoint
    {
        /// <summary>
        /// Entry point of programm
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        /// <returns 0>Normal work</returns>
        /// <returns 1>String length is shorter than 2 characters</returns>
        /// <returns 2>Something wrong</returns>
        static int Main(string[] args)
        {
            try
            {
                var myPhonemeBuilder = new PhonemeBuilderFromWord(args[0]);
                myPhonemeBuilder.BuildAndShowPhoneme();
                return 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("String length is shorter than 2 characters!");
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
