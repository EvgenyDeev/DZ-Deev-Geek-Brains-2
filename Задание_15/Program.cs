/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.Clear();
Console.WriteLine("Введите число, обозначающее день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n < 6 )
{
    Console.WriteLine("Это не выходной");
    return;
}
if(n > 7)
{
    Console.WriteLine("-1");
}
else
{
    Console.WriteLine("Это выходной!");
}