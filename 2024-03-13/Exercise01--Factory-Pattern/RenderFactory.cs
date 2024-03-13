public class RenderTable : Item
{
    public void Render()
    {
        Console.WriteLine("Render Table rendered.");
    }

    public void Rotate()
    {
        Console.WriteLine("Render Table rotated.");
    }

    public void Translate()
    {
        Console.WriteLine("Render Table translated.");
    }
}

public class RenderChair : Item
{
    public void Render()
    {
        Console.WriteLine("Render Chair rendered.");
    }

    public void Rotate()
    {
        Console.WriteLine("Render Chair rotated.");
    }

    public void Translate()
    {
        Console.WriteLine("Render Chair translated.");
    }
}

public class RenderWindow : Item
{
    public void Render()
    {
        Console.WriteLine("Render Window rendered.");
    }

    public void Rotate()
    {
        Console.WriteLine("Render Window rotated.");
    }

    public void Translate()
    {
        Console.WriteLine("Render Window translated.");
    }
}

public class RenderItemFactory : IItemFactory
{
    public override Item CreateTable()
    {
        return new RenderTable();
    }
    public override Item CreateChair()
    {
        return new RenderChair();
    }
    public override Item CreateWindow()
    {
        return new RenderWindow();
    }
}