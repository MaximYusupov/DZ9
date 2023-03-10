// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputInt("Введите значение M:");
int n = InputInt("Введите значение N:");
Console.Write($"Сумма элементов от {m} до {n} = {SumNaturalEl(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNaturalEl(int m, int n)
{
    if (m == n)
        return n;
    return n + SumNaturalEl(m, n - 1);
}
