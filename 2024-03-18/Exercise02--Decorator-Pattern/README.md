# Instructions

## Adicionar Modificações a um Ficheiro

Criar uma classe FileStream e vários decorators para modificar o ficheiro
(deve ser possível comprimir, encriptar, guardar como buffer, etc.)

# Team
- Laís Lisboa

# Example Reference

```csharp
public class Program
{
  public static void Main()
  {

    ICoffee coffee = new BasicCoffee();

    coffee = new MilkDecorator(coffee);
    coffee = new SugarDecorator(coffee);

    Console.WriteLine(coffee.GetDescription());
    Console.WriteLine(coffee.GetCost());

  }
}

public interface ICoffee
{
  string GetDescription();
  double GetCost();
}

public class BasicCoffee : ICoffee
{
  public string GetDescription()
  {
    return "Coffee";
  }
  public double GetCost()
  {
    return 2.0;
  }
}

public abstract class CoffeeDecorator : ICoffee
{
  protected ICoffee coffee;

  public CoffeeDecorator(ICoffee coffee)
  {
    this.coffee = coffee;
  }

  public virtual string GetDescription()
  {
    return coffee.GetDescription();
  }

  public virtual double GetCost()
  {
    return coffee.GetCost();
  }
}

public class MilkDecorator : CoffeeDecorator
{

  public MilkDecorator(ICoffee coffee) : base(coffee) { }

  public override string GetDescription()
  {
    return coffee.GetDescription() + ", Milk";
  }

  public override double GetCost()
  {
    return coffee.GetCost() + 0.5;
  }

}

public class SugarDecorator : CoffeeDecorator
{

  public SugarDecorator(ICoffee coffee) : base(coffee) { }

  public override string GetDescription()
  {
    return coffee.GetDescription() + ", Sugar";
  }

  public override double GetCost()
  {
    return coffee.GetCost() + 0.2;
  }

}
```
