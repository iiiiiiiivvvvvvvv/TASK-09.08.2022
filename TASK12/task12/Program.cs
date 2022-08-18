//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine();
int numberDay = new Random(). Next(1, 8);
string[] day = { " Понедельник ", " Вторник ", " Среда ", " Четверг ", " Пятница ", " Суббота ", " Воскрксенье " };
string result = "";
if (numberDay > 5) result = "Выходной день";
else result = "Рабочий день";
Console.WriteLine();
Console.WriteLine ($"{numberDay}-й день недели - это {day [numberDay-1]} {result}");