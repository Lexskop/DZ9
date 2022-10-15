/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
void userData()
{
Console.WriteLine("Введите  M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  N");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Ваши числа M = {m} и N = {n} -> {funcAckermann(m, n)}");
Console.WriteLine("");

userAnotherTry();
}


int funcAckermann(int mNumber, int nNumber)
{
    if (mNumber == 0)
    {
        return nNumber + 1;
    }
    else
    if (mNumber > 0 && nNumber == 0)
    {
        return funcAckermann(mNumber - 1, 1);
    }
    else
    {
        return funcAckermann(mNumber - 1, funcAckermann(mNumber, nNumber - 1));
    }
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
Console.WriteLine("Приветствую! Эта программа для вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
userData();