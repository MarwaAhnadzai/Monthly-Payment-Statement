using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AhmadzaiMarwa_A1
{
    public class SalariedEmployee : Employee
    {
        public SalariedEmployee(string name, string email, double annualSalary)
            : base(name, email, annualSalary) { }

        public override double Payment()
        {
            return Pay / 26; // Biweekly payment
        }
    }
}

