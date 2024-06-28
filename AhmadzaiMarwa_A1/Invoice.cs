using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmadzaiMarwa_A1
{
    public class Invoice : IPayable
    {
        public string VendorName { get; set; }
        public string VendorEmail { get; set; }
        public double InvoiceAmount { get; set; }

        public Invoice(string vendorName, string vendorEmail, double invoiceAmount)
        {
            VendorName = vendorName;
            VendorEmail = vendorEmail;
            InvoiceAmount = invoiceAmount;
        }

        public double Payment()
        {
            return InvoiceAmount; // One-time payment
        }
    }
}
