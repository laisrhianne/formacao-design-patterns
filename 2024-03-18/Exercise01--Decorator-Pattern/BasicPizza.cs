public class BasicPizza : IPizza
{
  public string GetDescription()
  {
    return "Pizza";
  }
  public double GetCost()
  {
    return 5.0;
  }
}
