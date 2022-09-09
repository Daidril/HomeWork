//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Ведите число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

FindThirdDigit(firstnumber);

void FindThirdDigit(int secondnumber)
{
    if(secondnumber < 100) 
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
{
    while (secondnumber >= 1000)
    {
        secondnumber = secondnumber / 10;
    }
    Console.WriteLine(secondnumber % 10);
}

}