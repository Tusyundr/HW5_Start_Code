// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int arraylenght, arraymax, arraymin, count;

Console.WriteLine("Введите число элементов массива: ");
arraylenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное допустимое значение элемента массива: ");
arraymax  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное допустимое значение элемента массива: ");
arraymin  = Convert.ToInt32(Console.ReadLine());
count = 0;

int[] array = { };

array = ArrayGenerator(arraylenght, arraymax, arraymin);

for (int i = 0; i < arraylenght; i++)

 {
    if (array[i] % 2 == 0) count++;
 }

Console.WriteLine($"Количество чётных чисел в массиве: {count}");

int[] ArrayGenerator(int lenght, int max, int min) 
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
    return array;
    }