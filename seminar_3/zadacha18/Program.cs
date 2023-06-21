Console.WriteLine("Введите номер четверти");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("В этой области Х > 0, и Y > 0");
        break;

    case 2:
        Console.WriteLine("В этой области Х < 0, а Y > 0");
        break;

    case 3:
        Console.WriteLine("В этой области Х < 0 и Y < 0");
        break;

    case 4:
        Console.WriteLine("В этой области Х > 0 а Y <0");
        break;
    default:
        Console.WriteLine("Такой четверти не существует.");
        break;
}