namespace Lecture_1;

public static class Starter
{
    private const int IterCount = 100;

    public static void Run()
    {
        var random = new Random();
        for (var i = 0; i < IterCount; i++)
        {
            var result = random.Next(1, 4) switch
            {
                1 => Actions.Info(),
                2 => Actions.Warning(),
                3 => Actions.Error(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}