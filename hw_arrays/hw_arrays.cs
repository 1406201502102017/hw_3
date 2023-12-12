/*
Сдавать ссылкой на GITHUB(отправить в комментарии к дз)

Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
значения которых лежат в отрезке [20,90].

Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
которая определяет количество чётных чисел в массиве.

Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.

Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, 
младший – на последнем. Размер массива должен быть равен количеству цифр.
*/
Console.Clear();
//#1-----------------------------------------------------------------------------
int[] arr = new int[10];
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    int n = new Random().Next(1, 101);
    arr[i] = n;
    Console.Write(arr[i] + " ");
}
Console.WriteLine("\n");
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= 20 && arr[i] <= 90)
    {
        Console.Write(arr[i] + " ");
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество элементов массива в диапазоне [20, 90]: " + count + "\n");
//#2-----------------------------------------------------------------------------
int check = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write(arr[i] + " ");
        check++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел массива: " + check);
//#3-----------------------------------------------------------------------------
Console.Write("\nДлина массива: ");
int f = Convert.ToInt32(Console.ReadLine());
double[] array = new double[f];
for (int i = 0; i < array.Length; i++)
{
    double g = new Random().NextDouble();
    Console.Write("{0,8:N3}", g * 5);
    array[i] = g * 5;
}
Console.WriteLine();
double max = array[0], min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine("MAX число --> " + "{0:0.000}", max);
Console.WriteLine("MIN число --> " + "{0:0.000}", min);
double dif = max - min;
Console.WriteLine("Разница между числами: " + "{0:0.000}", dif);
//#4-----------------------------------------------------------------------------
int w = new Random().Next(1, 100001);
Console.WriteLine("\nВвести число: " + w);
int[] a = new int[w.ToString().Length];
for (int i = 0; i < a.Length; i++)
{
    a[i] = w % 10;
    w /= 10;
}
Array.Reverse(a);
Console.WriteLine(string.Join(" ", a));