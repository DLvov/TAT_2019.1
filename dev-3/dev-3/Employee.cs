using System;

namespace dev_3
{
    abstract class Employee
    {
        private static int _salary;
        private static int _performance;

        public int Salary { get; }
        public int Performance { get; }
    }
}