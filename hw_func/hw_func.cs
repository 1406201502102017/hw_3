/*
Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, 
второй – предпоследним и т.д.)
*/
Console.Clear();
//#1
// void infinityNum()
// {
//     bool x = true;
//     while (x)
//     {
//         int q = Convert.ToInt32(Console.ReadLine());
//         int sum = ((q / 10) + (q % 10)) % 2;
//         if (q > 10 & sum == 0) break;
//         else
//         {
//             string? s = Console.ReadLine();
//             if (s == "q") x = false;
//         }
//     }
// }
// infinityNum();
//#2
// void arrThree()
// {
//     int count = 0;
//     int n = Convert.ToInt32(Console.ReadLine());
//     int[] arr = new int[n];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         int num = new Random().Next(100, 1000);
//         arr[i] = num;
//         Console.Write(arr[i] + " ");
//         if (arr[i] % 2 == 0)
//             count++;
//     }
//     Console.WriteLine("\nКоличество четных чисел: " + count);
// }
// arrThree();
//#3
void arrReverse()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(1, 10);
        arr[i] = num;
    }
    Console.WriteLine(string.Join(" ", arr));
    int[] arrRev = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrRev[i] = arr[arr.Length - 1 - i];
    }
    Console.WriteLine(string.Join(" ", arrRev));
    // Array.Reverse(arr);
    // Console.WriteLine(string.Join(" ", arr));
    // arr[0] = arr[arr.Length-1-0];
    // arr[1] = arr[arr.Length-1-1];
    // arr[2] = arr[arr.Length-1-2];
    // arr[3] = arr[arr.Length-1-3];
    // arr[i] = arr[arr.Length-1-i];
}
arrReverse();
