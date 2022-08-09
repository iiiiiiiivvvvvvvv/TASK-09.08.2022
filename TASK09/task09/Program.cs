// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Ввести трехзначное число:");
int n = int.Parse(Console.ReadLine());
int number1 = n % 10;
int number3 = n / 100;
int result = number3 * 10 + number1;
Console.WriteLine("Полученный результат " + result);
