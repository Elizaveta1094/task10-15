﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру недели от 1 до 7 : ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 1)
{
    Console.WriteLine("Нет");
}
if(number == 2)
{
    Console.WriteLine("Нет");
}
if(number == 3)
{
    Console.WriteLine("Нет");
}
if(number == 4)
{
    Console.WriteLine("Нет");
}
if(number == 5)
{
    Console.WriteLine("Нет");
}
if(number == 6)
{
    Console.WriteLine("Да");
}
if(number == 7)
{
    Console.WriteLine("Да");
}