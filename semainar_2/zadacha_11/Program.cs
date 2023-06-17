// Напишите программу которая генерирует слуйчайное трехзначное число и удаляет вторую цифру из результата 456 -- 46

// можем предоставить пользователю возможность ввести начало и конец отрезка самому. (до 8 строчки)
Console.Write("Задайте начальное число отрезка: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Задайте конечную точку отрезка: ");
int num2 = int.Parse(Console.ReadLine());

int number = new Random().Next(num1, num2);
Console.WriteLine(number);
int number1 = number / 100;
Console.WriteLine(number1);
int number3 = number % 10;
Console.WriteLine(number3);
Console.WriteLine($"{number1}{number3}");