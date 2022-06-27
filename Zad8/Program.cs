Console.WriteLine("Введите число: ");
string FirstNum = Console.ReadLine();
int StartNum = Int32.Parse(FirstNum);
int NumA = StartNum;

if(StartNum % 2 == 1)
{
    NumA = StartNum - 1;
}
else
{
    NumA = StartNum;
}

int size = StartNum / 2;

void CreateNum(int[]numbers)
{
    int length = numbers.Length;
    int index = 0;
    int number = 0;
    while (index<length)
    {
        numbers[index] = number + 2;
        number = number + 2;
        if (number == NumA)
        {
            break;
        }
        index++;
    }
}

void PrintNum(int[]numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index<length)
    {
        Console.WriteLine(numbers[index]);
        index++;
    }
}

int[] Mass = new int[size];

Console.Write("Все четные числа от 0 до ");
Console.Write(StartNum);
Console.Write(":");
Console.WriteLine();
CreateNum(Mass);
PrintNum(Mass);
