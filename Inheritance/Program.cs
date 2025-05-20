namespace Inheritance
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Manager manager = new Manager 
            {
                Id = 100,
                Name = "Eslam",
                LoggedHours =180,
                Wage = 10,
            };
            Maintenance ms = new Maintenance
            {
                Id = 1002,
                Name = "Salem",
                LoggedHours = 182,
                Wage = 8,
            };
            Sales sa = new Sales
            {
                Id = 1003,
                Name = "Khalid",
                LoggedHours = 185,
                Commission = 0.05m,
                SalesVolume = 10000m,
                Wage = 6,
            };
            Developer de = new Developer
            {
                Id = 1001,
                Name = "Eslam",
                TaskCompleted = true,
                LoggedHours = 186,
                Wage = 15,
            };


            Employee[] employees = { manager, ms, sa , de };

            foreach (var item in employees)
            {
                Console.WriteLine("\n-----------------------");
                Console.WriteLine(item);
            }

        }
    }
}
