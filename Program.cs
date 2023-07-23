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

// Console.Write("Введи число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// string num1Text = Convert.ToString(num1);
// if (num1Text.Length > 2)
// {
//   Console.WriteLine("третья цифра " + num1Text[2]);
// }
// else 
// {
//   Console.WriteLine("третьей цифры нет");
// }


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("ведите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if(num1 == 1)
// {
//     Console.WriteLine("Понедельник - Нет");
// }

// else if (num1 == 2)
// {
//     Console.WriteLine("Вторник - Нет");
// }

// else if(num1 == 3)
// {
//     Console.WriteLine("Среда - Нет");
// }

// else if (num1 == 4)
// {
//     Console.WriteLine("Четверг - Нет");
// }

// else if(num1 == 5)
// {
//     Console.WriteLine("Пятница - Нет");
// }

// else if(num1 == 6)
// {
//     Console.WriteLine("Суббота - Да");
// }

// else if(num1 == 7)
// {
//     Console.WriteLine("Воскресенье - Да");
// }

// else
// {
//     Console.WriteLine("Нет такого дня недели");
// }

// ThreadExceptionEventArgs