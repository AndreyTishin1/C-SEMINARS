/* задайте двумерный массив размера m на n
каждый элемент в массиве находится по формуле m+n
выведите полученный масиив на экран*/

Console.WriteLine("Введите количество строк в массиве: ");
int strok = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int stolb = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine();

int[,] array = new int[strok, stolb];

for (int m = 0; m < strok; m++)
{
    for (int n = 0; n < stolb; n++)
    {
        array[m, n] = m + n;
        Console.Write(array[m, n] + " ");
    }
Console.WriteLine();        
}
