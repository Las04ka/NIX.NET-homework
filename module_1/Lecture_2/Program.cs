// Task 1
{
    // Create variables
    const int min = -400, max = 500, n = 20;

    // Create and fill array with random values
    var firstArray = new int[n];
    Console.Write($"Task 1\nRandom array with {n} integers: ");
    for (var i = 0; i < n; i++)
    {
        firstArray[i] = new Random().Next(min, max);
        Console.Write($"{firstArray[i]} ");
    }

    // Determine count of elements in range from -100 to 100
    var counter = 0;
    Console.Write("\nArray of elements in range from -100 to 100: ");
    for (var i = 0; i < n; i++)
    {
        if (firstArray[i] >= -100 && firstArray[i] <= 100)
        {
            counter++;
            Console.Write($"{firstArray[i]} ");
        }
    }

    Console.WriteLine($"\nAmount of elements in range from -100 to 100: {counter}\n");
}

// Task 2
{
    // Create variables
    const int min = 0, max = 888 * 2, n = 20;

    // Create and fill array with random values
    var firstArray = new int[n];
    Console.Write($"Task 2\nRandom array from {n} integers: ");
    for (var i = 0; i < n; i++)
    {
        firstArray[i] = new Random().Next(min, max);
        Console.Write($"{firstArray[i]} ");
    }

    // Create result array and fill it with elements from initial array values of which are <= 888
    var secondArray = new int[n];
    var counter = 0;
    for (var i = 0; i < n; i++)
    {
        if (firstArray[i] <= 888)
        {
            secondArray[counter] = firstArray[i];
            counter++;
        }
    }

    // Resize, sort and output the result array
    Array.Resize(ref secondArray, counter);
    Array.Sort(secondArray);
    Array.Reverse(secondArray);

    Console.Write("\nArray of elements with value <= 888 sorted by descending: ");
    foreach (var element in secondArray)
    {
        Console.Write($"{element} ");
    }
}