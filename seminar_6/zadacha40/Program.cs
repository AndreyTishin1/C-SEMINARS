/*Задача 40:
 Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/

Console.WriteLine("Введите первое число:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
double num2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число:");
double num3 = double.Parse(Console.ReadLine());

if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
{
    Console.WriteLine("Треугольник с данными сторонами может сушествовать.");
}
else
{
    Console.WriteLine("Треугольник с данными сторнами существовать не может.");
}