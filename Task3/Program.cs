// Задача 3: Напишите программу, 
// которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

System.Console.Writeline("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10;
int b = number % 10;

if (a > b)
{
    Console.Write("a");
}
else
{
    Console.Write("b");
}