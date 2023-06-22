/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.*/

Console.Write("Введите число: ");
double number = int.Parse(Console.ReadLine());
double index = 1;
double sqwere = 1;
while (index <= number)
{
    sqwere = Math.Pow(index, 2);
    Console.Write($"{sqwere}, ");
    index++;
}