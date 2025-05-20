namespace Inheritance
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            Manager manager = new Manager (100 , "Eslam", 180, 10);
            Maintenance ms = new Maintenance(1002, "Salem", 182, 8);

            Sales sa = new Sales(1003, "Khalid", 185, 6, 10000m, 0.05m);

            Developer de = new Developer(1001, "Eslam", 186, 15, true);
             


            Employee[] employees = { manager, ms, sa , de };

            foreach (var item in employees)
            {
                Console.WriteLine("\n-----------------------");
                Console.WriteLine(item);
            }

        }
    }
}
