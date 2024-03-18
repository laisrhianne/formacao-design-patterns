# Instructions

Implementar Lazy Loading para um Array de Strings no método `GetElements` da classe `ProxyLazyLoadedArray`:
- Obter os primeiros 10 elementos a primeira vez que é chamado
- Obter os 10 elementos seguintes a segunda vez que é chamado

# Team
- Laís Lisboa

# Example Reference

```csharp
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
```

# Solution

<details>
<summary>Solution</summary>

```csharp
public interface IStringArray
{
    List<string> GetElements();
}

public class RealStringArray : IStringArray
{
  private List<string> elements;

  public RealStringArray(List<string> elements)
  {
    this.elements = elements;
  }

  public List<string> GetElements()
  {
    if (elements == null)
    {
      elements = [];
    }
    return elements;
  }
}

public class ProxyLazyLoadedArray : IStringArray
{

  RealStringArray realArray;
  private int index = 0;
  private int elements;

  public ProxyLazyLoadedArray(RealStringArray realArray, int elements)
  {
    this.realArray = realArray;
    this.elements = elements;
  }


  // Obter os primeiros 10 elementos a primeira vez que é chamado
  // Obter os 10 elementos seguintes a segunda vez que é chamado
  public List<string> GetElements()
  {
    List<string> page = realArray.GetElements().Where(e => !string.IsNullOrWhiteSpace(e)).Skip(index * elements).Take(elements).ToList();
    index++;
    return page;

  }

}


public class LazyLoad
{

  static void Main()
  {

    RealStringArray list = new RealStringArray(GenerateNamesList());
    ProxyLazyLoadedArray lazyList = new ProxyLazyLoadedArray(list, 5);


    List<string> page;


    page = lazyList.GetElements();
    Console.WriteLine(string.Join(",", page));

    page = lazyList.GetElements();
    Console.WriteLine(string.Join(",", page));

  }

  public static List<string> GenerateNamesList()
  {

    List<string> texts =
    [
      "Diogo",
      "Joana",
      "Celso",
      "César",
      "Rúben",
      "Hélder",
      "João",
      "Ema",
      "Manuel",
      "Emanuel",
      "Sara",
      "Andreia",
      "Berta",
      "Daniel",
      "Filipa",
      "Paula",
      "Gertrudes",
      "Hermínia",
      "Glória",
      "Rute",
      "Afonso",
    ];
    return texts;

  }

}

```

</details>