/*
Задание 3
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandomNumbersFunction(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int min = numbers[0];
int max = numbers[0];

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
    {
        max = numbers[z];
    }

    if (numbers[z] < max)
    {
        min = numbers[z];
    }

}


Console.WriteLine($"Разница минимального {min} и максимального элементов {max} - {max - min}");

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
