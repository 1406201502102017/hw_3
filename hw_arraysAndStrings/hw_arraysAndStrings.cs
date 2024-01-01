/*
Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть 
также разделены пробелами.
*/

// #1-----------------------------------------------------
/*
Console.Clear();
Console.Write("Ввести строку 1: ");
string s1 = Console.ReadLine().ToLower();
Console.Write("Ввести строку 2: ");
string s2 = Console.ReadLine().ToLower();
char[] arrS1 = new char[s1.Length];
for (int f = 0; f < arrS1.Length; f++)
{
    arrS1[f] = s1[f];
}
Console.WriteLine(string.Join(" ", arrS1));

char[] arrS2 = new char[s2.Length];
for (int f = 0; f < arrS2.Length; f++)
{
    arrS2[f] = s2[f];
}
Console.WriteLine(string.Join(" ", arrS2));

char[,] symbols = new char[,]{};
for (int i = 0; i < symbols.GetLength(0); i++)
{
    for (int j = 0; j < symbols.GetLength(1); j++)
    {

    }
}
Console.WriteLine(string.Join(' ', symbols));
// #2-----------------------------------------------------
Console.Write("Ввести строку: ");
string s = Console.ReadLine();
char[] arr = new char[s.Length];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = s[i];
}
Console.WriteLine(string.Join("", arr).ToLower());
// #3-----------------------------------------------------
for (int i = 0; i < s.Length / 2; i++)
{
    arr[i] = s[i];
}
Console.WriteLine(string.Join("", s).ToLower());
*/
