// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] NewArray()
{
    double[] array = new double[5];
    Console.Write("Массив [");
    for (int i = 0; i < 5; i++)
    {
        array[i] = new Random().Next(10, 99) + Math.Round(new Random().NextDouble(), 2 );
        Console.Write($"{array[i] + " "}");
    }
    Console.WriteLine("}\n");
    return array;
}

void Diff(double[] myArray)
{
    int indMax = 0;
    int indMin = 0;
    for (int i = 1; i < 5; i++)
    {
        if (myArray[i] > myArray[indMax]) indMax = i;
        if (myArray[i] < myArray[indMin]) indMin = i;
    }
    Console.WriteLine($"Разница max-min = {Math.Round(myArray[indMax] - myArray[indMin], 2)}");
}
Diff(NewArray()); 
