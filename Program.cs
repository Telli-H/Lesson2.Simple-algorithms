﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// Квадрат в ОБЕ стороны.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.WriteLine("input 2 numbers: ");
        
// // Считываем ввод пользователя и преобразуем его в числа
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1==number2*number2 || number2==number1*number1)
// {
//     Console.WriteLine($"{number1} is square of the {number2} or {number2} is square of the {number1}");
// }
// else 
// {
//     Console.WriteLine($"neitner {number1} nor {number2} is squere of each other");
// }


//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("input (X and Y):");
            
            // Считываем значения X и Y с консоли
            Console.Write("X = ");
            double x = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            
            // Выводим результат напрямую 
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point is in the 1st coordinate quarter");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point is in the 2nd coordinate quarter.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point is in the 3rd coordinate quarter");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point is in the 4th coordinate quarter");
            }
            else
            {
                Console.WriteLine("The point is on the axis or at the origin");
            }