/*int GetFact(int number)
{
    if (number == 1) return 1;

    int factor = number * GetFact(number - 1);
    return factor;
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int factorial = GetFact(number);
Console.WriteLine($"Факториал {number} равен {factorial}");*/


int GetPosl(int n)
{
    if (n == 0) return 1;
    int posled = 1 + GetPosl(n - 1);
    Console.Write(n + " ");
    return posled;
}

Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine());
GetPosl(number);