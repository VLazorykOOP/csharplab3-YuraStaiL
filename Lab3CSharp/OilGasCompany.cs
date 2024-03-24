using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class OilGasCompany : Company
    {
        private int reserves;
        public OilGasCompany(string name, int employeeCount, decimal capital, int reserves) : base(name, employeeCount, capital)
        {
            this.reserves = reserves;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine("Reserves: {0}\n", this.reserves);
        }
    }
}
