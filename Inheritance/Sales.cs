using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Sales : Employee
    {

        public   decimal SalesVolume { get; set; }
        public   decimal Commission { get; set; }
        public override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        private decimal CalculateBonus()
        {
            return SalesVolume * Commission;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nCommission: {Math.Round(Commission, 2)}:N0" +
                $"\nBonus: {Math.Round(CalculateBonus(), 2)}:N0" +
                $"\nNet Salary: {Math.Round(Calculate(), 2)}:N0";
        }
    }
}
