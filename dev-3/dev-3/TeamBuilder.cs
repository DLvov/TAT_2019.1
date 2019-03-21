using System;

namespace dev_3
{
    abstract class TeamBuilder
    {
        public virtual Team Choose(int customerMoney, int neededPerformance) { return null; }
    }
}