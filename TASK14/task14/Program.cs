// Задать номер четверти, показать диапазоны для возможных координат

int quarterNum = new Random().Next(1, 5);
string range = "";
string num = "";
if (quarterNum == 1) range = "x > 0, y > 0";
else if (quarterNum == 2) range = "x > 0, y < 0";
else if (quarterNum == 3) range = "x < 0, y < 0";
else if (quarterNum == 4) range = "x < 0, y > 0";
Console.WriteLine($"Для {quarterNum} -й четверти задать точки ({range})");
Console.WriteLine();