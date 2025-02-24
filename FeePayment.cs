using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_Project
{
    class FeePayment : IPayment
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Payment of {amount:C} processed successfully.");
        }
    }
}