// Задача 14

Console.Clear();
Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
    