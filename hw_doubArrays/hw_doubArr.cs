/*
Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
Под удалением понимается создание нового двумерного массива без строки и столбца
*/
Console.Clear();
Console.Write("Ввести количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] mtx = new int[x, y];

void createDoubleArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// #1-----------------------------------------------------
int returnElement(int[,] arr, int a, int b)
{
    int f = 0;
    if (a <= arr.GetLength(0) & b <= arr.GetLength(1))
        f = arr[a, b];
    else
        Console.WriteLine("Такого элемента нет!");
    return f;
}

createDoubleArray(mtx);
int d = returnElement(mtx, 1, 2);
Console.WriteLine($"\nЗначение элемента равно: {d}");

// #2-----------------------------------------------------
void replaceRowArray(int[,] arr)
{
    Console.WriteLine("\nМассив с переставленной 1-ой и последней строкой\n");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int tmp = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = arr[0, i];
        arr[0, i] = tmp;
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

replaceRowArray(mtx);

// #3-----------------------------------------------------
void returnRowIndex(int[,] arr)
{
    int[] tmp = new int[arr.GetLength(0)];
    int p;
    int i;
    Console.Write("\nСуммы строк массива: ");
    for (i = 0; i < arr.GetLength(0); i++)
    {
        p = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
            p += arr[i, j];
        tmp[i] = p;
        Console.Write(p + " ");
    }
    int min = tmp[0];
    int index = 0;
    for (i = 0; i < tmp.Length; i++)
    {
        if (tmp[i] < min)
        {
            min = tmp[i];
            index = i;
        }
    }
    Console.Write($"--> минимальное значение {min} --> индекс строки: {index}\n");
}

returnRowIndex(mtx);
