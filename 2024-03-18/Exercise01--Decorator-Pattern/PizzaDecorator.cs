public abstract class PizzaDecorator : IPizza
{
  protected IPizza pizza;

  public PizzaDecorator(IPizza pizza)
  {
    this.pizza = pizza;
  }

  public virtual string GetDescription()
  {
    return pizza.GetDescription();
  }

  public virtual double GetCost()
  {
    return pizza.GetCost();
  }
}
