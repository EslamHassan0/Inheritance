using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Manager:Employee
    {

        private const decimal AllowanceRate = 0.05m;
        public override decimal Calculate()
        {
            return base.Calculate() + CalculateAllowance();
        }
        private decimal CalculateAllowance()
        {
            return  base.Calculate() * AllowanceRate;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nAllowance: {Math.Round(CalculateAllowance(),2)}:N0" +
                $"\nNet Salary: {Math.Round(Calculate(),2)}:N0";
        }
    }
}
