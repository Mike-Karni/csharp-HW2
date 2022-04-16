/*Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры 
нет.*/

int number = RandomInt(10,150);
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);
if (number%100 == number)
{
    Console.WriteLine("ТРЕТЬЕЙ ЦИФРЫ НЕТ!!!");
}
else
{
Console.WriteLine($"{stringNumber[2]}");
}

int RandomInt(int enclusiveMin,int exclusiveMax)
{
    return new Random().Next(enclusiveMin,exclusiveMax);
}
 
