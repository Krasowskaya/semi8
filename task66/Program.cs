// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Print(int m, int n)
{
    if( n == m )
        return m;
    return Print(m, n - 1) + n;
}


Console.Clear();
Console.WriteLine("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Print(m, n));