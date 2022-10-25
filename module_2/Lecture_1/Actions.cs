namespace Lecture_1;

public static class Actions
{
    public static Result CreateDatabase()
    {
        return new Result(nameof(CreateDatabase), "Start method", Result.ResultType.Info);
    }

    public static Result ConnectToDatabase()
    {
        return new Result(nameof(ConnectToDatabase), "Skipped logic in method", Result.ResultType.Warning);
    }

    public static Result DropDatabase()
    {
        return new Result(nameof(DropDatabase), "I broke a logic", Result.ResultType.Error, false);
    }
}