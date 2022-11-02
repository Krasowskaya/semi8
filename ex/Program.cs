// See https://aka.ms/new-console-template for more information

int Print(int a, int b)
{
if (b == 0)
    return 1;
return Print(a, b - 1) * a;
}


Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Print(a, b));

