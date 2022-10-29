// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillArray(int [,] matrix)
{
     for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
          matrix[m,n] = new Random().Next(0,5);
        }
    }
}

void PrintArray(int [,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
         System.Console.Write($"{matrix[m,n]} ");   
        }
    System.Console.WriteLine();
    }
}

int [,] array = new int  [3,4];
FillArray(array);
PrintArray(array);

void Averege(int [,] array)
{
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0):f2} ");
}
Console.ReadLine();
}
Averege(array);

