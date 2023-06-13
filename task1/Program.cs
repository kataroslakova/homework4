// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow юзать нельзя.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

System.Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(System.Console.ReadLine()!);

System.Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(System.Console.ReadLine()!);

int Value(int num1, int num2)
{
    int count = 1;
    for (int i = 0; i < num2; i++)
    {
        count = count*num1;
    }
    return count;

}
System.Console.WriteLine($"Число {num1} в степени {num2} равно {Value (num1, num2)}");