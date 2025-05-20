using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Developer : Employee
    {
        public const decimal Commission = 0.03m;
        public bool TaskCompleted { get; set; }
       
        public override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        private decimal CalculateBonus()
        {
            if(TaskCompleted)
                return base.Calculate() * Commission;
            return 0;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nTaskCompleted: {(TaskCompleted? "Yes" : "No")}" +
                $"\nBonus: {Math.Round(CalculateBonus(), 2)}:N0" +
                $"\nNet Salary: {Math.Round(Calculate(), 2)}:N0";
        }
    }
}
