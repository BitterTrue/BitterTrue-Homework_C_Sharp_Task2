//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter first number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third number:");
int thirdNumber = int.Parse(Console.ReadLine());

int max = firstNumber;
if (secondNumber>max) max = secondNumber;
if (thirdNumber>max) max = thirdNumber;

Console.WriteLine($"max={max}");
