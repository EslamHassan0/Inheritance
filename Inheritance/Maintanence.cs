using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance;

public  class Maintenance : Employee
{
    private const decimal HardShip = 100m;
    public override decimal Calculate()
    {
        return base.Calculate() + HardShip;
    }
     
    public override string ToString()
    {
        return base.ToString() +
            $"\nHardShip: {Math.Round(HardShip, 2)}:N0" +
            $"\nNet Salary: {Math.Round(Calculate(), 2)}:N0";
    }
}