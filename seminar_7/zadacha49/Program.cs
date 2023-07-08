/* задайте двумерный массив
найдите элементы, у которых оба индекса четные и замените эти элементы на их квадраты*/

Console.WriteLine("Введите количество строк массива:");
int strok = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int stolb = int.Parse(Console.ReadLine());
int[,] array = new int[strok, stolb];
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < strok; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        array[i, j] = new Random().Next(10, 51);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < strok; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        if (i < 2 || i % 2 > 0 || j < 2 || j % 2 > 0)
        {
            array[i, j] = array[i, j];
            Console.Write(array[i, j] + " ");
        }
        else
        {
            array[i, j] = array[i, j] * array[i, j];
            Console.Write(array[i, j] + " ");
        }
    }
    Console.WriteLine();
}