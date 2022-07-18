// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arr = new int[3,4];
double average = 0;


int[,] FillMatrixRand(int[,] array, int min,int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
     for (int j = 0; j < array.GetLength(1); j++)
         {
        if (j == 0 ) Console.Write("|"); 
        if (j < array.GetLength(1) - 1 & array[i,j]/10 >= 1) Console.Write(array[i,j] + "|");
        else if (j < array.GetLength(1) - 1) Console.Write(array[i,j] + " |");
        else if (array[i,j] / 10 >= 1) Console.Write(array[i,j] + "|");
             else Console.Write(array[i,j] + " |");
         }
        Console.WriteLine();
     }
}

void Avg(int[,] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            
            average += array[i,j];
            
        }
        average /= array.GetLength(0);
        
        Console.WriteLine($"Среднее арифметическое  = {Math.Round(average,1)} ");
    }
    
    
}

FillMatrixRand(arr, 0, 20);
PrintMatrix(arr);
Avg(arr);