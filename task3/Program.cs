int number = RandomInt(10,1001);
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);
if (number%100 == number)
{
    Console.WriteLine("ТРЕТЬЕЙ ЦИФРЫ НЕТ!!!");
}
Console.WriteLine($"{stringNumber[2]}");

int RandomInt(int enclusiveMin,int exclusiveMax)
{
    return new Random().Next(enclusiveMin,exclusiveMax);
}