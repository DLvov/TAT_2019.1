using System;

namespace dev_3
{
    class EntryPoint
    {
        /// <summary>
        /// Entry point of programm.
        /// </summary>
        /// <param name="args">Arguments from command line</param>
        /// <param name="args[0]">Customer money</param>
        /// <param name="args[1]">Needed performance</param>
        /// <param name="args[2]">Criterion of choosing team</param>
        /// <returns 0>Normal work</returns>
        /// <returns 1>Incorrect input</returns>
        /// <returns 2>Something error</returns>
        static int Main(string[] args)
        {
            try
            {
                if (args.Length < 3)
                {
                    throw new FormatException("Incorrect input!");
                }

                TeamBuilder myTeamBuilder;
                if (args[2] == "1")
                {
                    myTeamBuilder = new FirstCriterionTeamBuilder();
                }
                else if (args[2] == "2")
                {
                    myTeamBuilder = new SecondCriterionTeamBuilder();
                }
                else if (args[2] == "3")
                {
                    myTeamBuilder = new ThirdCriterionTeamBuilder();
                }
                else
                {
                    throw new FormatException("Unknown criterion for team building!");
                }
                Team myTeam = myTeamBuilder.Choose(int.Parse(args[0]), int.Parse(args[1]));
                myTeam.DisplayTeamInformation();
                return 0;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 2;
            }
        }
    }
}
