//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int Number = new Random().Next(10, 99);
int Max = 10;
int MaxNumber()
{
    int Number1 = Number / 10;
    int Number2 = Number % 10;
    if (Number1 > Number2) Max = Number1;
    else Max = Number2;
    return Max;
}
MaxNumber();
Console.WriteLine($"В числе {Number} наибольшая цифра {Max}");