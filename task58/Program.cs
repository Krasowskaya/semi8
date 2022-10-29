// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

void CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


void MultiMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] ResultMatrix = new int[FirstMatrix.GetLength(0),FirstMatrix.GetLongLength(1)];
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            ResultMatrix[i,j] = FirstMatrix[i,j] * SecondMatrix[i,j];
            Console.Write(ResultMatrix[i,j] + " \t");
        }
        Console.WriteLine();
    }
}       


Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество колонок: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходные матрицы: ");
int[,] FirstMatrix = new int[n, m];
CreateMatrix(FirstMatrix);
Console.WriteLine();
int[,] SecondMatrix = new int[n, m];
CreateMatrix(SecondMatrix);
Console.WriteLine("Результатирующая матрица:");
MultiMatrix(FirstMatrix, SecondMatrix);