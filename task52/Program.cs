// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[3, 4];
double[] meanarray = new double[array.GetLength(1)];
FillArray(array);
Console.WriteLine();
PrintArray(array);
MeanArithmetic(meanarray);
Console.WriteLine("\nCреднее арифметическое элементов в каждом столбце");
Console.WriteLine();
PrintMeanArithmetic(meanarray);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void MeanArithmetic(double[] meanarray)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int m = 0; double a = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            a += array[i, j];
            m++;
        }
        
        meanarray[j] = a / m;
    }

}

void PrintMeanArithmetic(double[] meanarray)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"{meanarray[i]:F1} ");
    }
}
Console.WriteLine();