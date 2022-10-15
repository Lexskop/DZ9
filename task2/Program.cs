/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
void userData()
{
Console.WriteLine("Введите  M");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  N");
int end = Convert.ToInt32(Console.ReadLine());

Console.Write($"Ваши числа M = {start} и N = {end} -> ");

printSum(start, end);

Console.WriteLine("");

userAnotherTry();
}

int sum = 0;
void printSum(int min, int max)
{
    if (min == max + 1)
    {
        Console.Write($"{sum}");
        sum = 0;
        return;
    }
    sum = sum + min;
    printSum(min + 1, max);
}

void userAnotherTry()
{
    Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    string? userChoice = Console.ReadLine();
    while (userChoice?.ToLower() != "y" && userChoice?.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
    }
    if (userChoice?.ToLower() == "y")
    {
        userData();
    }
    else
    {
        Console.WriteLine("Bye!");
    }
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа найдёт сумму натуральных элементов в промежутке от M до N.");
userData();