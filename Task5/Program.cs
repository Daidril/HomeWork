//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

FindSecondDigit(number1);

void FindSecondDigit(int number1)
{
    Console.WriteLine(number1 % 100 / 10);
}