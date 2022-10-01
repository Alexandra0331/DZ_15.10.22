//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


//Console.WriteLine("размер массива: ");
//int size = Convert.ToUInt32(Console.ReadLine());
//int [] numbers = new int [size];
//FillArrayRondomNumbers(numbers);
//Console.WriteLine("массив: ");
//PrintArray(numbers);
//int count = 0;
//for (int z = 0; z = numbers.Length; z++);
//if (numbers [z] % 2 == 0);

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99, 1000);
}
int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(ReleaseArray(array));
