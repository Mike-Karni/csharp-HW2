// Напишите программу, которая принимает на  вход два числа и проверяет, является ли одно число квадратом другого. 

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = a/b;

if (c == b)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Число {a}  НЕ является квадратом числа {b}");
}
