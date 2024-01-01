/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.

Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
*/
// #1--------------------------------------------------------------
Console.Clear();
Console.Write("Первое число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Последнее число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int NaturalNumbers(int m, int n)
{
    if (m > n)
        return m;
    Console.Write($"{m}, ");
    return NaturalNumbers(m + 1, n);
}
Console.WriteLine(NaturalNumbers(m, n));
// #2--------------------------------------------------------------
int AkkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}
Console.WriteLine($"Результат вычисления функции Аккермана: {AkkermanFunction(m, n)}");
// #3--------------------------------------------------------------
int[] array = { 1, 56, 8, 79, 12, 41 };
void PrintArray(int[] arr, int i = 0)
{
    if (i >= arr.Length)
        return;
    Console.Write(arr[i] + " ");
    i++;
    PrintArray(arr, i);
}
PrintArray(array);
Console.WriteLine();
Array.Reverse(array);
PrintArray(array);
Console.WriteLine();