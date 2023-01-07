// Задача 21

Console.Clear();
Console.Write("Введите координату X 1-й точки: ");
double x_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y 1-й точки: ");
double y_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X 2-й точки: ");
double x_2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y 2-й точки: ");
double y_2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x_1 - x_2, 2) + Math.Pow(y_1 - y_2, 2)), 2));
