/* Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии. */

int number = InputInt("Введите положительное число: ");
int n = 1;
if (n < 1)
{
    Console.WriteLine("Не положительное число.");
}
Console.WriteLine(NaturalNumber(number, n));

int NaturalNumber(int number, int n)
{
    if (number == n)
        return n;
    else
        Console.Write($"{NaturalNumber(number, n + 1)}, ");
    return n;
}
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. */

int N = InputInt("Введите N: ");
int M = InputInt("Введите M: ");
Console.WriteLine($"Сумма элементов от {M} до {N} = {Summa(M, N)}");
int InputInt(string result)
{
    Console.Write(result);
    return int.Parse(Console.ReadLine());
}
int Summa(int M, int N)
{
    if (M == N)
        return N;
    return N + Summa(M, N + 1);
}

/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. */

Console.WriteLine("Введите два положительных числа: M и N.");
int M = InputInt("Введите M: ");
int N = InputInt("Введите N: ");
Console.WriteLine($"A({M}, {N}) = {Akkerman(M, N)}");

int InputInt(string result)
{
    Console.Write(result);
    return int.Parse(Console.ReadLine());
}
int Akkerman(int M, int N)
{
    if (M == 0)
        return M + 1;
    if (M > 0 && N == 0)
        return Akkerman(M - 1, 1);
    else
        return Akkerman(M - 1, Akkerman(M, N - 1));
}