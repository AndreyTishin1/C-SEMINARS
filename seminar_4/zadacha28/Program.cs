/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

void factorial(int number)
{
    int fact = 1;
    int index = number;
    while (index > 1)
    {
        fact = fact * index;
        index = index - 1;
    }
    Console.WriteLine($"Факториал числа {number} равен {fact}");
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
factorial(number);