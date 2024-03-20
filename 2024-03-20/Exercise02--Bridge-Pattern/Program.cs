// Refactored Code

public interface IPaymentProcessor
{
  void ProcessPayment(string paymentType); // paymentType vai ser Recurring ou OneTime
}

// todo - criar classes concretas CreditCardProcessor, PayPalProcessor

// public class CreditCardProcessor : IPaymentProcessor { ... }

public abstract class Payment
{

  IPaymentProcessor paymentProcessor;

  public Payment(IPaymentProcessor paymentProcessor)
  {
    this.paymentProcessor = paymentProcessor;
  }

  public abstract void MakePayment();

}

// todo - criar classes concretas OneTimePayment, RecurringPayment

// public class OneTimePayment : Payment{ ... }
// public class RecurringPayment : Payment{ ... }

public class Program
{

  static void Main()
  {

    // No client, criar um IPaymentProcessor e Payment concretos
    // no final executar payment.MakePayment();

  }

}