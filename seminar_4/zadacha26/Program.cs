/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

void metod(int number)
{
    int count = 0;  
    while (number > 0)
    {  
        number = number/10;
        count++;
    }
Console.WriteLine($"Количество цифр в числе: {count}");
}
Console.WriteLine("Введите число: ");
int number =  Math.Abs(int.Parse(Console.ReadLine()));
metod(number);
