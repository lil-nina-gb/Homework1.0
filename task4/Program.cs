//Напишите программу, 
//которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число 1:  ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2:  ");
int number2 = int.Parse(Console.ReadLine());
int max = number1 > number2 ? number1 : number2;
int min = number1 < number2 ? number1 : number2;
Console.WriteLine("Максимальное число -  "+max+" Минимальное число - " +min);
