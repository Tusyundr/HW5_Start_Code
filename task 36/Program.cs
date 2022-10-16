// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int arraylenght, arraymax, arraymin, sum;

Console.WriteLine("Введите число элементов массива: ");
arraylenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное допустимое значение элемента массива: ");
arraymax  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное допустимое значение элемента массива: ");
arraymin  = Convert.ToInt32(Console.ReadLine());
sum = 0;

int[] array = { };

array = ArrayGenerator(arraylenght, arraymax, arraymin);

 for (int i = 1; i < arraylenght; i += 2)
            {
                sum += array[i];
            }

            Console.WriteLine($"Сумма чисел на нечётных позициях: {sum}");

int[] ArrayGenerator(int lenght, int max, int min) 
{
     Console.Write("Создан массив, заполненный случайными числами: [");
    int[] array = new int[lenght];
       for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        {
            if(i < lenght - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}");
        } 
    }
    Console.WriteLine("]");
    return array;
    }