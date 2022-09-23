/*  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();
Console.WriteLine("Введите число: ");
string? n = Convert.ToString(Console.ReadLine());
Console.WriteLine(n[n.Length - 2]);