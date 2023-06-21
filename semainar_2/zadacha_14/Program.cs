Console.WriteLine("Введите число, которое будем делить: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите первое число, на которое будем делить: ");
int per1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число, на которое будем делить: ");
int per2 = int.Parse(Console.ReadLine());

if (number % per1 == 0 && number % per2 == 0)
{
    Console.WriteLine($"{number} делится без остатка на {per1} и {per2}");
}
else
{
    Console.WriteLine("Без остатка не делится");
}