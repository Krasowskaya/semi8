// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Print(int m, int n)
{
    if(m == 0)
        return n + 1;
    else if (n == 0 && m!=0)
        return Print(m - 1, 1);
    else
        return Print(m - 1, Print(m, n - 1));
}

Console.Clear();
Console.WriteLine("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Print(m, n));