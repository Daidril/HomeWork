//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели: ");
int numDay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckWeekends(numDay));

bool CheckWeekends(int numDayCheck)
{
    return numDayCheck == 6 || numDayCheck == 7;
}
