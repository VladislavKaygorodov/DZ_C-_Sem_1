int NumberA = new Random().Next(1,10);
Console.Write("Первое число: ");
Console.Write(NumberA);
Console.WriteLine();
int NumberB = new Random().Next(1,10);
Console.Write("Второе число: ");
Console.Write(NumberB);
Console.WriteLine();
if (NumberA>NumberB)
{
    Console.WriteLine("Первое число больше второго");
}
if (NumberA<NumberB)
{
    Console.WriteLine("Второе число больше первого");
}
if (NumberA == NumberB)
{
    Console.WriteLine("Первое и второе чиcло равны!");
}