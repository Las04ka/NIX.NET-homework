namespace Lecture_1;

public static class Starter
{
    private const int IterCount = 100;

    public static void Run()
    {
        var logger = Logger.GetInstance();
        var random = new Random();
        for (var i = 0; i < IterCount; i++)
        {
            var result = random.Next(1, 4) switch
            {
                1 => Actions.CreateDatabase(),
                2 => Actions.ConnectToDatabase(),
                3 => Actions.DropDatabase(),
                _ => throw new ArgumentOutOfRangeException()
            };
            logger.Log(result);
        }

        logger.WriteToFile("log.txt");
    }
}