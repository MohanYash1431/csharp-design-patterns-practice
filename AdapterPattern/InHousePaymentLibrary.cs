using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class InHousePaymentLibrary : IInhousePaymentProcessor
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Processing payment of {amount} using InHousePaymentLibrary.");
        }
    }
}
