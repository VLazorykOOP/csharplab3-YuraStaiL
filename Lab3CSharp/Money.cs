using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class Money
    {
        private int nominal;
        private int num;

        public Money(int nominal, int num)
        {
            this.nominal = nominal;
            this.num = num;
        }

        public override string ToString()
        {
     
            return $"Nominal: {this.nominal.ToString()}, count {this.num.ToString()}";
        }

        public bool IsEnough(int cost)
        {
            return this.TotalBalance >= cost;
        }

        public int CalculateAmount(int cost)
        {
            return (int)this.TotalBalance / cost;
        }

        public int Nominal { get => this.nominal; set => this.nominal = value; }
        public int Num { get => this.num; set => this.num = value; }

        public int TotalBalance
        {
            get => this.nominal * this.num;
        }
    }
}
