// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 5 3
// 8 4 6 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.


int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MeanOFColumns(int[,] array)
{
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
        }
        result = result / array.GetLength(0);
        Console.Write($"{result:f1}" + " ");
        result = 0;
    }
}

Console.Write("Создайте массив: укажите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns);

Console.WriteLine("Ваш массив:");
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца:");
MeanOFColumns(array);
