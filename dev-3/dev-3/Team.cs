using System;
using System.Collections.Generic;

namespace dev_3
{
    class Team
    {
        private List<Employee> employees;
        private int _juniorCount = 0;
        private int _middleCount = 0;
        private int _seniorCount = 0;
        private int _leadCount = 0;
        private int _generalSalary = 0;
        private int _generalPerformance = 0;

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
            else
            {
                throw new FormatException();
            }
            employees.Add(employee);
            _generalSalary += employee.Salary;
            _generalPerformance += employee.Performance;
        }
    }
}