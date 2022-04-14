int number = RandomInt(100,1000);
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);
Console.WriteLine($"{stringNumber[0]}{stringNumber[2]}");

int RandomInt(int enclusiveMin,int exclusiveMax)
{
    return new Random().Next(enclusiveMin,exclusiveMax);
}