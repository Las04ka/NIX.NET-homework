namespace Lecture_1;

public class Result
{
    private readonly DateTime _time;
    private readonly string _origin;
    private readonly string _message;
    private readonly ResultType _type;
    private readonly bool _status;

    public Result(string origin, string message, ResultType type, bool status = true)
    {
        _time = DateTime.Now;
        _origin = origin;
        _message = message;
        _type = type;
        _status = status;
    }

    public enum ResultType
    {
        Info,
        Warning,
        Error
    }

    public override string ToString()
    {
        var errorString = _status ? string.Empty : "Action failed by a reason: ";
        return $"{_time}: {_type}: \"{errorString}{_message}\": {_origin}";
    }
}