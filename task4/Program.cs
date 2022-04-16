Console.WriteLine("Введите число от 1 до семи");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7)
{
    Console.WriteLine( "ЭТОТ ДЕНЬ- ВЫХОДНОЙ!" );
}
if (a<6 || a>7)
{
    Console.WriteLine("Это рабочий день");
}
*+ ещё одно условие ограничивающее ввод!*
