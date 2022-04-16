/*Напишите программу, которая принимает на 
вход трёхзначное число и на выходе показывает вторую 
цифру этого числа.*/

int number = RandomInt(100,1000);
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);
Console.WriteLine($"{stringNumber[1]}");

int RandomInt(int enclusiveMin,int exclusiveMax)
{
    return new Random().Next(enclusiveMin,exclusiveMax);
}