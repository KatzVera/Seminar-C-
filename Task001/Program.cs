// Про високосный год

Console.Clear();
Console.Write("Введите год: ");
int year = Convert.ToInt32(Console.ReadLine()); // |2 147 000 000|

// int a = int.Parse(Console.ReadLine());
// || - или (or, +)
// && - и (and, *)

if (year % 400 == 0 || year % 100 != 0 && year % 4 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");


