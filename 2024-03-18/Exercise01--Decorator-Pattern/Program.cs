public class Program
{
  public static void Main()
  {

    IPizza pizza = new BasicPizza();

    pizza = new CheeseDecorator(pizza);
    pizza = new TomatoSauceDecorator(pizza);
    pizza = new CheddarDecorator(pizza);
    pizza = new BaconDecorator(pizza);

    Console.WriteLine(pizza.GetDescription());
    Console.WriteLine(pizza.GetCost());

  }
}
