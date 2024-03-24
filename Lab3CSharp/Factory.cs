using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class Factory : Company
    {
        private string productType;
        public Factory(string name, int employeeCount, decimal capital, string productType) : base(name, employeeCount, capital)
        {
            this.productType = productType;
        }

        public new void Show()
        {
           base.Show();
           Console.WriteLine("Product type: {0}\n", this.productType);
        }
    }
}
