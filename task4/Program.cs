Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7)
{
    Console.WriteLine( "ЭТОТ ДЕНЬ- ВЫХОДНОЙ!" );
}
/*if ( a > 7 || a<1)
{
    Console.WriteLine("Введите число от 1 до 7 ");
}
  else
{
    Console.WriteLine("Это рабочий день");
}*/

if (a<6 || a>7)
{
    Console.WriteLine("Это рабочий день");
}