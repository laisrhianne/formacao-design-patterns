public class TomatoSauceDecorator : PizzaDecorator
{

  public TomatoSauceDecorator(IPizza pizza) : base(pizza) { }

  public override string GetDescription()
  {
    return pizza.GetDescription() + ", Tomato Sauce";
  }

  public override double GetCost()
  {
    return pizza.GetCost();
  }

}
