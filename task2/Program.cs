/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int sumOfDigits (int number)
{
    int sum = 0;
    int digit = 0;
    while (number > 0)
    {
        digit = number % 10;
        sum = sum + digit;
        number = number / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = sumOfDigits (number);
Console.WriteLine($"Сумма цифр в числе {number} равна {result}.");