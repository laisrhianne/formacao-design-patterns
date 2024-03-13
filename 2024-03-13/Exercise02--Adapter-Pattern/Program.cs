public class Program
{
    public static void Main()
    {

        FileLogger fileLogger = new FileLogger();
        LoggerAdapter adapter = new LoggerAdapter(fileLogger);
        adapter.Log("Logging test string");

    }
}