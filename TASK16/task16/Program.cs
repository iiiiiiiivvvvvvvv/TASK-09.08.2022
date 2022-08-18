//Найти кубы чисел от 1 до N

Console.WriteLine("Введите число N");
int i = 1;
int N = int.Parse(Console.ReadLine());
 Console.WriteLine("Число" + "\t" + "Куб");
 for(i = 1; i<= N; i++)
 {
    Console.WriteLine(i + "\t" + i * i * i);
 }