// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
    Console.WriteLine("Число четное");
else 
Console.WriteLine("Число нечетное");