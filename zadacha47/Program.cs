// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int rows, int columns, int minRandomValue, int maxRandomValue)
{
    double[,] array = new double[rows, columns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble() * rand.Next(minRandomValue, maxRandomValue + 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1}\t" + " ");
        }
        Console.WriteLine();
    }
}


Console.Write("Укажите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимальное число: ");
int minRandomValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите максимальное число: ");
int maxRandomValue = Convert.ToInt32(Console.ReadLine());

double[,] array = GetArray(m, n, minRandomValue, maxRandomValue);

PrintArray(array);