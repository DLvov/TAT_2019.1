using System;
using System.Collections.Generic;

namespace dev_3
{
    /// <summary>
    /// This class can add employees in team and show team information.
    /// </summary>
    class Team
    {
        private List<Employee> employees = new List<Employee>();
        private int _juniorCount = 0;
        private int _middleCount = 0;
        private int _seniorCount = 0;
        private int _leadCount = 0;
        private int _generalSalary = 0;
        private int _generalPerformance = 0;

        /// <summary>
        /// This method adds employee in the team.
        /// </summary>
        /// <param name="employee">Employee who is added to the team</param>
        public void AddEmployee(Employee employee)
        {
            if (employee is Lead)
            {
                _leadCount++;
            }
            else if (employee is Senior)
            {
                _seniorCount++;
            }
            else if (employee is Middle)
            {
                _middleCount++;
            }
            else if (employee is Junior)
            {
                _juniorCount++;
            }
            employees.Add(employee);
            _generalSalary += employee.Salary;
            _generalPerformance += employee.Performance;
        }
        
        /// <summary>
        /// This method displays information about team.
        /// </summary>
        public void DisplayTeamInformation()
        {
            Console.WriteLine($"Team consist: {_juniorCount} Juniors, {_middleCount} Middles, {_seniorCount} Seniors, {_leadCount} Team Leads");
            Console.WriteLine($"General salary of team: {_generalSalary}");
            Console.WriteLine($"General performance of team: {_generalPerformance}");
        }
    }
}