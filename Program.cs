
//Задача 41. Пользователь водит с клавиатуры М чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//v.0.1.my

Console.WriteLine("сколько чисел будете вводить? ");
int lng = Convert.ToInt32(Console.ReadLine());
int[] a = new int[lng];
int count = 0;

Console.WriteLine("вводите числа: ");

for (int i = 0; i < a.Length; ++i)
{
    a[i] = int.Parse(Console.ReadLine());
    //Console.WriteLine($"{a[i]}");
    if (a[i]>0)
    {count = count + 1;}
}
Console.Write("чисел больше нуля = ");
Console.WriteLine(count);
