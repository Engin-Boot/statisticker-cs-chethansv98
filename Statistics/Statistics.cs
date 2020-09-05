using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers) {
            Stats statsResult = new Stats();
            if (numbers.Count == 0)
            {
                statsResult.average = Double.NaN;
                statsResult.max = Double.NaN;
                statsResult.min = Double.NaN;
            }
            else
            {
                statsResult.average = numbers.Average();
                statsResult.min = numbers.Min();
                statsResult.max = numbers.Max();
            }
            return statsResult;
        }
    }
}
