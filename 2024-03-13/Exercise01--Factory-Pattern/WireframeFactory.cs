public class WireframeTable : Item
{
    public void Render()
    {
        Console.WriteLine("Wireframe Table rendered.");
    }

    public void Rotate()
    {
        Console.WriteLine("Wireframe Table rotated.");
    }

    public void Translate()
    {
        Console.WriteLine("Wireframe Table translated.");
    }
}

public class WireframeChair : Item
{
    public void Render()
    {
        Console.WriteLine("Wireframe Chair rendered.");
    }

    public void Rotate()
    {
        Console.WriteLine("Wireframe Chair rotated.");
    }

    public void Translate()
    {
        Console.WriteLine("Wireframe Chair translated.");
    }
}

public class WireframeWindow : Item
{
    public void Render()
    {
        Console.WriteLine("Wireframe Window rendered.");
    }

    public void Rotate()
    {
        Console.WriteLine("Wireframe Window rotated.");
    }

    public void Translate()
    {
        Console.WriteLine("Wireframe Window translated.");
    }
}

public class WireframeItemFactory : IItemFactory
{
    public override Item CreateTable()
    {
        return new WireframeTable();
    }
    public override Item CreateChair()
    {
        return new WireframeChair();
    }
    public override Item CreateWindow()
    {
        return new WireframeWindow();
    }
}