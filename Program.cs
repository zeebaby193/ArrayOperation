
int[] data = [12, 15, 18, 21, 24, 27, 30];

Console.WriteLine(MGQS(data));
Console.WriteLine(MaxOfArray(data));
Console.WriteLine(MinOfArray(data));
Console.WriteLine(AverageOfArray(data));

int MGQS(int[] oddNums)
{
    int sumOdd = 0;
    foreach (int digit in oddNums)
    {
        if (digit % 2 != 0)
        {
            sumOdd += digit;
        }
    }
    return sumOdd;
}

int MaxOfArray(int[] numbers)
{
    int max = numbers[0];
    foreach (int num in numbers)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;
}

int MinOfArray(int[] numbers)
{
    int min = numbers[0];
    foreach (int num in numbers)
    {
        if (num < min)
        {
            min = num;
        }
    }
    return min;
}

int AverageOfArray(int[] numbers)
{
    int sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }
    return sum / numbers.Length;
}













