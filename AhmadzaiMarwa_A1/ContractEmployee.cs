using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadzaiMarwa_A1
{
    public class ContractEmployee : Employee
    {
        public int ContractDuration { get; set; }

        public ContractEmployee(string name, string email, double contractPay, int contractDuration)
            : base(name, email, contractPay)
        {
            ContractDuration = contractDuration;
        }

        public override double Payment()
        {
            return Pay / ContractDuration; // Monthly payment
        }
    }
}

