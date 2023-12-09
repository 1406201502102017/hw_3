/*
Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.

Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и 
показывает наибольшую цифру числа.

Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
а на выходе показывает его цифры через запятую.
*/
Console.Clear();
//#1
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
    Console.WriteLine("yes");
else 
    Console.WriteLine("no");
//#2
Console.Write("Enter x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x != 0 && y != 0 && x <= 50 && y <= 50) 
    Console.WriteLine("1");
else if (x != 0 && y != 0 && x > 50 && x <= 100 && y <= 50)
    Console.WriteLine("2");
else if (x != 0 && y != 0 && x > 50 && y > 50 && x <= 100 && y <= 100)
    Console.WriteLine("3");
else if (x != 0 && y != 0 && x <= 50 && y > 50 && y <= 100)
    Console.WriteLine("4");
else
    Console.WriteLine("Enter number more than zero");
//#3
int num = new Random().Next(10, 100);
Console.WriteLine(num);
if (num / 10 > num % 10)
    Console.WriteLine(num / 10);
else if (num / 10 < num % 10)
    Console.WriteLine(num % 10);
else
    Console.WriteLine("Numbers are equals");
//#4
// Console.Write("Enter number: ");
// int n = Convert.ToInt32(Console.ReadLine());
int n = new Random().Next(10000, 1000001);
Console.WriteLine(n);
int[] array = new int[n.ToString().Length];
for(int i = 0; i < array.Length; i++)
{
    array[i] = n % 10;
    n /= 10;
}
Array.Reverse(array);
Console.WriteLine(string.Join(", ", array));
// 398943

// int[] array = new int[6];

// array[0] = 398943 % 10; --> 3
// n /= 10; --> 39894
// array[1] = 39894 % 10; --> 4
// n /= 10; --> 3989
// array[2] = 3989 % 10; --> 9
// n /= 10; --> 398
// array[3] = 398 % 10; --> 8
// n /= 10; --> 39
// array[4] = 39 % 10; --> 9
// n /= 10; --> 3
// array[5] = 3 % 10; --> 3
// n /= 10; --> 0

// 349893