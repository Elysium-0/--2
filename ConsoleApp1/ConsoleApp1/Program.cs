﻿using System;

class Program
{
    static void Main()
    {
        while (true)
        {   

            Console.WriteLine("Введите первое число: ");
            double firstN = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double secondN = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите оператор (+, -, *, /): ");
            string Operator = Console.ReadLine();
            double res = 0;
            bool test = true;

            if (Operator == "+")
            {
                res = firstN + secondN;
            }
            else if (Operator == "-")
            {
                res = firstN - secondN;
            }
            else if (Operator == "*")
            {
                res = firstN * secondN;
            }
            else if (Operator == "/")
            {
                if (secondN == 0)
                {
                    Console.WriteLine("Ошибка: деление на 0");
                    test = false;
                }
                else res = firstN / secondN;
            }
            if (test = true)
            {
                Console.WriteLine($"Результат: {res}");
            }
            else Console.WriteLine("Неверные значения.");
            Console.WriteLine("Хотите продолжить(да или нет): ");
            string con = Console.ReadLine();
            if (con.ToLower() != "да")
            {
                break;
            }
        }
    }
}