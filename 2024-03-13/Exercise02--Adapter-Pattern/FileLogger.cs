public interface ILogger
{
    void Log(string message);
}

public class FileLogger
{
    public void LogFile(string fileData)
    {
        Console.WriteLine("Saving to File.");
        Console.WriteLine(fileData);
    }
}