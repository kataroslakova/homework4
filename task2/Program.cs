// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число: ");
int num = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine($"Сумма цифр в числе {num} = {Sum(num)}");

int Sum (int num)
{
    int result = 0;
    while (num>0)
    {
        result = result + num % 10;
        num = num/10;

    }
    return result;
}
