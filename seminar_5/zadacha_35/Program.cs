/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

void massiv(int[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to);
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
    Console.WriteLine();

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) 
        {
            count = count + 1;
        }    
        else
        {
            count = count;
        }
    }
    Console.WriteLine($"{count} чисел в диапазоне от {from} до {to} в массиве из 123 элементов ");
}

Console.WriteLine("Введите диапазон чисел поиска from...to");
int from = int.Parse(Console.ReadLine());
int to = int.Parse(Console.ReadLine());
int[] array = new int[123];
massiv(array, from, to);