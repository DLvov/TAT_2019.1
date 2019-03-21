namespace dev_3
{
    class FirstCriterionTeamBuilder : TeamBuilder
    {
        public override Team Choose(int customerMoney, int neededPerformance)
        {
            Team team = new Team();
            while (customerMoney > 0)
            {
                if (customerMoney > 1800)
                {
                    team.AddEmployee(new Lead());
                    customerMoney -= 1800;
                }
                else if (customerMoney > 1500)
                {
                    team.AddEmployee(new Senior());
                    customerMoney -= 1500;
                }
                else if (customerMoney > 800)
                {
                    team.AddEmployee(new Middle());
                    customerMoney -= 800;
                }
                else if (customerMoney > 500)
                {
                    team.AddEmployee(new Junior());
                    customerMoney -= 500;
                }
                else
                {
                    return team;
                }
            }
            return null;
        }
    }
}