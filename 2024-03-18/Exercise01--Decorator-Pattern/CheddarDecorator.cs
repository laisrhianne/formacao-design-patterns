public class CheddarDecorator : PizzaDecorator
{

  public CheddarDecorator(IPizza pizza) : base(pizza) { }

  public override string GetDescription()
  {
    return pizza.GetDescription() + ", Cheddar";
  }

  public override double GetCost()
  {
    return pizza.GetCost() + 0.2;
  }

}
