void CreateRandomNum(int[]numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index<length)
    {
        numbers[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintRandomNum(int[]numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index<length)
    {
        Console.WriteLine(numbers[index]);
        index++;
    }
}

int Max(int[]num)
{
    int length = num.Length;
    int index = 0;
    int max = index;
    while (index<length)
    {
        if (num[index]>max)
        {
            max = num[index];
        }
        index++;
    }
    return max;
}

int [] array = new int[3];

Console.WriteLine("Искомые числа:");
CreateRandomNum(array);
PrintRandomNum(array);
int max = Max(array);
Console.Write("Наибольшее число: ");
Console.Write(max);