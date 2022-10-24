// string to check all 3 tasks: Myp, super long 4, stri4ng nith 5 words.

Console.Write("Input text: ");
var text = Console.ReadLine();

// Check if text is not null else exit the program
if (text is null)
{
    Console.WriteLine("Bad input.");
    return 0;
}

// Breaking text into words
var words = text.Trim().Split();

// Check if there is at least 5 words else exit the program
if (words.Length < 5)
{
    Console.WriteLine("Bad input.");
    return 0;
}

// First task: delete all numbers and reverse words with odd indices
var firstResult = string.Empty;

for (var i = 0; i < words.Length; i++)
{
    for (var j = 0; j < words[i].Length; j++)
    {
        if (char.IsDigit(words[i][j]))
        {
            words[i] = words[i].Remove(j, 1);
        }
    }

    if (words[i].Length > 0)
    {
        firstResult += (char.IsPunctuation(words[i][0]) ? string.Empty : " ") + words[i];
    }
}

words = firstResult.Trim().Split();
firstResult = string.Empty;

// Assume that word count starts with 1
for (var i = 0; i < words.Length; i++)
{
    if (i % 2 == 0)
    {
        var arrayToReverse = words[i][..^(char.IsPunctuation(words[i][^1]) ? 1 : 0)].ToCharArray();
        Array.Reverse(arrayToReverse);
        words[i] = new string(arrayToReverse) + (char.IsPunctuation(words[i][^1]) ? words[i][^1..] : string.Empty);
    }

    firstResult += (char.IsPunctuation(words[i][0]) ? string.Empty : " ") + words[i];
}

Console.WriteLine($"First task result: {firstResult.Trim()}");

// Second task: every word starts with upper case
var secondResult = string.Empty;

words = firstResult.Trim().Split();

for (var i = 0; i < words.Length; i++)
{
    words[i] = words[i][..1].ToUpper() + words[i][1..].ToLower();
    secondResult += $"{words[i]} ";
}

Console.WriteLine($"Second task result: {secondResult.Trim()}");

// Third task: if words begins with 'P' change it to 'S' if ends with 'N' change to 'O', not case sensitive input
var thirdResult = string.Empty;

words = secondResult.Trim().Split();

for (var i = 0; i < words.Length; i++)
{
    if (words[i][0] is 'P' or 'p')
    {
        words[i] = 'S' + words[i][1..];
    }

    if (words[i][^(char.IsPunctuation(words[i][^1]) ? 2 : 1)] is 'N' or 'n')
    {
        words[i] = words[i][..^1] + 'O';
    }

    thirdResult += $"{words[i]} ";
}

Console.WriteLine($"Third task result: {thirdResult.Trim()}");

return 0;