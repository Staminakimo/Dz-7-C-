/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Console.WriteLine("Введите n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите m:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, m];
int[] sum = new int[m];
double result = 0;
Random ran = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = ran.Next(0, 10);

        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[i] += arr[j, i];

    }
}

for (int i = 0; i < m; i++)

{
    result = sum[i] / n;
    Console.WriteLine($"Среднее арифметическое столбца {i + 1}: {result}");
}
Console.WriteLine();

