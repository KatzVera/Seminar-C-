// Задача 18

Console.Clear();
Console.Write("Введите номер четверти: ");
double n = Convert.ToDouble(Console.ReadLine());

while (n < 1 || n > 4)
{
    Console.WriteLine("Mistake... Try again!");
    n = Convert.ToInt32 (Console.ReadLine());
}

if (n == 1)
    Console.WriteLine("X > 0; Y > 0");
else if (n == 2)
    Console.WriteLine("X < 0; Y > 0");
else if (n == 3)
    Console.WriteLine("X < 0; Y < 0");
else // 4 четверть
    Console.WriteLine("X > 0; Y < 0");
