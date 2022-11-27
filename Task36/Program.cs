// Задача 36: 
// Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[9];
int[] GetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}
double GetCountOddSum(int[] array)
{
        double sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)     // нечетные элементы, нумерация с нуля
            sum +=array[i];
    }
    return sum;
}
GetArray(array);
Console.WriteLine("[" + String.Join(" ", array) + "]");
Console.WriteLine("Сумма элементов на нечётных позициях = " + GetCountOddSum(array));