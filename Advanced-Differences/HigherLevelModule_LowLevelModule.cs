using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.Differences
{
    //To understand higher-level and lower-level modules, let’s break it down with an example using the Dependency Inversion Principle(DIP), which is a key concept in software design.


//   Let’s design a payment system where:
//Higher-level module: Represents the business logic that says, "We need to process payments."
//Lower-level module: Handles the actual payment processing(like credit cards, PayPal, etc.).




//Step 1: Define an Abstraction
//We create an interface for the payment method.This ensures the higher-level module depends on an abstraction, not a specific payment method.
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    //************************************** Lower-level module 1: Credit Card Payment
    //2.These modules handle the actual implementation of payment processing.
    public class CreditCardPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}");
        }
    }

    // Lower-level module 2: PayPal Payment
    public class PayPalPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }




    //******************************************************************** Higher-level module   ******************************

    //3.The higher-level module defines the overall logic but doesn’t depend on the specific implementation.
    public class PaymentService
    {
        private readonly IPaymentProcessor _paymentProcessor;

        // Dependency injection: the specific payment processor is provided at runtime
        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void MakePayment(decimal amount)
        {
            Console.WriteLine("Initiating payment...");
            _paymentProcessor.ProcessPayment(amount);
            Console.WriteLine("Payment completed.");
        }
    }



    //Step4.The specific lower-level module(e.g., CreditCardPayment) is passed to the higher-level module(PaymentService) at runtime.
    public static class Program
    {
        public static void Main()
        {
            // Lower-level module: Credit card payment
            IPaymentProcessor creditCardProcessor = new CreditCardPayment();
            PaymentService paymentService1 = new PaymentService(creditCardProcessor);
            paymentService1.MakePayment(1000.00m);

            // Lower-level module: PayPal payment
            IPaymentProcessor payPalProcessor = new PayPalPayment();
            PaymentService paymentService2 = new PaymentService(payPalProcessor);
            paymentService2.MakePayment(500.00m);
        }
    }




}
