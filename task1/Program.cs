// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine());
int max = 0;
if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}

if (number2 > number1)
{
    max = number2;
}
else
{
    max = number1;
}
if (number3 > number2)
{
    max = number3;
}
else
{
    max = number2;
}

Console.WriteLine("Максимальное число - " + max);



