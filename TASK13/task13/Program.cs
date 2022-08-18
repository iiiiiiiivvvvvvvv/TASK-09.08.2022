// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
if(a == b * b)
{
    Console.WriteLine("Является квадратом");
}
else
{
   Console.WriteLine("Не является квадратом");  
}