//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

Console.WriteLine("Введите число для проверки с элементами массива");
int number = int.Parse(Console.ReadLine());
int[,] array = new int[3, 4];
FillArray(array);
Console.WriteLine();
PrintArray(array);
ElementArray(number);

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


int ElementArray(int num)
{
    int m = 0;
    foreach (int arr in array)
    {
        if (arr == num)
        {
            m++;
        }
    }
    if (m > 0)
    {
        Console.WriteLine($"Элемент {number} есть в массиве");
    }
    else
    {
        Console.WriteLine($"Элемент {number} отсутствует в массиве");
    }
    return num;
}

