// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int WriteNumbers(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

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

int line = WriteNumbers("Введите индекс строки элекмента: ");
int colum = WriteNumbers ("Введите индекс столбца элемента: ");

void Search(int [,]array)
{
    if(line<array.GetLength(0) && colum < array.GetLength(1))
    {
      System.Console.WriteLine($" Искомый элемент массива: {array[line,colum]}");  
    }
    else
    {
        System.Console.WriteLine($" Элемента с индексами [{line},{colum}] в массиве нет");
    }
}

Search(array);