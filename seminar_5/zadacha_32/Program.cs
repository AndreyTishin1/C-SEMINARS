/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

int[] array = new int[5] { -45, -8, 7, 57, 8 };
Console.WriteLine("Исходный масссив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Преобразованный массив: ");
for (int i = 0; i < array.Length; i++)
{
   array[i] = array[i]*(-1);
   Console.Write(array[i] + " ");
}