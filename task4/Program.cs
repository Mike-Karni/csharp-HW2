
 /*Напишите программу, которая принимает на 
вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.*/


/*Console.WriteLine("Введите число от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7)
{
    Console.WriteLine( "ЭТОТ ДЕНЬ- ВЫХОДНОЙ!" );
}
if (a<6 || a>7)
{
    Console.WriteLine("Это рабочий день");
}*/

int [] week = {1,2,3,4,5,6,7};
Console.WriteLine("Введите номер дня недели  от 1 до 7");
int d = Convert.ToInt32(Console.ReadLine());

if (d == week[5] || d == week[6])
{
    Console.WriteLine("Это выходной!");
}
else
{
    Console.WriteLine("Это рабочий день");
}

