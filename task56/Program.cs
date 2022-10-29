// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

void CreateMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-10,10);
            Console.Write(matrix[i,j] + " \t");
        }
        Console.WriteLine();
    }
}


void SearchSumRows(int[,] matrix)
{
int[] SumRows = new int[matrix.GetLength(0)];
for( int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            {
                SumRows[i] = SumRows[i] + matrix[i,j];
            }
    }
Console.WriteLine($"Суммы строк массива: [{string.Join(", ",SumRows)}]");

int k = SumRows[0];
int MinSum = 0;
for(int i = 0; i < SumRows.GetLength(0); i++)
{
    if(SumRows[i] < k)
    MinSum = i + 1;
}
Console.WriteLine($"Строка, содержащая минимальную сумму элменетов: {MinSum}");
Console.WriteLine($"Наименьшая сумма элментов: {k}");
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество колонок: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] matrix = new int[n,m];
CreateMatrix(matrix);
Console.WriteLine("Результат:");
SearchSumRows(matrix);