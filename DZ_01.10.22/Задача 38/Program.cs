// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
 double [] array = new double[n];
Random rand = new Random();
void InputArray(double [] array)
{
   for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1,10);
}       
InputArray (array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
    
    double min = 0;
    double max = 0;
    double  count = max - min;
    
for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > max)
        {
            max = array [i];
        }  
        if (array [i] < min) 
        {
             min = array [i];
        } 
    } 
//return count; 
  Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}"); 

        