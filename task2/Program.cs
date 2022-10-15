/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Введите  M");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  N");
int end = Convert.ToInt32(Console.ReadLine());
Console.Write($"Ваши числа M = {start} и N = {end} -> ");
int sum = 0;

printRange(start, end);

void printRange(int min, int max)
{
    if (min == max + 1)
    {
        Console.Write($"{sum}");
        return;
    }
    sum = sum + min;
    printRange(min + 1, max);
}