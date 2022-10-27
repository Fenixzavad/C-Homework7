// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.

void PrintArray(double [,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
         System.Console.Write($"{matrix[m,n]:f1} ");   
        }
    System.Console.WriteLine();
    }
}

void FillArray(double [,] matrix )
{
    Random array = new Random();
     for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
          matrix[m,n] = array.Next(0,5) + array.NextDouble();
        }
    }
}
double [,] matr = new double [3,4];
FillArray(matr);
PrintArray(matr);
