int a = new Random().Next(1, 1000);
Console.WriteLine(a); // Выводим число, чтобы проверить наглядность работы кода;
int tries = 1;
while (tries <= 3)
{
    Console.Write("Попробуйте угадать число ");
    int myeffort = Convert.ToInt32(Console.ReadLine());
    if (myeffort == a)
    {
        Console.WriteLine("УГАДАЛ ЧИСЛО!");
        break;
    }
    else if (myeffort < a && tries<3)
    {
        Console.WriteLine("Ваше число меньше загаданного  ");
        Console.WriteLine("НЕ УГАДАЛ!");
    }
    else if (myeffort > a )
    {
        Console.WriteLine("Ваше число больше загаданного");
        Console.WriteLine("НЕ УГАДАЛ!");        
    }  
else if ( myeffort !=a && tries == 3 )
{
    Console.WriteLine("КАТКА ПРОИГРАНА!!");
}
tries++;
}
