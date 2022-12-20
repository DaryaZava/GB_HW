// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
void GetSumNums(int number)

{
    int sum = 0;
    while(number > 0)
{
    sum += number%10;
    number = number / 10;
}
Console.WriteLine($"Сумма чисел = {sum}");
}
GetSumNums(num);