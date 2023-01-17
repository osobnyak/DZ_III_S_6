// Задача 43. Напишите программу, которая найдёт точку пересечения 2-х прямых, заданных уравнением
// y = k1 * x + b1
// y = k2 * x + b2;
// значение b1, k1, b2 и k2 задаются пользоватлем.

//v.0.1.my

Console.WriteLine("введите b1: ");

double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("длина стороны b2 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("длина стороны k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("длина стороны k1 = ");
double b2 = Convert.ToInt32(Console.ReadLine());

double x = (((b1-b2)*-1)/(k1-k2));
double y = (k2 * x) + b2;

Console.Write(x);
Console.Write(",");
Console.Write(y);

Console.WriteLine();