// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("ведите трёхзначное число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int num2 = (num1 / 100 * 100);
// int num3 = (num1 % 10); 
// int numtotal = ((num1 - num2 - num3)/10);

// Console.WriteLine(numtotal);

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("ведите число");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1>99)
{
int num2 = (num1 / 100 * 100);
int num3 = (num1 % 10); 
int numtotal = ((num1 - num2 - num3)/10);
Console.WriteLine(numtotal);
}

else if (num1>999)
{
int numtotal = (Index2);
Console.WriteLine(numtotal);
}

else
{
   Console.WriteLine("третьей цифры нет"); 
}