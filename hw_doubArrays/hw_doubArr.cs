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
// int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Console.WriteLine("[" + string.Join(" ", array) + "]");
// int[,] mtx = new int[array[0], array[1]];
// int returnElem(int[,] mtx)
// {
//     int f = 0;
//     return f;
// }
// int d = returnElem(mtx);
Console.Write("Ввести количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] mtx = new int[x, y];

void createArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            mtx[i, j] = new Random().Next(0, 10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

createArray(mtx);