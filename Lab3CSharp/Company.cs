using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class Company: IComparable
    {
        protected string name;
        protected int employeeCount;
        protected decimal capital;
        public string Name { get => this.name; set => this.name = value; }

        public Company(string name, int employeeCount, decimal capital)
        {
            this.name = name;
            this.employeeCount = employeeCount;
            this.capital = capital;
        }

        public void Show()  
        {
            string className = GetType().Name;

            //Console.WriteLine($"Class name:{className}\nName: {this.name}\nEmployee count: {this.employeeCount}\nCapital: {this.capital}\n");
            Console.WriteLine(
                "Class name: {0}\nName: {1}\nEmployee count: {2}\nCapital: {3}",
                className,
                this.name,
                this.employeeCount,
                this.capital
                );
        }

        public int CompareTo(object? o)
        {
            if (o is Company company) return (int)(this.capital - company.capital);
            else throw new ArgumentException("Incorrent parameter value");
        }
    }
}
