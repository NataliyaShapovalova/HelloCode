﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int n)
{
    if (n > 99999 || n < 10000) Console.WriteLine("Ошибка! Вы ввели не пятизначное число!!!");
    else
    {
        if (n%10 == n/10000 && n/1000%10 == n%100/10) Console.WriteLine("Число является палиндромом!");
        else Console.WriteLine("Число НЕ является палиндромом!");
    }
}

try
{
    Console.WriteLine("Введите пятизначное число: ");
    int x  = Convert.ToInt32(Console.ReadLine());
    int n = Math.Abs(x);
    Palindrom(n);
}

catch
{
    Console.WriteLine("Ошибка! Программа работает только с целыми пятизначными числами!");
}