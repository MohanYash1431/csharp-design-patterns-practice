using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class RazorPayAdapter : IInhousePaymentProcessor
    {
        private readonly RazorPay _razorPay;

        public RazorPayAdapter(RazorPay razorPay)
        {
            _razorPay = razorPay;
        }

        public void Pay(int amount)
        {
            _razorPay.RazorPayPayment(amount);
        }
    }
}
