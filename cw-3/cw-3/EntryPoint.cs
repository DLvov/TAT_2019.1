using System;

namespace cw_3
{
    /// <summary>
    /// This class is entry point of the programm
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// This method creates a triangle and displays it sqare on the console.
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        static void Main(string[] args)
        {
            try
            {
                Point a = new Point(1, 2);
                Point b = new Point(2, 2);
                Point c = new Point(3, 3);
                Builder mainBuilder = new RectangleBuilder(new EqualSidesBuilder(new SimpleBuilder(null)));
                Triangle triangle = mainBuilder.CreateTriangle(a, b, c);
                Console.WriteLine(triangle.GetSquare());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Something error!");
            }
        }
    }
}
