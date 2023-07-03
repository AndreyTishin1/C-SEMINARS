/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

Console.WriteLine("Введите десятичное число:");
int number = int.Parse(Console.ReadLine());
int number2 = number;
int ostatok = 0;
string num = "";
while (number > 0)
{
    ostatok = number % 2;
    number = number / 2;
    num = num + ostatok;
}
int count = num.Length;
string dvoichnoe = "";
while (count > 0)
{
    dvoichnoe = dvoichnoe + num[count - 1];
    count--;
}
Console.WriteLine($"Число {number2} в двоичной системе равно {dvoichnoe}");
