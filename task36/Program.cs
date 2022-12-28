// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int[] NewArray()
{
    Console.Write("Массив [");
    int[] array = new int[5];
    for (int i = 0; i < 5; i++)
    {
        array[i] = new Random().Next(-10, 10);
        Console.Write($"{array[i] + " "}");
    }
    Console.WriteLine("]");
    return array;
}

void FindSum(int[] myArray)
{
    int sum = 0;
    for (int i = 0; i < 5; i++)
    {
        if (i % 2 != 0) sum += myArray[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");
}
FindSum(NewArray());