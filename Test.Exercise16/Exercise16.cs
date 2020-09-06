namespace Test.Exercise16
{
    public class Exercise16
    {
        public double NetSalary(double grossSalary)
        {
            if (grossSalary <= 600.00)
            {
                return grossSalary;
            }
            else if (grossSalary <= 1200.00)
            {
                return (grossSalary - (grossSalary * 0.2));
            }
            else if (grossSalary <= 2000.00)
            {
                return (grossSalary - (grossSalary * 0.25));
            }
            else
            {
                return (grossSalary - (grossSalary * 0.3));
            }
        }
    }
}
