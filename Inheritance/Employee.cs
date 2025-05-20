namespace Inheritance
{
    public class Employee
    {

        private const int MinimumLoggedHours = 175;
        private const decimal OverTimeRate = 1.50m;

        public Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }

        protected virtual decimal Calculate()
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
