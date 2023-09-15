//Вариант 20 задание 1 сложность 3

//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Введите c:");
//double c = double.Parse(Console.ReadLine());
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//double U = (Math.Pow(Math.Tan(y), 3) + Math.Pow(Math.Sin(x * Math.Sqrt(b - c)), 5)) / (Math.Sqrt(a - b + c));
//Console.WriteLine($"U={U:F2}");

//Вариант 20 задание 2 сложность 3

Console.Write("Введите  V1:");
double V1 = double.Parse(Console.ReadLine());
Console.Write("Введите  V2:");
double V2 = double.Parse(Console.ReadLine());
Console.Write("Введите  V3:");
double V3 = double.Parse(Console.ReadLine());
double R1 = Math.Pow(((3 * V1) / (4 * Math.PI)), -3);
double R2 = Math.Pow(((3 * V2) / (4 * Math.PI)), -3);
double R3 = Math.Pow(((3 * V3) / (4 * Math.PI)), -3);
double Z = (R1 + R2 + R3) / (3);
Console.WriteLine($"Z={Z:F2}");