using System;

namespace dev_3
{
    /// <summary>
    /// This class builds a team by the third criterion (minimum of workers, except juniors for needed performance).
    /// </summary>
    class ThirdCriterionTeamBuilder : TeamBuilder
    {
        public override Team Choose(int customerMoney, int neededPerformance)
        {
            if (neededPerformance < 1)
            {
                throw new FormatException("We can't do team with performance less than 1!");
            } 
            Team team = new Team();
            while (neededPerformance > 0)
            {
                if (neededPerformance >= 7)
                {
                    team.AddEmployee(new Lead());
                    neededPerformance -= 7;
                }
                else if (neededPerformance >= 5)
                {
                    team.AddEmployee(new Senior());
                    neededPerformance -= 5;
                }
                else if (neededPerformance >= 2)
                {
                    team.AddEmployee(new Middle());
                    neededPerformance -= 2;
                }
                else
                {
                    team.AddEmployee(new Middle());
                    neededPerformance -= 2;
                }
            }
            return team;
        }
    }
}