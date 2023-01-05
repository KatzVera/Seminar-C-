// задача 11

Console.Clear();

int number = new Random().Next(100, 1000); // [100, 999)
Console.WriteLine($"Сгенерированное число: {number}");
int n1 = number / 100;
int n3 = number % 10;
Console.WriteLine(n1 * 10 + n3 *1);
// ConsolWrite(n1); при таком выводе получается 
//ConsoleWrite(n3);     2 отдельных числа, а не целое двухзначное
