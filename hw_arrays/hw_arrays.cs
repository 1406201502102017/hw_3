﻿/*
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
//#1-----------------------------------------------------------------------------
Console.Clear();
int[] arr = new int[10];
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    int n = new Random().Next(1, 101);
    arr[i] = n;
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= 20 && arr[i] <= 90)
    {
        Console.Write(arr[i] + " ");
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество элементов массива в диапазоне [20, 90]: " + count);
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
