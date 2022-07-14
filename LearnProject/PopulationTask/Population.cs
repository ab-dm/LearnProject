using System;

namespace LearnProject.PopulationTask
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (percent <= 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Value of percents cannot be less then 0% or more then 100%.");
            }

            if (initialPopulation <= 0)
            {
                throw new ArgumentException("Initial population cannot be less or equals zero.", nameof(initialPopulation));
            }

            if (visitors <= 0)
            {
                throw new ArgumentException("Count of visitors cannot be less zero.", nameof(visitors));
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.", nameof(currentPopulation));
            }

            if (initialPopulation > currentPopulation)
            {
                throw new ArgumentException("Current population cannot be less than initial population.", nameof(currentPopulation));
            }

            int sum;
            int years = 0;

            while (initialPopulation < currentPopulation)
            {
                sum = (int)(initialPopulation * percent / 100) + visitors;

                initialPopulation += sum;

                years++;
            }

            return years;
        }
    }
}
