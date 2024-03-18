public class BaconDecorator : PizzaDecorator
{

  public BaconDecorator(IPizza pizza) : base(pizza) { }

  public override string GetDescription()
  {
    return pizza.GetDescription() + ", Bacon";
  }

  public override double GetCost()
  {
    return pizza.GetCost() + 0.5;
  }

}
