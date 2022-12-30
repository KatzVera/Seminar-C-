// Задание 1: проверка 1е число квадрат 2го?

Console.Clear();
Console.Write("Введите число 1-e: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2-e: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m * m == n)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");


