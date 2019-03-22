using System;

namespace dev_3
{
    /// <summary>
    /// This class builds a team by the first criterion (max performance for customers money).
    /// </summary>
    class FirstCriterionTeamBuilder : TeamBuilder
    {
        public override Team Choose(int customerMoney, int neededPerformance)
        {
            if (customerMoney < 500)
            {
                throw new FormatException("We cannot create a team without money, the junior's salary is 500!");
            }
            Team team = new Team();
            while (customerMoney > 0)
            {
                if (customerMoney >= 1800)
                {
                    team.AddEmployee(new Lead());
                    customerMoney -= 1800;
                }
                else if (customerMoney >= 1500)
                {
                    team.AddEmployee(new Senior());
                    customerMoney -= 1500;
                }
                else if (customerMoney >= 800)
                {
                    team.AddEmployee(new Middle());
                    customerMoney -= 800;
                }
                else if (customerMoney >= 500)
                {
                    team.AddEmployee(new Junior());
                    customerMoney -= 500;
                }
                else
                {
                    break;
                }
            }
            return team;
        }
    }
}