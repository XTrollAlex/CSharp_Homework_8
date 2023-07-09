// Задача 60:
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Задача 59:
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент 1, на выходе получим следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

void Main()
{
    int row = ReadInt("Введите X: ");
    int col = ReadInt("Введите Y: ");
    int apl = ReadInt("Введите Z: ");

    if (row <= 1 || col <= 1 || apl <= 1)
    {
        System.Console.WriteLine("Данный массив не является трёхмерным");
    }
    else if (row * col * apl > 90)
    {
        System.Console.WriteLine("Создание трехмерного массива с неповторяющимися двузначных чисел невозможно");
    }
    else
    {
        FillMatrix(row, col, apl);
    }
}

Main();

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int row, int col, int dep)
{
    int[,,] matrix = new int[row, col, dep];
    Random rand = new Random();
    for (int x = 0; x < row; x++)
    {
        for (int y = 0; y < col; y++)
        {
            for (int z = 0; z < dep; z++)
            {
                int buffer = rand.Next(10, 100);
                matrix[x, y, z] = buffer;
                System.Console.Write($"\t{matrix[x, y, z]}, ({x} {y} {z})");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}