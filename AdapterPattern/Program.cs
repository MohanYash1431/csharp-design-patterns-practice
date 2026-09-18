using AdapterPattern;

RazorPay razorPay = new RazorPay();

IInhousePaymentProcessor razorPayAdapter = new RazorPayAdapter(razorPay);

razorPayAdapter.Pay(1000);
