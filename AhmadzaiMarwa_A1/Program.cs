using System;
using System.Collections.Generic;

namespace AhmadzaiMarwa_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collection of IPayable objects
            List<IPayable> payables = new List<IPayable>();

            // Create and add salaried employees
            payables.Add(new SalariedEmployee("Hamid kh", "hamid.kh@example.com", 78000));
            payables.Add(new SalariedEmployee("Fam Ah", "fam.ah@example.com", 68000));
            payables.Add(new SalariedEmployee("Ben Sk", "ben.sk@example.com", 56000));

            // Create and add contract employees
            payables.Add(new ContractEmployee("Red White", "red.white@example.com", 48000, 12));
            payables.Add(new ContractEmployee("Blue Green", "blue.green@example.com", 36000, 6));
            payables.Add(new ContractEmployee("Yellow Black", "yellow.black@example.com", 24000, 3));

            // Create and add invoices
            payables.Add(new Invoice("Vendor A", "vendorA@example.com", 1500));
            payables.Add(new Invoice("Vendor B", "vendorB@example.com", 2500));

            // Create and add guest speaker
            payables.Add(new GuestSpeaker("Dr. Marwa Ahmadzai", "marwa.ah@example.com", 5000));

            // Display the payment statement
            Console.WriteLine("Monthly Payment Statement for MAY 2024");
            Console.WriteLine("{0,-25} {1,-20} {2,-25} {3,15}", "Type", "Name", "Email", "Payment Amount");

            foreach (var payable in payables)
            {
                Console.WriteLine("{0,-25} {1,-20} {2,-25} {3,15:C2}", GetEntityType(payable), GetEntityName(payable), GetEmail(payable), payable.Payment());
            }
        }

        static string GetEntityType(IPayable payable)
        {
            switch (payable)
            {
                case SalariedEmployee:
                    return "[Salaried Employee]";
                case ContractEmployee:
                    return "[Contract Employee]";
                case Invoice:
                    return "[Vendor]";
                case GuestSpeaker:
                    return "[Guest Speaker]";
                default:
                    return string.Empty;
            }
        }

        static string GetEntityName(IPayable payable)
        {
            switch (payable)
            {
                case Employee emp:
                    return emp.Name;
                case Invoice inv:
                    return inv.VendorName;
                case GuestSpeaker gs:
                    return gs.SpeakerName;
                default:
                    return string.Empty;
            }
        }

        static string GetEmail(IPayable payable)
        {
            switch (payable)
            {
                case Employee emp:
                    return emp.Email;
                case Invoice inv:
                    return inv.VendorEmail;
                case GuestSpeaker gs:
                    return gs.SpeakerEmail;
                default:
                    return string.Empty;
            }
        }
    }
}
