// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.Write($"A({m}, {n}) = {AckermanFunction(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 || n == 0)
        return AckermanFunction(m - 1, 1);
    else
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
