using System;
using System.Text;

namespace dev_2
{
    /// <summary>
    /// Entry point of the program.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// This method builds a phonemes of inputed words
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        /// <returns 0>Normal work</returns>
        /// <returns 1>String length is shorter than 2 characters</returns>
        /// <returns 2>Something wrong</returns>
        static int Main(string[] args)
        {
            try
            {
                foreach (var arg in args)
                {
                    var myPhonemeBuilder = new PhonemeBuilderFromWord(arg.ToString());
                    myPhonemeBuilder.BuildAndShowPhoneme();
                }
                
                return 0;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
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
