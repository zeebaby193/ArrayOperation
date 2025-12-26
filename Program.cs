
/*int[] data = [12, 15, 18, 21, 24, 27, 30];

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
}*/

// First non-repeating character
// Write a code that gives the first non-repeating letter in a word gotten from the input user, without using any inbuilt functions.

Console.WriteLine("Enter a word:");
string input = Console.ReadLine()!;

char FirstNonRepeatingCharacter(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        bool isRepeating = false;
        for (int j = 0; j < str.Length; j++)
        {
            if (i != j && str[i] == str[j])
            {
                isRepeating = true;
                break;
            }
        }
        if (!isRepeating)
        {
            return str[i];
        }
    }
    return '\0'; // Return null character if no non-repeating character is found
}

char result = FirstNonRepeatingCharacter(input);
if (result != '\0')
{
    Console.WriteLine($"The first non-repeating character is: {result}");
}
else
{
    Console.WriteLine("No non-repeating character found.");
}



















