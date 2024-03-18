public interface IStringArray
{
  List<string> GetElements();
}

public class RealStringArray : IStringArray
{

  private List<string> elements;

  public List<string> GetElements()
  {
    if (elements == null)
    {
      elements = new List<string>();
    }
    return elements;
  }

}

public class ProxyLazyLoadedArray : IStringArray
{

  RealStringArray realArray;

  public ProxyLazyLoadedArray(RealStringArray realArray)
  {
    this.realArray = realArray;
  }

  public List<string> GetElements()
  {

  }

}
