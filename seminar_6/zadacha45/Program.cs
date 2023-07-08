/*Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

Console.WriteLine("Введите количество элементов массива:");
int num = int.Parse(Console.ReadLine());
int[] array = new int[num];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 15);
    Console.Write(array[i] + " ");
}
Console.WriteLine("");

int[] array2 = new int[array.Length];
for (int j = 0; j < array2.Length; j++)
{
    for (int i = 0; i < array.Length; i++)
    {
        array2[j] = array[i];
    }
Console.Write(array[j] + " ");
}


