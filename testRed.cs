public static void Main(string[] args)
{
    int n = GetNumberOfIntegers();
    int[] numbers = ReadIntegers(n);
    int total = Sum(numbers, n);

    Console.WriteLine($"Sum of the numbers: {total}");
}

private static int GetNumberOfIntegers()
{
    Console.WriteLine("Enter the number of integers:");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            return n;
        }
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}

private static int[] ReadIntegers(int count)
{
    int[] numbers = new int[count];
    Console.WriteLine($"Enter {count} integers:");
    for (int i = 0; i < count; i++)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
    return numbers;
}

private static int Sum(int[] numbers, int count)
{
    int total = 0;
    for (int i = 0; i < count; i++)
    {
        total += numbers[i];
    }
    return total;
}