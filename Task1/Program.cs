//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

int max = firstnumber;
int min = secondnumber;

if(firstnumber > max) max = firstnumber;
if(secondnumber > max) max = secondnumber;
    Console.Write("max = ");
    Console.WriteLine(max);
if(firstnumber < min) min = firstnumber;
if(secondnumber < min) min = secondnumber;
    Console.Write("min = ");
    Console.WriteLine(min);