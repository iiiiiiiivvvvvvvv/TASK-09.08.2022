//Третья цифра в 3х значном числе
Console.Clear();
System.Console.WriteLine();

int number = new Random().Next(100, 1000);

System.Console.WriteLine($"Последняя цифра {number}  цифра {number%10}");
System.Console.WriteLine();