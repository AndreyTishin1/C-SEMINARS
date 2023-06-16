Console.WriteLine("Введите трехзначное число: ");

double number = double.Parse(Console.ReadLine());

if(number > 99 && number < 1000)
{
    double number2 = number % 10;

Console.WriteLine("Посленяя цифра числа: ");

Console.Write(number2);
}
else
Console.WriteLine("Число не трехзначное");




