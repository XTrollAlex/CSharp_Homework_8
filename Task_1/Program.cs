// Задача 54:
// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int col = ReadInt("Введите количество столбцов: ");
    int[,] matrix = FillMatrix(row, col, 0, 100);
    System.Console.WriteLine("Исходная матрица:");
    PrintMatrix(matrix);
    System.Console.WriteLine();
    System.Console.WriteLine("Матрица с сортировкой строк по убыванию:");
    PrintMatrix(SortingRow(matrix, row, col));
}

Main();

int[,] SortingRow(int[,] matrix, int row, int col)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int x = 0; x < col - j - 1; x++)
            {
                if (matrix[i, x] < matrix[i, x + 1])
                {
                    int temp = 0;
                    temp = matrix[i, x];
                    matrix[i, x] = matrix[i, x + 1];
                    matrix[i, x + 1] = temp;
                }
            }
        }
    }

    return matrix;
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrixToPrint)
{
    for (int i = 0; i < matrixToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}