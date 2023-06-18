Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int ostatok = 0;

//Console.WriteLine(number1);
//Console.WriteLine(number2);

if (number1 % number2 == 0)
{
    Console.WriteLine($"Число {number1} кратно числу {number2}");
}
else
{
ostatok = number1 % number2;
Console.WriteLine($"Число {number1} не кратно числу {number2}, остаток {ostatok}");
}