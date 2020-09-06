using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test.Exercise7
{
    public class Exercise7
    {
        public double SpentMoneyWithCigarrets(double cigarettesPerDay, double cigarettesPrice,  double years)
        {
            return Math.Round((365 * years) * cigarettesPerDay * (cigarettesPrice / 20));

        }

    }
}
