namespace Lab3CSharp
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Created an object of class Money(200, 4) - money");
            Money money = new Money(200, 4);

            Console.WriteLine("Using ToString()");
            Console.WriteLine(money.ToString());

            Console.WriteLine("Using property: money.Num = 5");
            Console.WriteLine("Using property: money.Nominal = 1000");
            money.Num = 5;
            money.Nominal = 1000;

            Console.WriteLine("Using property: money.TotalBalance");
            Console.WriteLine(money.TotalBalance);

            Console.WriteLine("Using ToString()");
            Console.WriteLine(money.ToString());

            Console.WriteLine("money.IsEnough(4700)");
            Console.WriteLine(money.IsEnough(4700));

            Console.WriteLine("money.IsEnough(5100)");
            Console.WriteLine(money.IsEnough(5100));

            Console.WriteLine("money.CalculateAmount(5100)");
            Console.WriteLine(money.CalculateAmount(5100));

            Console.WriteLine("money.CalculateAmount(150)");
            Console.WriteLine(money.CalculateAmount(150));
        }

        static Company[] initCompanies()
        {
            Company[] companies = new Company[3];
            companies[0] = new Factory("Ferrari", 3000, 999999, "Cars");
            companies[1] = new InsuranceCompany("TAC", 200, 100002, true);
            companies[2] = new OilGasCompany("Навтогаз України", 2100, 3222123, 99999);

            return companies;
        }

        static void Task2()
        {
            Company someCompany = new Company("Apple", 5000, 99999);
            someCompany.Show();
            Console.WriteLine();

            Company[] companies = initCompanies();
            Array.Sort(companies);

            Console.WriteLine("Sorted by: capital");
            for (int i = 0; i < companies.Length; i++)
            {
                companies[i].Show();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Task1();

            Console.WriteLine("\nTask 2");
            Task2();
        }
    }
}
