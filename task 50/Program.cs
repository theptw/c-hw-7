// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


int[,] arr = new int[3,4];


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

void ResultElement(int[,] array)
{
    Console.WriteLine("Введите номер ряда элемента массива(начиная с 0): ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите номер колонки элемента массива(начиная с 0): ");
    int col = Convert.ToInt32(Console.ReadLine());

    if (row > array.GetLength(0) - 1 && col > array.GetLength(1) - 1) Console.WriteLine("Такого элемента не существует");
    else Console.WriteLine(array[row,col]); 

}



FillMatrixRand(arr, 0, 99);
PrintMatrix(arr);
ResultElement(arr);



