using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Sales : Employee
    {

        protected decimal SalesVolume     { get; set; }
        protected decimal Commission    { get; set; }
        public Sales(int id, string name, decimal loggedHours,
            decimal wage, decimal salesVolume, decimal commission) : base(id, name, loggedHours, wage)
        {                 
            this.SalesVolume = salesVolume;
            this.Commission = commission;
        }
        protected override decimal Calculate()
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
