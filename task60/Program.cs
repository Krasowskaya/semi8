﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();

void CreateMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for(int k = 0; k< matrix.GetLength(2); k++)
                    matrix[i,j,k] = new Random().Next(-10,10);
            }
    }
}

void OutputMatrix(int[,,] matrix)
{
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for(int k = 0; k < matrix.GetLength(2); k++)
                
                   Console.WriteLine(matrix[i,j,k] + "(" + i + "," + j + "," + k + ")");
            }
            Console.WriteLine();
    }

}

Console.WriteLine("Введите Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите У: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());
int [,,] matrix = new int[x, y, z];
CreateMatrix(matrix);
OutputMatrix(matrix);