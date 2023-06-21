Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int count = 1;
if (number >= 0)
{
    while (number / 10 > 0)
    {
        count++;
        number = number / 10;

    }
    Console.WriteLine($"Количество цифр в числе {count}");
}
else
{
    number = number * -1;
    while (number / 10 > 0) 
    {
        count++;
        number = number / 10;
    }
    Console.WriteLine($"Количество цифр в числе {count} ");

}

