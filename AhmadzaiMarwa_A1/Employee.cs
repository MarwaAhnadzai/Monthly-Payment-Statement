using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadzaiMarwa_A1
{
    public abstract class Employee : IPayable
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Pay { get; set; }

        protected Employee(string name, string email, double pay)
        {
            Name = name;
            Email = email;
            Pay = pay;
        }

        public abstract double Payment();
    }
}

