// Задача 16

Console.Clear();
Console.Write("введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число 2: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n * n == m || m * m == n)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
    
