public class PreviewTable : Item
{
    public void Render()
    {
        Console.WriteLine("Preview Table rendered.");
    }

    public void Rotate()
    {
        Console.WriteLine("Preview Table rotated.");
    }

    public void Translate()
    {
        Console.WriteLine("Preview Table translated.");
    }
}

public class PreviewChair : Item
{
    public void Render()
    {
        Console.WriteLine("Preview Chair rendered.");
    }

    public void Rotate()
    {
        Console.WriteLine("Preview Chair rotated.");
    }

    public void Translate()
    {
        Console.WriteLine("Preview Chair translated.");
    }
}

public class PreviewWindow : Item
{
    public void Render()
    {
        Console.WriteLine("Preview Window rendered.");
    }

    public void Rotate()
    {
        Console.WriteLine("Preview Window rotated.");
    }

    public void Translate()
    {
        Console.WriteLine("Preview Window translated.");
    }
}

public class PreviewItemFactory : IItemFactory
{
    public override Item CreateTable()
    {
        return new PreviewTable();
    }
    public override Item CreateChair()
    {
        return new PreviewChair();
    }
    public override Item CreateWindow()
    {
        return new PreviewWindow();
    }
}