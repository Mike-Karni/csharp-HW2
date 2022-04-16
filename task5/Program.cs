/*Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше*/

// Решение
int a = RandomInt(1,1000);
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
// ФУНКЦИЯ!
int RandomInt(int minN,int maxN)
{
    return new Random().Next(minN,maxN);
}