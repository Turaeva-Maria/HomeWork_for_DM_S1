// Задача 4: Напишите программу, которая принимает на вход три
// числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите значение первого числа: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение второго числа: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение третьего числа: ");
int k = Convert.ToInt32(Console.ReadLine());
int max=0;
if(n>m)
max=n;
else 
max=m;
if(k>max)
max=k;
Console.Write("max = ");
Console.Write(max);
