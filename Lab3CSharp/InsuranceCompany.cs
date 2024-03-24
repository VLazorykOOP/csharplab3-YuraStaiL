using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class InsuranceCompany : Company
    {
        private bool licenseStatus;
        public InsuranceCompany(string name, int employeeCount, decimal capital, bool licenseStatus) : base(name, employeeCount, capital)
        {
            this.licenseStatus = licenseStatus;
        }

        public new void Show()
        {
            base.Show();
            Console.WriteLine("License status: {0}\n", this.licenseStatus);
        }
    }
}
