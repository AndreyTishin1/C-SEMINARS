/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/



int[] array = new int[7] { 1, 45, -32, -33, 0, 76, -2 };
Console.WriteLine("Введите число для поиска в массиве: ");
int number = int.Parse(Console.ReadLine());
massivPoisk(number);


void massivPoisk(int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine($"Число {number} находится в массиве под индексом {i}");
            Environment.Exit(0);
        }
    }
    Console.WriteLine("Заданного элемента нет в массиве.");
}

