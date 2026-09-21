// Start with Credit Card.
using StrategyPattern;

PaymentContext payment = new PaymentContext(
    new CreditCardPayment());

payment.Pay(1000m);

// Switch to UPI on the same context.
payment.SetPaymentStrategy(new UpiPayment());
payment.Pay(500m);

// Switch to Net Banking.
payment.SetPaymentStrategy(new NetBankingPayment());
payment.Pay(2000m);         