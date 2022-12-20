// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int GetSumNums(int sum);

{
    int sum = 0;
    while( number > 10)
{
    number = number/10;
    sum += number%10;
}
    return sum;
Console.WriteLine($"Сумма чисел = {GetSumNums(sum)}");
}
