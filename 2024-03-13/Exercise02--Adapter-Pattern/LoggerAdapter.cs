public class LoggerAdapter : ILogger
{
    FileLogger fileLogger;

    public LoggerAdapter(FileLogger fileLogger)
    {
        this.fileLogger = fileLogger;
    }

    public void Log(string message)
    {
        this.fileLogger.LogFile(message);
    }
}