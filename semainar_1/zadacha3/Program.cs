﻿Console.Write("введите номер дня недели: ");
int number =int.Parse(Console.ReadLine());
switch(number)
{
    case 1:
    Console.WriteLine("Понедельник");
    break;
    case 2:
    Console.WriteLine("Вторник");
    break;
    case 3:
    Console.WriteLine("Среда");
    break;
    case 4:
    Console.WriteLine("Четверг");
    break;
    case 5:
    Console.WriteLine("пятница");
    break;
    case 6:
    Console.WriteLine("Субботв");
    break;
    case 7:
    Console.WriteLine("Воскресенье");
    break;
    default:
    Console.WriteLine("Дня недели с таким номером не существует");
    break;



}