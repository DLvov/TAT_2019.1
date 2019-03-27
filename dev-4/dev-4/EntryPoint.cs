using System;

namespace dev_4
{
    /// <summary>
    /// This class is entry point of the programm.
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// This method creates a new discipline.
        /// </summary>
        /// <param name="args">Arguments of the programm.</param>
        static void Main(string[] args)
        {
            try
            {
                var discipline = new Discipline("Physics");
                discipline.AddLecture(1);
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
