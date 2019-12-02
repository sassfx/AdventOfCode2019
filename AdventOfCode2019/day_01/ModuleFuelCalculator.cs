using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019.day_01
{
    public class ModuleFuelCalculator
    {
        public int CalculateFuelNeededRecursively(int mass)
        {
            var total = 0;
            var current = mass;

            while ((current = CalculateFuelNeeded(current)) > 0)
            {
                total += current;
            }

            return total;
        }

        public int CalculateFuelNeeded(int mass)
        {
            return (mass / 3) - 2;
        }
    }
}
