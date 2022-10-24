Console.Write("Input a positive integer: ");
var input = Console.ReadLine();
int n;

// Check if either the input string is null, cannot be parsed to integer or is not suitable
if (input is null || !int.TryParse(input, out n) || n < 0)
{
    Console.WriteLine("Bad input!");
    return 0;
}

var initialArray = new int[n];

const int min = 1, max = 26;

Console.Write("Initial array: ");
for (var i = 0; i < n; i++)
{
    initialArray[i] = new Random().Next(min, max + 1);
    Console.Write($"{initialArray[i]} ");
}

var evenArray = new int[n];
var oddArray = new int[n];

int evenCount = 0, oddCount = 0;

for (var i = 0; i < n; i++)
{
    if (initialArray[i] % 2 == 0)
    {
        evenArray[evenCount++] = initialArray[i];
    }
    else
    {
        oddArray[oddCount++] = initialArray[i];
    }
}

Array.Resize(ref evenArray, evenCount);
Array.Resize(ref oddArray, oddCount);

// We will add 1 to counter variable for every upper case character in even array, and subtract 1 for every upper
// case character in odd array. Therefore we will have either a positive number which mean there is more upper case
// characters in even array, negative if in odd array and 0 if equal.
var counter = 0;
char[] upperCase = { 'a', 'e', 'i', 'd', 'h', 'j' };

Console.Write("\nEven array: ");
foreach (var i in evenArray)
{
    var resChar = (char)(i + 96);
    if (upperCase.Contains(resChar))
    {
        resChar = (char)(resChar - 32);
        counter++;
    }

    Console.Write($"{resChar} ");
}

Console.Write("\nOdd array: ");
foreach (var i in oddArray)
{
    var resChar = (char)(i + 96);
    if (upperCase.Contains(resChar))
    {
        resChar = (char)(resChar - 32);
        counter--;
    }

    Console.Write($"{resChar} ");
}

var output = counter switch
{
    > 0 => "There is more upper case characters in even array.",
    0 => "There is an equal amount of upper case characters in both arrays.",
    < 0 => "There is more upper case characters in odd array."
};
Console.WriteLine($"\n{output}");

return 0;