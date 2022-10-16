// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int arraylenght, arraymax, arraymin;
double resultdiff;

double minarray = 0;
double maxarray = 0;

Console.WriteLine("Введите число элементов массива: ");
arraylenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное допустимое значение элемента массива: ");
arraymax  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное допустимое значение элемента массива: ");
arraymin  = Convert.ToInt32(Console.ReadLine());

double [] array = new double[arraylenght];

 for (int i = 0; i < arraylenght; i++)
    {    
    array[i] = new Random().NextDouble();
    array[i] = array[i] * (arraymax - arraymin) + arraymin;
    array[i] = Math.Round(array[i], 2);
    
    if (i == 0)
    {
        maxarray = array[i];
        minarray = array[i];
    }
        if (array[i] > maxarray) maxarray = array[i];
        if (array[i] < minarray) minarray = array[i];
    }
PrintArray (array);
resultdiff = maxarray - minarray;
Console.WriteLine($"Разница между максимальным и минимальным значениями: ");
Console.WriteLine($"{maxarray} - {minarray} = {resultdiff}");


void PrintArray (double [] arr)
{
Console.Write("Создан массив: [");
for (int i = 0; i < arraylenght; i++)
{
     if(i < arraylenght - 1) Console.Write($"{array[i]}; ");
     else Console.Write($"{array[i]}");
} 
    Console.WriteLine("]");
}