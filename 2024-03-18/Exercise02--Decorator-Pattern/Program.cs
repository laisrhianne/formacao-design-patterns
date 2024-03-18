public class Program
{
  public static void Main()
  {

    IFileStream fileStream = new FileStream();

    fileStream = new CompressDecorator(fileStream);
    fileStream = new EncryptDecorator(fileStream);
    fileStream = new StoreBufferDecorator(fileStream);

    Console.WriteLine(fileStream.GetContent());
    Console.WriteLine(fileStream.GetSize());

  }
}
