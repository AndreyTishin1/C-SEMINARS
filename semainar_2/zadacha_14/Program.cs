Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int per1 = 7;
int per2 = 23;

if (number % per1 == 0 && number % per2 == 0)
{
    Console.WriteLine($"{number} делится без остатка на {per1} и {per2}");
}
else
{
    Console.WriteLine("Без остатка не делится");
}