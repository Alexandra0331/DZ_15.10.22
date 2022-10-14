// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();
int[,] table = new int[4, 4];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberMinSumElements(table);

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void NumberMinSumElements(int[,] array)
{
    int min = 0;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        min = min+table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sum =sum+ table[i, j];
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.Write($"{minSum + 1} строка");
}



