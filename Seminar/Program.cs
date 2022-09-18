// Задача 2: Напишите программу, которая на вход принимает два 
// числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите значение первого числа: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение второго числа: ");
int m = Convert.ToInt32(Console.ReadLine());
int max=0;
int min=0;

if(n>m) 
{
    max=n; min=m;
    Console.Write("max = ");
    Console.Write(max);
    Console.Write(", min = ");
    Console.Write(min);
}
if(m>n)
{
    max=m; min=n;
    Console.Write("max = ");
    Console.Write(max);
    Console.Write(", min = ");
    Console.Write(min);
}