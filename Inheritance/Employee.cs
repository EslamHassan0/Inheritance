namespace Inheritance
{
    public class Employee
    {

        public const int MinimumLoggedHours = 175;
        public const decimal OverTimeRate = 1.50m;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal LoggedHours { get; set; }
        public decimal Wage { get; set; }
    
        public virtual decimal Calculate()
        {
            
            return CalculateBaseSalary() + CalculateOverTime();
        }

        private decimal CalculateBaseSalary()
        {
            return (LoggedHours * Wage);
        }
        private decimal CalculateOverTime()
        {
            var additionalHours = ((LoggedHours - MinimumLoggedHours) > 0 ? LoggedHours - MinimumLoggedHours : 0);
            return (additionalHours * Wage * OverTimeRate);
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("Inheritance.", "");
            return $"\n{type}" +
                   $"\nId: {Id}" +
                   $"\nName: {Name}" +
                   $"\nLoggedHours: {LoggedHours} hrs" +
                   $"\nWage: {Wage} hrs" +
                   $"\nBase Salary :{Math.Round(CalculateBaseSalary(),2)}:N0" +
                   $"\nOverTime :{Math.Round(CalculateOverTime(),2):N0}";

        }

    }
}
