public class FactoryMethod
{
    public static void Main()
    {
        IItemFactory factory = new RenderItemFactory();
    }
}