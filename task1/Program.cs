/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int checkPowAbs(int numberB)
{
    if (numberB < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Введенная степень {numberB} не является натуральной, она будет автоматически преобразована в натуральную.");
        Console.ResetColor();
        numberB = Math.Abs(numberB);
    }
    return numberB;
}
int numberAPowNumberB(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.WriteLine("Введите число, которое хотите возвести в степень");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int numberB = Convert.ToInt32(Console.ReadLine());
numberB = checkPowAbs(numberB);
int resultPow = numberAPowNumberB(numberA, numberB);
Console.WriteLine($"Результат возведения числа {numberA} в степень {numberB} равен {resultPow}.");