// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[9];
double[] GetArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*100;
    }
    return array;
}
GetArray(array);
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i]) 
        min = array[i];
    if (max < array[i]) 
        max = array[i];
}
Console.Write("[" + String.Join(" ", array) + "] -> ");
Console.WriteLine(max-min);