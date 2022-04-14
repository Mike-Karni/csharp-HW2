int a = new Random().Next(1,1000);
Console.WriteLine(a);
Console.WriteLine("Играем в угадайку! Загадай число!");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) 
{
    Console.WriteLine("НЕ УГАДАЛИ!Загаданное число больше введённого");
}
if (a<b) 
{
    Console.WriteLine("НЕ УГАДАЛИ!Загаданное число меньше введённого");
}
if (a==b)
{
    Console.WriteLine("Вы угадали число");
}
/*int tries = 0;
while (tries <2)
{
    if (a!=b)
    {
        Console.WriteLine("Вы не угадали! ещё разок!");
     
    }
    else
    {
        Console.WriteLine("Наконец то угадали!");
    }
        tries++;
        int c = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("GAME OVER");*/