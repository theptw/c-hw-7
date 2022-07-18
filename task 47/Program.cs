// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] arr = new double[3,4];

double[,] FillMatrixRand(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(0, 20) + rand.NextDouble();
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             if (j == 0 ) Console.Write("|"); 
             if (j < array.GetLength(1) - 1 & array[i,j]/10 >= 1) Console.Write(Math.Round(array[i,j], 1) + "|");
             else  if (j < array.GetLength(1) - 1) Console.Write(Math.Round(array[i,j], 1) + " |");
             else if (array[i,j] / 10 >= 1) Console.Write(Math.Round(array[i,j], 1) + "|");
             else Console.Write(Math.Round(array[i,j], 1) + " |");
        }
        Console.WriteLine();
    }

}

FillMatrixRand(arr);
PrintMatrix(arr);