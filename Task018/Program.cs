// Задача 22

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++) // цикл for для переборки значений
    Console.Write($"{i * i} "); // между {i*i} и " пробел, чтобы в ответе значения выводились через пробел. Вместо пробела можно поставить ","
