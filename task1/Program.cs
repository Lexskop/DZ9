/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
void printRange(int max)
{
    if (max == 1)
    {
        return;
    }
    Console.Write($"{max}, ");
    printRange(max - 1);
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

void userData()
{
Console.WriteLine("Введите  N");
int start = Convert.ToInt32(Console.ReadLine());

Console.Write($"Ваше число {start} -> \"");

printRange(start);

Console.WriteLine("1\"");
userAnotherTry();
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа выведет все натуральные числа в промежутке от Вашего N до 1. Выполнено с помощью рекурсии.");
userData();