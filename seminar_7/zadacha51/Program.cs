/* задайте двумерный массив
найдите сумму элементов находящихся на главной диагонали.*/

Console.WriteLine("Введите количество строк массива:");
int strok = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int stolb = int.Parse(Console.ReadLine());
int[,] array = new int[strok, stolb];
Console.WriteLine();
int rezult = 0;

for (int i = 0; i < strok; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        array[i, j] = new Random().Next(10, 51);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < strok; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        if (i == j)
        {
            rezult = rezult + array[i, j];
        }
        else
        {
            rezult = rezult;
        }
    }
}
Console.WriteLine(rezult);
