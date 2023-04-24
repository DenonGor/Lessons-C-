/*  Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

Console.Write("Введите Элемент массива: ");
int item = Convert.ToInt32(Console.ReadLine());
int n = 4; 
int m = 3; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(0, 9);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
{for (int i = 0; i < arr.GetLength(0); i++)

    for (int j = 0; j < arr.GetLength(1); j++)
         if (arr[i,j]==item) 
         Console.WriteLine($"{i},{j}");
         else
        Console.WriteLine("Элемент не существует");
}
        