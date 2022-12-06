// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 3 -> 3

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-10, 11);
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

void ElementSearch(int[,] array, int userRows, int userColumns)
{
    if (userRows >= array.GetLength(0)
        || userColumns >= array.GetLength(1)
        || userRows < 0
        || userColumns < 0)
        Console.WriteLine($"Числа с индексами [{userRows};{userColumns}] нет в массиве");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (userRows == i && userColumns == j)
            {
                Console.WriteLine(array[i, j]);
                break;
            }

        }
    }
}

Console.Write("Создайте массив: укажите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns);

Console.Write("Укажите индекс строки для поиска: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите индекс столбца для поиска: ");
int userColumns = Convert.ToInt32(Console.ReadLine());

ElementSearch(array, userRows, userColumns);

Console.WriteLine("Исходный массив:");
PrintArray(array);
