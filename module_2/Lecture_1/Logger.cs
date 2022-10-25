namespace Lecture_1;

public class Logger
{
    private static Logger? _logger;

    private Logger()
    {
        LoggerHistory = new List<Result>();
    }

    public List<Result> LoggerHistory { get; }

    /// <summary>
    /// If not created, creates new logger instance and returns it.
    /// </summary>
    /// <returns>Logger instance.</returns>
    public static Logger GetInstance()
    {
        return _logger ??= new Logger();
    }

    /// <summary>
    /// Add method result to logger history and write it to the console.
    /// </summary>
    /// <param name="result">Method result.</param>
    public void Log(Result result)
    {
        LoggerHistory.Add(result);
        Console.WriteLine(result);
    }

    /// <summary>
    /// Write logger history to text file.
    /// </summary>
    /// <param name="path">Path to text file to write logger history to.</param>
    public void WriteToFile(string path)
    {
        using StreamWriter file = new(path, append: true);
        foreach (var log in LoggerHistory)
        {
            file.WriteLine(log.ToString());
        }
    }
}