/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/


Console.WriteLine("Введите координаты точки A: x=, y=  ");
double xa = double.Parse(Console.ReadLine());
double ya = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: x= y= ");
double xb = double.Parse(Console.ReadLine());
double yb = double.Parse(Console.ReadLine());

double rassto = Math.Sqrt((Math.Pow(xb - xa, 2)) + (Math.Pow(yb - ya, 2)));
Console.WriteLine($"Расстояние между двумя точками ={rassto}");