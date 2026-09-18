using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class RazorPay
    {
        public void RazorPayPayment(int amount)
        {
            Console.WriteLine($"Processing payment of {amount} using RazorPay.");
        }
    }
}
