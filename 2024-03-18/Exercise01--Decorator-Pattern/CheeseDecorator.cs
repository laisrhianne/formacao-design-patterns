public class CheeseDecorator : PizzaDecorator
{

  public CheeseDecorator(IPizza pizza) : base(pizza) { }

  public override string GetDescription()
  {
    return pizza.GetDescription() + ", Cheese";
  }

  public override double GetCost()
  {
    return pizza.GetCost();
  }

}
