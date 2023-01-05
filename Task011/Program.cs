//Задача 12

Console.Clear();
Console.Write("введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число 2: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n % m == 0)
    Console.WriteLine("кратно");
else
    Console.WriteLine($"не кратно, остаток {n % m}");

