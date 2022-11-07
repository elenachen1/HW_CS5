﻿/*
Задача 2.
 Задайте одномерный массив, заполненный случайными числами.
  Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandomNumbersFunction(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] % 2 != 0)
    {
        sum+=numbers[z];
    }
}


Console.WriteLine($"Сумма нечетных чисел равна - {sum}");

void ArrayRandomNumbersFunction(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
