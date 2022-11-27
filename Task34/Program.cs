﻿// Задача 34: 
// Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[10];
int[] GetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int GetCountEven(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
     }
     return count;
}
GetArray(array);
Console.Write("[" + String.Join(" ", array) + "]");
Console.WriteLine();
Console.WriteLine("количество чётных чисел = " + GetCountEven(array));