// Задача 5. Решение через цикл while

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = (-1) * n;
while (i <= n)
{
    Console.Write($"{i} ");
    i++; // i = i + 1
}


