//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).         
Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb % 2 == 0) //Проверка числа на четность.
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}