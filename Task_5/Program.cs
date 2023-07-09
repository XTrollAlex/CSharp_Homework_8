// Задача 62:
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void Main()
{
int row = ReadInt("Введите количество строк: ");
int col = ReadInt("Введите количество столбцов: ");
PrintMatrix(Spiral(row, col));
}

Main();

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] Spiral(int row, int col)
{
int[,] matrix = new int[row, col];
int minRow = 0, maxRow = row - 1, minCol = 0, maxCol = col - 1;
int count = 1;
int max = row * col;
while (count <= max)
{
    for (int i = minCol; i <= maxCol; i++)
    {
        matrix[minRow, i] = count;
        count++;
    }
    minRow = minRow + 1;

    for (int i = minRow; i <= maxRow; i++)
    {
        matrix[i, maxCol] = count;
        count++;
    }
    maxCol = maxCol - 1;

    if (count <= max)
    for (int i = maxCol; i >= minCol; i--)
    {
        matrix[maxRow, i] = count;
        count++;
    }
    maxRow = maxRow - 1;

    if (count <= max)
    for (int i = maxRow; i >= minRow; i--)
    {
        matrix[i, minCol] = count;
        count++;
    }
    minCol = minCol + 1;
}
return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}